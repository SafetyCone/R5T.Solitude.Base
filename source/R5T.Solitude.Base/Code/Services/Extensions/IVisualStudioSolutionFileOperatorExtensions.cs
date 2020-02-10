using System;


namespace R5T.Solitude
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static void AddProjectFile(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator, string solutionFilePath, string projectFilePath, Guid projectTypeGuid)
        {
            var newProjectGuid = Guid.NewGuid();

            visualStudioSolutionFileOperator.AddProjectFile(solutionFilePath, projectFilePath, projectTypeGuid, newProjectGuid);
        }
    }
}
