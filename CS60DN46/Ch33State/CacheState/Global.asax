﻿<%@ Application Language="C#" %>
<%@ Import Namespace = "AutoLotDAL.Repos" %>

<script runat="server">
    //Define a static-level Cache member variable
    static Cache _theCache;

    void Application_Start(object sender, EventArgs e)
    {
        _theCache = Context.Cache;

        var theCars = new InventoryRepo().GetAll();

        _theCache.Insert("CarList",
            theCars, null,
            DateTime.Now.AddSeconds(30),
            Cache.NoSlidingExpiration,
            CacheItemPriority.Default,
            UpdateCarInventory);
    }

    // The target for the CacheItemRemovedCallback delegate
    static void UpdateCarInventory(string key, object item, CacheItemRemovedReason reason) {
        var theCars = new InventoryRepo().GetAll();
        _theCache.Insert("CarList",
            theCars, null,
            DateTime.Now.AddSeconds(30),
            Cache.NoSlidingExpiration,
            CacheItemPriority.Default,
            UpdateCarInventory);
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

</script>
