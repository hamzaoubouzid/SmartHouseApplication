﻿using SmartHouseApp.Controls;
using SmartHouseApp.Platforms;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace SmartHouseApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping("Classic", (handler, view) =>
        {
            if (view is CustomEntry)
            {
                CustomEntryMapper.Map(handler, view);
            }
        });

        return builder.Build();
	}
}
