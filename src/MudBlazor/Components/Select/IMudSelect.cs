﻿namespace MudBlazor.Components.Select
{
    internal interface IMudSelect
    {
        void CheckGenericTypeMatch(object select_item);
        bool MultiSelection { get; set; }

    }
}
