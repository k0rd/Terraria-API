﻿using Terraria;

namespace TerrariaAPI.Hooks
{
    public static class ClientHooks
    {
        static ClientHooks()
        {
            NetHooks.SendData += NetHooks_SendData;
        }

        private static void NetHooks_SendData(SendDataEventArgs e)
        {
            if (Main.netMode != 2)
            {
                if (e.msgType == MsgTypes.ChatMessage)
                {
                    string msg = e.text;
                    e.Handled = OnChat(ref msg);
                    e.text = msg;
                }
            }
        }

        public delegate void OnChatD(ref string msg, HandledEventArgs e);
        public static event OnChatD Chat;

        public static bool OnChat(ref string msg)
        {
            if (Chat != null)
                return false;
            HandledEventArgs args = new HandledEventArgs();
            Chat(ref msg, args);
            return args.Handled;
        }
    }
}