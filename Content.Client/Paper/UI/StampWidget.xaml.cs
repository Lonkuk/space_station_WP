using Content.Shared.Paper;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.Paper.UI
{
    [GenerateTypedNameReferences]
    public sealed partial class StampWidget : Container
    {
        public string? Stamper {
            get => StampedByLabel.Text;
            set => StampedByLabel.Text = value;
        }

        public StampWidget()
        {
            RobustXamlLoader.Load(this);
        }
    }
}
