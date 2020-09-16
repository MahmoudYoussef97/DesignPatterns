using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing
{
    public class DocumentHistory
    {
        public Stack<DocumentState> documentStates = new Stack<DocumentState>();

        public void Backup(DocumentState documentState)
        {
            documentStates.Push(documentState);
        }
        public DocumentState Undo()
        {
            DocumentState documentState = documentStates.Pop();
            return documentState;
        }
    }
}
