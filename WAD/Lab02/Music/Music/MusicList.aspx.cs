using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Music.Models;

namespace Music
{
    public partial class MusicList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<AppMusic> GetMusics([QueryString("id")] int? categoryId)
        {
            var _db = new Music.Models.MusicContext();
            IQueryable<AppMusic> query = _db.Musics;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(musicList => musicList.CategoryID == categoryId);
            }
            return query;
        }
        }
}