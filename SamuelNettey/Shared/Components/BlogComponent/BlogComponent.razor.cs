using Microsoft.AspNetCore.Components;

namespace SamuelNettey.Shared.Components.BlogComponent
{
    public partial class BlogComponent
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string Author { get; set; }

        [Parameter]
        public string Img { get; set; }

        [Parameter]
        public string Date { get; set; }

        [Parameter]
        public int Comments { get; set; }

        [Parameter]
        public string[] Technologies { get; set; }
    }
}
