using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group18__iCLOTHINGApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Group18__iCLOTHINGApp.Controllers
{
    public class AboutUsInformationController : Controller
    {
        public IActionResult AboutUsInformation()
        {
            AboutUs aboutUs = new AboutUs
            {
                companyAddress = "In Italy's embrace, where sunbeams play,\nThe countryside unfolds in a wondrous display.\nRolling hills adorned in hues so bright,\nA tapestry of green, a painter's delight.\n\nVineyards stretch far, rows neatly aligned,\nTheir grapes whisper secrets in the whispering wind.\nOlive groves dance in the golden light,\nTheir silvery leaves shimmering, a breathtaking sight.",
                companyShippingPolicy = "Through valleys deep and mountains high,\nWith steadfast stride and watchful eye,\nThe mule, a trusty courier, plies its trade,\nBearing burdens along the winding cascade.\n\nWith sturdy hooves on ancient trails,\nIt carries goods through sun and gales,\nA noble beast of burden, strong and true,\nIn the wilderness, its journey it will pursue.",
                companyReturnPolicy = "In a whimsical twist, a curious sight,\nA package dispatched in the dead of night,\nNot through the post or courier's hand,\nBut with a cannon, across the land.\n\nWith a thunderous boom and a fiery blast,\nThe parcel soars, its journey vast,\nThrough the starlit sky, on wings of flame,\nA spectacle wild, a daring game.",
                companyContactInfo = "In the realm where connections bloom,\nWhere voices echo, dispelling gloom,\nThere lies a haven, tried and true,\nOur contact service, unparalleled in view.\n\nThrough wires unseen, our whispers fly,\nUniting souls beneath the sky,\nWith every call, a bridge we build,\nAcross vast distances, hearts fulfilled.",
                companyBusinessDescription = "Epic swag"
            };
            return View(aboutUs);
        }
    }
}

