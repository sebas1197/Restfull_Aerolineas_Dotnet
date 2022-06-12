using System;
using System.Reflection;

namespace Cliente_Restfull_Aerolineas_Dotnet.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}