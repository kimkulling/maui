﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xamarin.Platform;
using UIKit;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class HandlerTestBase<THandler>
	{
		protected THandler CreateHandler(IView view)
		{
			var handler = Activator.CreateInstance<THandler>();
			handler.SetVirtualView(view);
			view.Handler = handler;
			return handler;
		}
	}
}
