﻿using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Android.Views.Adapters
{
    public class ItemType1RecyclerViewAdapter : MvxRecyclerAdapter
    {
        public ItemType1RecyclerViewAdapter(IMvxAndroidBindingContext bindingContext)
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

            public ViewHolder(View itemView, IMvxAndroidBindingContext context)
                : base(itemView, context)
            {
                this._innerText = itemView.FindViewById<TextView>(Resource.Id.innerText);
                this.DelayBind(() =>
                {
                    var set = this.CreateBindingSet<ViewHolder, ItemType1>();
                    set.Bind(this._innerText).To(x => x.Name);
                    set.Apply();
                });
            }
        }
    }
}
