using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Android.Views.Adapters
{
    public class ItemType2RecyclerViewAdapter : MvxRecyclerAdapter
	{
		public ItemType2RecyclerViewAdapter(IMvxAndroidBindingContext bindingContext)
            : base(bindingContext)
		{
		}

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, this.BindingContext.LayoutInflaterHolder);
            var view = this.InflateViewForHolder(parent, viewType, itemBindingContext);

            return new ViewHolder(view, itemBindingContext);
        }

        public class ViewHolder : MvxRecyclerViewHolder
        {
            private readonly TextView _innerText;
            private readonly MvxRecyclerView _itemType1List;

            public ViewHolder(View itemView, IMvxAndroidBindingContext context)
                : base(itemView, context)
            {
                this._innerText = itemView.FindViewById<TextView>(Resource.Id.innerText);
                this._itemType1List = itemView.FindViewById<MvxRecyclerView>(Resource.Id.itemtype1list_recyclerview);

                var adapter = new ItemType1RecyclerViewAdapter((IMvxAndroidBindingContext)this.BindingContext);
                _itemType1List.Adapter = adapter;
                
                this.DelayBind(() =>
                {
                    var set = this.CreateBindingSet<ViewHolder, ItemType2>();
                    set.Bind(this._innerText).To(vm => vm.Name);
                    set.Bind(this._itemType1List).For(v => v.ItemsSource).To(vm => vm.ItemType1List);
                    set.Apply();
                });
            }
        }
    }
}
