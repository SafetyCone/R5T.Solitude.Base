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

        void AddProjectFile(string solutionFilePath, string projectFilePath, Guid projectTypeGuid, Guid projectGuid);

        bool HasProjectFile(string solutionFilePath, string projectFilePath);

        bool RemoveProjectFile(string solutionFilePath, string projectFilePath);

        /// <summary>
        /// Lists solution project file references, NOT including any solution folders.
        /// </summary>
        IEnumerable<string> ListProjectReferenceFilePaths(string solutionFilePath);

        void AddSolutionFolder(string solutionFilePath, string solutionFolderPath);

        bool HasSolutionFolder(string solutionFilePath, string solutionFolderPath);

        bool RemoveSolutionFolderAndContents(string solutionFilePath, string solutionFolderPath);

        void MoveProjectFileIntoSolutionFolder(string solutionFilePath, string projectFilePath, string solutionFolderPath);

        void MoveProjectFileOutOfSolutionFolder(string solutionFilePath, string projectFilePath, string solutionFolderPath);

        IEnumerable<string> ListRootProjectFilePaths(string solutionFilePath);

        IEnumerable<string> ListSolutionFolderProjectFilePaths(string solutionFilePath, string solutionFolderPath);

        IEnumerable<string> ListRootSolutionFolderNames(string solutionFilePath);

        IEnumerable<string> ListSolutionFolderSolutionFolderNames(string solutionFilePath, string solutionFolderPath);
    }
}
