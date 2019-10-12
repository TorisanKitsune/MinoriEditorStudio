using System;
using System.Windows.Input;
using MinoriEditorShell.Commands;

namespace MinoriEditorShell.Platforms.Wpf.Menus
{
    public abstract class MenuDefinitionBase
    {
        public abstract int SortOrder { get; }
        public abstract string Text { get; }
        public abstract Uri IconSource { get; }
        public abstract KeyGesture KeyGesture { get; }
        public abstract CommandDefinitionBase CommandDefinition { get; }
    }
}