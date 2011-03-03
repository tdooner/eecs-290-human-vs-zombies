﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Human_vs_Zombies.Menus.MenuDelegates;
using Human_vs_Zombies.GameElements;
using Human_vs_Zombies.Controls;

namespace Human_vs_Zombies.Menus
{
    class GameOverMenu : Menu
    {
        public GameOverMenu(Vector2 position, MenuAction[] actions, float spacing)
            : base(position, actions)
        {
            MenuEntry quit = new MenuEntry(
                "Try Again",
                new MenuAction[] 
                { 
                    new MenuAction(ActionType.Select, new GameOverDelegate())
                },
                position + new Vector2(0, spacing));

            quit.UpperMenu = quit;
            quit.LowerMenu = quit;

            this.Add(quit);
        }
    }
}
