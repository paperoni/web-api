Fist steps after loading solution for the fist-time:

1. Goto: Tools > Nuget Package Manager > Package Manage Console
2. At the console (usually at the bottom), select [].DataAccess as the default project
3. Type "Update-Database" and press "Enter"
4. Database should be created automatically

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

List of commands:

Enable-Migrations                                                             // 
Enable-Migrations -ProjectName:<Project-Name> -MigrationsDirectory:<Migration-Directory>

Add-Migrations <Migrations-Name>                                              // 
Add-Migrations <Migrations-Name> -ProjectName:<Project-Name>

Update-Database -ProjectName:<Project-Name> -verbose                          // Apply latest migration to database
Update-Database <Migration-Name> -ProjectName:<Project-Name> -verbose         // Apply specific migration to database
Update-Database -ProjectName:<Project-Name> -verbose -script                  // Generate sql scripts instead of applying to database

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

FAQ:
1. What to do in-case of accidentally applying bad migration?
    a. Take the Down from the bad migration and put it in a new migration (you will also need to make the subsequent changes to the model). This is effectively rolling up to a better version.
       (This is the only options available if the migration manage to reach testing or production or other dev's env)
	  
    b. The other option is to actually run Update-Database –TargetMigration: TheLastGoodMigration against your deployed database and then delete the migration from your solution. 
       This is kinda the hulk smash alternative and requires this to be performed against any database deployed with the bad version. 
       Note: to rescaffold the migration you can use Add-Migration [existingname] -Force. This will however overwrite your existing migration, 
       so be sure to do this only if you have removed the existing migration from the database. This does the same thing as deleting the existing migration file and running add-migration.
       (This option feasible if the migration is not checked in yet / not applied to other env.)

    Source: http://stackoverflow.com/questions/22680446/entity-framework-rollback-and-remove-bad-migration


2. What to do if I have performed Add-Migration

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Tutorials:
https://msdn.microsoft.com/en-us/data/jj591621.aspx
http://www.entityframeworktutorial.net/
http://www.dotnet-tricks.com/Tutorial/entityframeworklist