# Sitecore.10.2.0.CarServ.Project
This project contains simple demo of using sitecore cms for managing car template.

-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
Visual Studio setup for the project
-------------------------------------
1. Visual Studio Installer - Select and Install ".NET framework project and item templates"
2. Add two Nuget package sources
	- https://api.nuget.org/v3/index.json
	- https://sitecore.myget.org/F/sc-packages/api/v3/index.json

Add new project in VS and deploy
--------------------------------------
1. Add new ASP.NET Web Framework project with .NET 4.8 framework
2. Select empty project with MVC folders
3. Delete or Make the Build action to None for Global.asax and web.config files
4. Update (to lower version) the default MVC nuget packages
5. Take the back up of C:\inetpub\wwwroot\xp10sc.dev.local
6. Create the Publish action in VS to the above deploy location path
	- Mark Delete the existing files to "false"
	- Mark the Configuration to "Debug" mode
7. Deploy and load the site, if any errors try to update the nuget packages further

Sitecore Compatibility Table
------------------------------------
https://support.sitecore.com/kb?id=kb_article_view&sysparm_article=KB0087164

--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

# Sitecore Demo
------------------------------------------------------------------------------------------------------------------
Add new website in Sitecore
----------------------------------
1. Add Site definition configuration file
2. Add host entry on etc/hosts file.
3. Add new url binding on the website in IIS

-----------------------------------------------------

## Create Site Struture
	- Create Site node setting, Home page and Data folder templates, add Standard values 
		for each of them.
	- Create Items based on all the three templates under /sitecore/content
	- update the sitedefinition with new rootpath

## Add Layout
	- Add new view under Views folder and name it basiclayout
	- Download a free HTML website template from https://www.free-css.com/free-css-templates
	- From index.html take out the structure and assets and add it to VS solution and update the paths
		for js, css files.
	- Create an MVC layout and add the newly created view path (remove the ~ from the path)
	- Add the MVC layout on the Home page -> Standard values presentation details -> shared layout


## Create a component (View Rendering) - example: Hero
	- Pick a simple component (Hero) from the HTML template website
	- Decide the fields (Title, Primary link, Secondary link) and their types based on the content on the component
	- Create a data template (Hero Data) with all the fields and field types (one field section is enough)
	- Add new View file (Hero.cshtml) in the VS, and render the newly created fields using Sitecore HTML helpers
	- Add a placeholder with 'main' key on the layout (view file) - Ignore if it's already exist
	- Create an item (Hero Data) using newly created data template and fill the content
	- Create a View rendering (Hero) under Layout/Renderings and add the newly created View file path
	- Add the View rendering(Hero component) to the Home page -> presentation details 
		-> shared layout
	- Map the created content item (Hero data) to the Home page -> presentation details -> Components data source
  
  ----------------------------------------------------------------------------------------------------------------------
  ----------------------------------------------------------------------------------------------------------------------
  
 # Sitecore Serialization 
- TDS (Team Development for Sitecore) by Sitecore company - Paid
- Unicorn by Open Source Community - Free
- Sitecore Content Serialization (SCS) by Sitecore company - Paid or Free


Unicorn nuget package installation
-----------------------------------
- Search for Unicorn nuget package in All or nuget package source
- Install the latest version (4.1.6) of Unicorn with "Lowest" for dependecies
- Enable Unicorn.DataProvider.10.1.config
- Enable Unicorn.UI.IdentityServer.config
- Delete Unicorn.DataProvider.config

Make sure all the config files Build action to content.

Where to store the Items?
Physical path (TargetDatastore)

What Items to store?
Predicate (Icnlude)

Unicorn page access
- https://xp10sc.dev.loca/unicorn.aspx (same crendetials as Sitecore login)

## Serialization
----------------------
- Custom Templates
- Custom layout and Renderings
- Media items
- Content tree
- Any core DB custom items
