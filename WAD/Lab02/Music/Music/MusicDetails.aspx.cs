using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Music
{
    public partial class MusicDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<AppMusic> GetMusic([QueryString("musicID")] int? musicId)
        {
            var _db = new Music.Models.MusicContext();
            IQueryable<AppMusic> query = _db.Musics;
            if (musicId.HasValue && musicId > 0)
            {
                query = query.Where(p => p.MusicID == musicId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}