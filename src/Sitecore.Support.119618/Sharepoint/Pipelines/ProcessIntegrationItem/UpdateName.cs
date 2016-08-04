namespace Sitecore.Support.Sharepoint.Pipelines.ProcessIntegrationItem
{
  using System;
  using Sitecore.Data.Items;
  using Sitecore.Diagnostics;
  using Sitecore.Sharepoint.Pipelines.ProcessIntegrationItem;

  [UsedImplicitly]
  public class UpdateName
  {
    [UsedImplicitly]
    public UpdateName()
    {
    }

    [UsedImplicitly]
    public virtual void Process(ProcessIntegrationItemArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));

      var targetIntegrationItem = args.IntegrationItem;
      var sourceSharepointItem = args.SourceSharepointItem;

      Assert.IsNotNull(targetIntegrationItem, nameof(targetIntegrationItem));
      Assert.IsNotNull(sourceSharepointItem, nameof(sourceSharepointItem));

      var sourceName = sourceSharepointItem.Title;
      var targetName = targetIntegrationItem.Name;
      if (targetName.Equals(sourceName, StringComparison.Ordinal))
      {
        return;
      }

      using (new EditContext(targetIntegrationItem))
      {
        targetIntegrationItem.Name = sourceName;
      }
    }
  }
}