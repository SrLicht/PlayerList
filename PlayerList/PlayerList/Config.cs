using CommandSystem;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace PlayerList
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string CommandName { get; set; } = "players";
        public string[] CommandAlias { get; set; } = new string[] { "plys", "caca" };
        public string CommandDescription { get; set; } = "This command returns a list of players to be run with DiscordIntegration";
        public bool UseDiscordCodeBlock { get; set; } = true;
        [Description("if UseDiscordCodeBlock is true, what type of code block do you want to use ? diff, md, cs, Js, yml. ")]
        public string WhatTypeOfCodeBlock { get; set; } = "diff";
        [Description("I am using double quote so that Yaml does not break the configuration.")]
        [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
        public string TextTitle { get; set; } = "+-----+-------+--------+\n|  ID  |  Nick  |  Role  |\n";

        [Description("{0} = minutes id, {1} = seconds")]
        [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
        public string TextTimeFormat { get; set; } = "- Round Time: {0}:{1}\n";

        [Description("{0} = current players, {1} = max players | \\n is important")]
        [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
        public string TextTotalPlayersFormat { get; set; } = "-- Players: {0}/{1}\n";

        [Description("{0} = player id, {1} = Nickname, {2} = RoleType| \\n is important")]
        [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
        public string TextperPlayer { get; set; } = "+ {0} - {1} - {2}\n";
        public bool RemarksStaff { get; set; } = true;
        [Description("{0} = player id, {1} = Nickname, {2} = RoleType | \\n is important")]
        [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
        public string TextperStaffPlayer { get; set; } = "- {0} - {1} - {2}\n";
        public string NoPlayersOnline { get; set; } = "-- No Players Online -- ";

    }
}
