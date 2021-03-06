using System;
using System.Windows.Input;

namespace MinoriEditorShell.Models
{
    public abstract class MesStandardMenuItem : MesMenuItemBase
    {
        public abstract string Text { get; }
        public abstract Uri IconSource { get; }
        public abstract string InputGestureText { get; }
        public abstract ICommand Command { get; }
        public abstract bool IsChecked { get; }
        public abstract bool IsVisible { get; }
    }
}
