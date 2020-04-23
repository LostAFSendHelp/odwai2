using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace ODWai2.ODWaiCore.Controllers
{
    public class Helper
    {
        public static string LOG_PATH = @"../../Error log/";

        public static string get_path_argument(string raw_string)
        {
            return "\"" + raw_string.Replace("\\", "/") + "\"";
        }

        public static void log_error(string error)
        {
            Directory.CreateDirectory(LOG_PATH);
            File.WriteAllText(Path.GetFullPath(LOG_PATH) + "/" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt", error);
        }

        public static void open_explorer_at_path(string path)
        {
            string full_path = (Path.GetFullPath(path));
            Process.Start("explorer", full_path);
        }

        public static void draw_bounding_box(Image image, int root_x, int root_y, int width, int height)
        {
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle bounding_box = new Rectangle { X = root_x, Y = root_y, Width = width, Height = height };
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawRectangle(pen, bounding_box);
        }
    }
}
