﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using TerrariaAPI;
using TerrariaAPI.Hooks;

namespace ItemPlugin
{
    /// <summary>
    /// F9 = Item form
    /// </summary>
    public class ItemPlugin : TerrariaPlugin
    {
        public override string Name
        {
            get { return "Item"; }
        }

        public override Version Version
        {
            get { return new Version(1, 0); }
        }

        public override Version APIVersion
        {
            get { return new Version(1, 2); }
        }

        public override string Author
        {
            get { return "Jaex"; }
        }

        public override string Description
        {
            get { return "Give/Edit items"; }
        }

        private InputManager input;
        private ItemForm itemForm;

        public ItemPlugin(Main game)
            : base(game)
        {
            input = new InputManager();
            itemForm = new ItemForm();
        }

        public override void Initialize()
        {
            GameHooks.Update += GameHooks_Update;
        }

        public override void DeInitialize()
        {
            GameHooks.Update -= GameHooks_Update;
        }

        private void GameHooks_Update(GameTime obj)
        {
            if (Game.IsActive)
            {
                input.Update();

                if (input.IsKeyDown(Keys.F9, true))
                {
                    itemForm.Visible = !itemForm.Visible;
                }
            }
        }
    }
}