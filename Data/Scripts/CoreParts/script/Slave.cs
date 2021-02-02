using System;
using System.IO;
using Sandbox.ModAPI;
using VRage.Game.Components;
using static Scripts.PartStructure;
namespace Scripts
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, int.MaxValue)]
    public class Session : MySessionComponentBase
    {
        internal PartDefinition[] PartDefinitions;

        public override void LoadData()
        {
            Log.Init($"{ModContext.ModName}Init.log");
            MyAPIGateway.Utilities.RegisterMessageHandler(7772, Handler);
            Init();
            SendModMessage(true);
        }

        protected override void UnloadData()
        {
            Log.Close();
            MyAPIGateway.Utilities.UnregisterMessageHandler(7772, Handler);
            Array.Clear(Storage, 0, Storage.Length);
            Storage = null;
        }

        void Handler(object o)
        {
            if (o == null) SendModMessage(false);
        }

        void SendModMessage(bool sending)
        {
            if (sending) Log.CleanLine($"Sending request to core");
            else Log.CleanLine($"Receiving request from core");
            MyAPIGateway.Utilities.SendModMessage(7771, Storage);
        }

        internal byte[] Storage;

        internal void Init()
        {
            var parts = new Parts();
            PartDefinitions = parts.ReturnDefs();
            Log.CleanLine($"Found: {PartDefinitions.Length} part definitions");
            for (int i = 0; i < PartDefinitions.Length; i++)
            {
                Log.CleanLine($"Compiling: {PartDefinitions[i].HardPoint.PartName}");
                PartDefinitions[i].ModPath = ModContext.ModPath;

            }
            Storage = MyAPIGateway.Utilities.SerializeToBinary(PartDefinitions);
            Array.Clear(PartDefinitions, 0, PartDefinitions.Length);
            PartDefinitions = null;
            Log.CleanLine($"Handing over control to Core and going to sleep");
        }

        public class Log
        {
            private static Log _instance = null;
            private TextWriter _file = null;

            private static Log GetInstance()
            {
                return _instance ?? (_instance = new Log());
            }

            public static void Init(string name)
            {
                if (GetInstance()._file == null)
                    GetInstance()._file = MyAPIGateway.Utilities.WriteFileInLocalStorage(name, typeof(Log));
            }

            public static void CleanLine(string text)
            {
                if (GetInstance()._file == null) return;
                GetInstance()._file.WriteLine(text);
                GetInstance()._file.Flush();
            }

            public static void Close()
            {
                var instance = (GetInstance());
                if (instance._file == null) return;
                instance._file.Flush();
                instance._file.Close();
                instance._file.Dispose();
                instance._file = null;
                instance = null;
            }
        }
    }
}

