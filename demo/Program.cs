using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Serilog; // 引入第三方日志库

namespace SteamMaestro;

/// <summary>
/// Steam-Maestro 应用程序的入口点类
/// </summary>
public class Program
{
    /// <summary>
    /// 应用程序的主入口方法
    /// </summary>
    /// <param name="args">启动时传入的命令行参数</param>
    public static async Task Main(string[] args)
    {
        // ---------------------------------------------------------
        // 1. 配置初始化的基础设施 (Logging, Configuration)
        // ---------------------------------------------------------
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/maestro-.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        
        Log.Information("🚀 Steam-Maestro is starting up...");

        try
        {
            // ---------------------------------------------------------
            // 2. 构建依赖注入容器 (Dependency Injection)
            // ---------------------------------------------------------
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // ---------------------------------------------------------
            // 3. 初始化核心服务 (连接 Steam 客户端)
            // ---------------------------------------------------------
            var steamClient = serviceProvider.GetRequiredService<ISteamClient>();
            await steamClient.InitializeAsync();

            // ---------------------------------------------------------
            // 4. 启动主窗口 (假设我们使用 WPF 或 Avalonia)
            // ---------------------------------------------------------
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            await mainWindow.RunAsync();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "💥 A fatal error occurred during startup.");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    /// <summary>
    /// 将所有用到的服务、视图模型、窗口注册到依赖注入容器中
    /// </summary>
    private static void ConfigureServices(IServiceCollection services)
    {
        // 注册核心业务逻辑层 (Singleton 代表全局唯一实例)
        services.AddSingleton<ISteamClient, SteamClient>();
        
        // 注册 UI 层 (假设 MainWindow 是主窗口)
        services.AddTransient<MainWindow>();
        
        // 这里可以继续注册：数据库上下文、配置管理器、网络服务等
        // services.AddSingleton<IGameLibraryManager, GameLibraryManager>();
    }
}

// =========================================================
// 以下是为 Demo 准备的模拟接口与类定义
// =========================================================

/// <summary>
/// 模拟的 Steam 客户端接口
/// </summary>
public interface ISteamClient
{
    Task InitializeAsync();
}

/// <summary>
/// 模拟的 Steam 客户端实现
/// </summary>
public class SteamClient : ISteamClient
{
    public async Task InitializeAsync()
    {
        Log.Information("🔌 Initializing Steam Client...");
        // 模拟耗时的网络握手或本地文件加载
        await Task.Delay(1000); 
        Log.Information("✅ Steam Client initialized successfully.");
    }
}

/// <summary>
/// 模拟的主窗口类
/// </summary>
public class MainWindow
{
    public async Task RunAsync()
    {
        Log.Information("🖥️ Main Window launched. Ready for user interaction.");
        // 这里会启动 UI 消息循环 (如 Application.Run() in WPF)
        await Task.CompletedTask;
    }
}