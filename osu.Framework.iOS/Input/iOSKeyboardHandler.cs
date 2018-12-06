﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Input.Handlers;
using Foundation;
using UIKit;
using osuTK.Input;
using osu.Framework.Platform;

namespace osu.Framework.iOS.Input
{
    // ReSharper disable once InconsistentNaming
    public class iOSKeyboardHandler : InputHandler
    {
        private readonly iOSGameView view;

        public iOSKeyboardHandler(iOSGameView view)
        {
            this.view = view;
            view.KeyboardTextField.HandleShouldChangeCharacters += handleShouldChangeCharacters;
            view.KeyboardTextField.HandleShouldReturn += handleShouldReturn;
            view.KeyboardTextField.HandleKeyCommand += handleKeyCommand;
        }

        private void handleShouldChangeCharacters(NSRange range, string text)
        {
            // FIXME
            //if (text.Length == 0)
            //{
            //    if (range.Length > 0)
            //    {
            //        Key key = range.Location < iOSGameView.DummyTextField.cursor_position ? Key.BackSpace : Key.Delete;
            //        PendingInputs.Enqueue(new KeyboardKeyInput(key, true));
            //        PendingInputs.Enqueue(new KeyboardKeyInput(key, false));
            //    }
            //    return;
            //}

            //foreach (char c in text)
            //{
            //    bool upper = false;

            //    Key? key = keyForString(char.ToString(c), out upper);

            //    if (key.HasValue)
            //    {
            //        if (upper)
            //            PendingInputs.Enqueue(new KeyboardKeyInput(Key.LShift, true));

            //        PendingInputs.Enqueue(new KeyboardKeyInput(key.Value, true));
            //        PendingInputs.Enqueue(new KeyboardKeyInput(key.Value, false));

            //        if (upper)
            //            PendingInputs.Enqueue(new KeyboardKeyInput(Key.LShift, false));
            //    }
            //}
        }

        private void handleShouldReturn()
        {
            // FIXME
            //PendingInputs.Enqueue(new KeyboardKeyInput(Key.Enter, true));
            //PendingInputs.Enqueue(new KeyboardKeyInput(Key.Enter, false));
        }

        private void handleKeyCommand(UIKeyCommand cmd)
        {
            // FIXME
            //Key? key;
            //bool upper = false;
            //// UIKeyCommand constants are not actually constants, so we can't use a switch
            //if (cmd.Input == UIKeyCommand.LeftArrow)
            //    key = Key.Left;
            //else if (cmd.Input == UIKeyCommand.RightArrow)
            //    key = Key.Right;
            //else if (cmd.Input == UIKeyCommand.UpArrow)
            //    key = Key.Up;
            //else if (cmd.Input == UIKeyCommand.DownArrow)
            //    key = Key.Down;
            //else
            //    key = keyForString(cmd.Input, out upper);

            //if (key.HasValue)
            //{
            //    bool shiftHeld = (cmd.ModifierFlags & UIKeyModifierFlags.Shift) > 0 || upper;
            //    bool superHeld = (cmd.ModifierFlags & UIKeyModifierFlags.Command) > 0;
            //    bool ctrlHeld = (cmd.ModifierFlags & UIKeyModifierFlags.Control) > 0;
            //    bool optionHeld = (cmd.ModifierFlags & UIKeyModifierFlags.Alternate) > 0;

            //    if (shiftHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LShift, true));
            //    if (superHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LWin, true));
            //    if (ctrlHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LControl, true));
            //    if (optionHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LAlt, true));

            //    PendingInputs.Enqueue(new KeyboardKeyInput(key.Value, true));
            //    PendingInputs.Enqueue(new KeyboardKeyInput(key.Value, false));

            //    if (optionHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LAlt, false));
            //    if (ctrlHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LControl, false));
            //    if (superHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LWin, false));
            //    if (shiftHeld) PendingInputs.Enqueue(new KeyboardKeyInput(Key.LShift, false));
            //}
        }

        private Key? keyForString(string str, out bool upper)
        {
            upper = false;
            if (str.Length == 0)
                return null;

            char c = str[0];
            switch(c)
            {
                case '\t':
                    return Key.Tab;

                case '1':
                case '!':
                    upper = !char.IsDigit(c);
                    return Key.Number1;

                case '2':
                case '@':
                    upper = !char.IsDigit(c);
                    return Key.Number2;

                case '3':
                case '#':
                    upper = !char.IsDigit(c);
                    return Key.Number3;

                case '4':
                case '$':
                    upper = !char.IsDigit(c);
                    return Key.Number4;

                case '5':
                case '%':
                    upper = !char.IsDigit(c);
                    return Key.Number5;

                case '6':
                case '^':
                    upper = !char.IsDigit(c);
                    return Key.Number6;

                case '7':
                case '&':
                    upper = !char.IsDigit(c);
                    return Key.Number7;

                case '8':
                case '*':
                    upper = !char.IsDigit(c);
                    return Key.Number8;

                case '9':
                case '(':
                    upper = !char.IsDigit(c);
                    return Key.Number9;

                case '0':
                case ')':
                    upper = !char.IsDigit(c);
                    return Key.Number0;

                case '-':
                case '_':
                    upper = c == '_';
                    return Key.Minus;

                case '=':
                case '+':
                    upper = c == '+';
                    return Key.Plus;

                case '`':
                case '~':
                    upper = c == '~';
                    return Key.Tilde;

                case '[':
                case '{':
                    upper = c == '{';
                    return Key.BracketLeft;

                case ']':
                case '}':
                    upper = c == '}';
                    return Key.BracketRight;

                case '\\':
                case '|':
                    upper = c == '|';
                    return Key.BackSlash;

                case ';':
                case ':':
                    upper = c == ':';
                    return Key.Semicolon;

                case '\'':
                case '\"':
                    upper = c == '\"';
                    return Key.Quote;

                case ',':
                case '<':
                    upper = c == '<';
                    return Key.Comma;

                case '.':
                case '>':
                    upper = c == '>';
                    return Key.Period;

                case '/':
                case '?':
                    upper = c == '?';
                    return Key.Slash;

                default:
                    if (char.IsLetter(c))
                    {
                        string keyName = c.ToString().ToUpper();
                        if (Enum.TryParse(keyName, out Key result))
                            return result;
                    }
                    return null;
            }
        }

        public override bool IsActive => true;

        public override int Priority => 0;

        protected override void Dispose(bool disposing)
        {
            view.KeyboardTextField.HandleShouldChangeCharacters -= handleShouldChangeCharacters;
            view.KeyboardTextField.HandleShouldReturn -= handleShouldReturn;
            view.KeyboardTextField.HandleKeyCommand -= handleKeyCommand;
            base.Dispose(disposing);
        }

        public override bool Initialize(GameHost host) => true;
    }
}
