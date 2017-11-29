using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  Define View's Path And Name
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
	public class UIType {

        public string Path { get; private set; }

        public string Name { get; private set; }

        public UIType(string path)
        {
            Path = path;
            Name = path.Substring(path.LastIndexOf('/') + 1);
        }

        public override string ToString()
        {
            return string.Format("path : {0} name : {1}", Path, Name);
        }

        //public static readonly UIType MainMenu = new UIType("View/MainMenuView");
        //public static readonly UIType OptionMenu = new UIType("View/OptionMenuView");
        //public static readonly UIType NextMenu = new UIType("View/NextMenuView");
        //public static readonly UIType HighScore = new UIType("View/HighScoreView");

        public static readonly UIType MainMenuPanel = new UIType("View/Main/MainMenuPanelView");
        public static readonly UIType MainChanelPanel = new UIType("View/Main/MainChanelPanelView");

        public static readonly UIType MenuPanel = new UIType("View/Menu/MenuPanelView");
        public static readonly UIType knapsackPanel = new UIType("View/Menu/knapsackPanelView");
        public static readonly UIType AchievementSystemPanel = new UIType("View/Menu/AchievementSystemPanelView");
        public static readonly UIType GrowthSystemPanel = new UIType("View/Menu/GrowthSystemPanelView");
        public static readonly UIType BattleWatchingPanel = new UIType("View/Menu/BattleWatchingPanelView");
        public static readonly UIType StorePanel = new UIType("View/Menu/StorePanelView");
        public static readonly UIType HeroPanel = new UIType("View/Menu/HeroPanelView");
        public static readonly UIType TeamPanel = new UIType("View/Menu/TeamPanelView");
        public static readonly UIType CommunityPanel = new UIType("View/Menu/CommunityPanelView");
        public static readonly UIType CompetitionPanel = new UIType("View/Menu/CompetitionPanelView");
        public static readonly UIType ActivityPanel = new UIType("View/Menu/ActivityPanelView");
        public static readonly UIType InscriptionPanel = new UIType("View/Menu/InscriptionPanelView");
    }
}
