﻿using System.Linq;
using Content.Shared.Corvax.Sponsors;
using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Administration.UI.Tabs.SponsorTab;

[GenerateTypedNameReferences]
public sealed partial class SponsorTabEntry : ContainerButton
{
    public SponsorTabEntry(SponsorInfo sponsorInfo, StyleBox styleBox)
    {
        RobustXamlLoader.Load(this);

        UsernameLabel.Text = sponsorInfo?.CharacterName;
        TierLabel.Text = sponsorInfo?.Tier?.ToString();
        OocLabel.Text = sponsorInfo?.OOCColor;
        PriorityLabel.Text = sponsorInfo?.HavePriorityJoin == true ? "YES" : "NO";
        ExtraSlotsLabel.Text = sponsorInfo?.ExtraSlots.ToString();
        MarkingsLabel.Text = sponsorInfo?.AllowedMarkings != null ? string.Join(',', sponsorInfo.AllowedMarkings) : "";

        BackgroundColorPanel.PanelOverride = styleBox;
    }
}
