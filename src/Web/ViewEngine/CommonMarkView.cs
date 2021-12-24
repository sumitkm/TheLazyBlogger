namespace TheLazyBlogger;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Markdig;

public class CommonMarkView : IView
{
    public CommonMarkView(string path)
    {
        Path = path;
    }
    public string Path { get; private set; }

    public Task RenderAsync(ViewContext context)
    {
        var template = File.ReadAllText(Path);

        var processedOutput = Markdown.ToHtml(template);

        return context.Writer.WriteAsync(processedOutput);
    }
}