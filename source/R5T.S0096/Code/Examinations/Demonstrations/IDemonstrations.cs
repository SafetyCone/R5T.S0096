using System;

using R5T.T0141;


namespace R5T.S0096
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void AdjustRepositoryName_ForPrivacy()
        {
            /// Inputs.
            var repositoryName = Instances.Values.Sample_RepositoryName;
            var isPrivate = false;


            /// Run.
            var privacyAdjustedRepositoryName = Instances.RepositoryNameOperator.AdjustRepositoryName_ForPrivacy(
                repositoryName,
                isPrivate);

            Console.WriteLine(
                $"{privacyAdjustedRepositoryName}: privacy adjusted repository name\n\t{repositoryName}: repository name\n\t{isPrivate}: is-private");
        }
    }
}
