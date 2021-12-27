using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlueThinnerClient.Utils
{
    public static class Extensions
    {
        public static event Action<Window>? OnOpen;
        public static Task OpenNew(this Window page)
        {
            OnOpen?.Invoke(page);
            while (page.ShowDialog() ?? false);
            return Task.CompletedTask;
        }

        public static void Await(this Task task) =>
            task.GetAwaiter().GetResult();
    }
}
