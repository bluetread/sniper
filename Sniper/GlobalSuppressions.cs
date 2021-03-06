using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

[assembly: SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider, MessageId = "System.String.Format(System.String,System.Object)", Scope = Scopes.Member, Target = "Sniper.FileAndDirectory.ConfigurationFiles.#.cctor()")]
[assembly: SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider, MessageId = "System.String.Format(System.String,System.Object[])", Scope = Scopes.Member, Target = "Sniper.Configuration.SiteData.#SiteUrl")]