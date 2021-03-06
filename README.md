# CSharpSyntax
 C Sharp syntax check

(1) There exists an issue needed to be fixed.
In project CS60DN46/Ch33State/FunWithProfiles, an error message as below was received in the chrome.

The user instance login flag is not allowed when connecting to a user instance of SQL Server. The connection will be closed.

the connectionString in C:\Windows\Microsoft.NET\Framework\v4.0.30319\Config\machine.config:

  <connectionStrings>
    <add name="LocalSqlServer" connectionString="data source=(localDb)\MSSQLLocalDb;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true" providerName="System.Data.SqlClient" />
  </connectionStrings>
