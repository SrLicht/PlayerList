using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerList
{
    public class PlayerList : Plugin<Config>
    {
        private static readonly PlayerList Singleton = new PlayerList();

        private PlayerList()
        {
        }

        /// <summary>
        /// Gets the only existing instance of this plugin.
        /// </summary>
        public static PlayerList Instance => Singleton;

        public override string Author => "SrLicht";
        public override Version Version => new Version(1, 2, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }

    }
}
