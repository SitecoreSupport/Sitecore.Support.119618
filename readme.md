# Sitecore.Support.119618
Renaming file in SharePoint is not reflected by SPIF in media item

## Description
When a folder in SharePoint is integrated to Sitecore with SharePoint Integration Framework, renamings made in SharePoint directly are not propagated to Sitecore which means the correpsonding media item will remain its old name. 

The patch fixes the issue using custom `UpdateName` processor in `updateIntegrationItem` pipeline.

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.119618/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.119618/releases).  
