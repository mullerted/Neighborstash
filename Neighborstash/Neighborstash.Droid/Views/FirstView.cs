using Android.App;
using Android.OS;

namespace Neighborstash.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.MainView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
