using System;
using System.Collections.Generic;


namespace R5T.Solitude
{
    /// <summary>
    /// A (file-based) Visual Studio solution file operator.
    /// </summary>
    public interface IVisualStudioSolutionFileOperator
    {
        void CreateNewSolutionFile(string solutionFilePath);

        void AddProjectFile(string solutionFilePath, string projectFilePath, Guid projectTypeGuid);

        bool HasProjectFile(string solutionFilePath, string projectFilePath);

        bool RemoveProjectFile(string solutionFilePath, string projectFilePath);

        /// <summary>
        /// Lists solution project file references, NOT including any solution folders.
        /// </summary>
        IEnumerable<string> ListProjectReferenceFilePaths(string solutionFilePath);
    }
}
