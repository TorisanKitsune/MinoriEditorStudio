using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinoriEditorStudio.Framework.Services
{
    public interface IEditorProvider
	{
        IEnumerable<EditorFileType> FileTypes { get; }

		bool Handles(string path);

        IDocument Create();

        Task New(IDocument document, string name);
        Task Open(IDocument document, string path);
	}
}