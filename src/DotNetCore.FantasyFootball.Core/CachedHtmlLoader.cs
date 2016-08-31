using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core
{
    public class CachedHtmlLoader : IHtmlLoader
    {
        
        public string GetHtml(string pageUri)
        {
            switch (pageUri)
            {
                case "http://fantasy.nfl.com/research/rankings?leagueId=0&statType=draftStats":
                    return FantasyNfl.CleanHtml();
                case "http://www.fantasyfootballnerd.com/fantasy-football-draft-rankings":
                    return FantasyFootballNerd.CleanHtml();
                case "https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php":
                    return FantasyPros.CleanHtml();
            }
            return string.Empty;
        }

        const string FantasyPros = @"

<!DOCTYPE html>
<html lang='en'>

<head>
    <title>2016 Fantasy Football Draft Rankings, Consensus Draft Rankings, Overall Cheat Sheets</title>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
    <meta name='description' content='Don&#8217;t trust any 1 fantasy football expert? We combine their rankings into 1 Expert Consensus Ranking. Our 2016 Draft Overall rankings are updated daily.'>
<link rel='canonical' href='https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php' />

    <meta property='fb:pages' content='184352014941166'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>

    <link href='https://fonts.googleapis.com/css?family=Raleway:100,200,400,600,700,800' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:200,400,600,700,800' rel='stylesheet' type='text/css'>
    <link type='text/css' href='//cdn.fantasypros.com/css/font-awesome.4.6.3.min.css' rel='stylesheet'>
    <link type='text/css' href='//cdn.fantasypros.com/css/bootstrap.3.partial.min.css' rel='stylesheet'>
                    <link type='text/css' href='//cdn.fantasypros.com/css/colorbox.css' rel='stylesheet'>
    
            <link type='text/css' href='//cdn.fantasypros.com/css/style_20160816.css' rel='stylesheet'>
        
    <link type='text/css' href='//cdn.fantasypros.com/css/style_fp_20160705.css' rel='stylesheet'>
    <link type='text/css' href='//cdn.fantasypros.com/css/dlmenu-custom.css' rel='stylesheet'>

    <script src='https://ajax.googleapis.com/ajax/libs/jquery/2.2.2/jquery.min.js'></script>
    <!-- <link rel='stylesheet' href='https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/themes/smoothness/jquery-ui.css'> -->
    <script src='https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js'></script>

    <script src='//cdn.fantasypros.com/js/modernizr-custom.js'></script>
    <script src='//cdn.fantasypros.com/js/bootstrap.3.partial.min.js'></script>

    
    
    <script type='text/javascript'>
        (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
            (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
            m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
        })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

        ga('create', 'UA-17511397-1', 'auto');
        ga('create', 'UA-17511397-12', 'fantasypros.com', 'fp2');
        ga('require', 'linkid'); // Allow for enhanced link attribution

                
        
        // Check GA cookies to determine if user is coming from an iFramed widget
        var umtz = false,
        widgetReferrer = false,
        widgetType = false;
        
        var cookies = document.cookie.split(';');

        for (var i = 0; i < cookies.length; i++) {
            if (cookies[i].indexOf('__utmz') !== -1 && cookies[i].indexOf('/external/widget/') !== -1) {
                umtz = true;
            }
            
            if (cookies[i].indexOf('fp-widget-referrer') !== -1) {
                widgetReferrer = cookies[i].replace('fp-widget-referrer=','').trim();
            }
            
            if (cookies[i].indexOf('fp-widget-type') !== -1) {
                widgetType = cookies[i].replace('fp-widget-type=','').trim();
            }
        }
        
        if (widgetReferrer) {
            ga('set', 'referrer', widgetReferrer);
        }

        ga('send', 'pageview');
        ga('fp2.send', 'pageview');
        
        if (umtz && widgetType && widgetReferrer) {
            ga('send', {
                hitType: 'event',
                eventCategory: 'Widget',
                eventAction: 'iFrameClick',
                eventLabel: widgetType
            });
        }

        var googletag = googletag || {};
        googletag.cmd = googletag.cmd || [];
        (function() {
            var gads = document.createElement('script');
            gads.async = true;
            gads.type = 'text/javascript';
            var useSSL = 'https:' == document.location.protocol;
            gads.src = (useSSL ? 'https:' : 'http:') + 
            '//www.googletagservices.com/tag/js/gpt.js';
            var node = document.getElementsByTagName('script')[0];
            node.parentNode.insertBefore(gads, node);
        })();

        (function() {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://' : 'http://') + 'stats.g.doubleclick.net/dc.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();
    </script>
    <script type='text/javascript'>
      var _comscore = _comscore || [];
      _comscore.push({ c1: '2', c2: '18410647' });
      (function() {
        var s = document.createElement('script'), el = document.getElementsByTagName('script')[0]; s.async = true;
        s.src = (document.location.protocol == 'https:' ? 'https://sb' : 'http://b') + '.scorecardresearch.com/beacon.js';
        el.parentNode.insertBefore(s, el);
      })();
    </script>

          <link type='text/css' href='//cdn.fantasypros.com/css/colorbox.css' rel='stylesheet'>
    
    <style type='text/css'>.photo-box.dfs-item .photo {width: 15%;vertical-align: top;}.photo-box.dfs-item .title a,.photo-box.dfs-item .title a:hover {font-size: 18px;font-weight: 800;}.photo-box.dfs-item .title a:hover {color: #449DFC;}.photo-box.dfs-item .subtitle {color: #8b8b8b;}.side-content section .dfs-item .photo {max-width: 50px;}@media (min-width: 600px) {.side-content section .rank-table tr.read-more {display: none;}.side-content section .dfs-item {float: left;clear: none;width: 33%;padding-right: 30px;}.side-content section .dfs-item:nth-child(3n-1) {clear: left;}}@media (min-width: 1200px) {.side-content section .dfs-item {float: none;clear: both;width: 100%;padding-right: 0;}}</style>

<style type='text/css'>.photo-box.p-news-item {padding: 8px 0;}.photo-box.p-news-item .photo {width: 15%;}.photo-box.p-news-item .text {width: 85%;}.photo-box.p-news-item .extra,.photo-box.p-news-item .extra a {font-family: 'Raleway', sans-serif;font-size: 12px;font-weight: 400;color: #8b8b8b;line-height: 17px;}.photo-box.p-news-item .extra b {font-size: 14px;color: #212121;}.photo-box.p-news-item .extra a:hover b {color: #449DFC;}.side-content section .p-news-item .photo {max-width: 60px;}.side-content section .p-news-item:nth-child(n+8) {display: none;}.side-content .heading a:hover {color: #449DFC;}@media (min-width: 600px) {.side-content section .news-pane {width: 100%;box-sizing: border-box;}.side-content section .news-pane:after {clear: both;}.side-content section .p-news-item {float: left;clear: none;width: 50%;padding-right: 30px;min-height: 84px;}.side-content section .p-news-item:nth-child(n+8) {display: block;}.side-content section .p-news-item.read-more {display: none;}}@media (min-width: 1200px) {.side-content section .p-news-item {float: none;clear: both;width: 100%;padding-right: 0;min-height: 54px;}.side-content section .p-news-item:nth-child(n+8) {display: none;}.side-content section .p-news-item.read-more {display: block;}}</style>

<style type='text/css'>.ecr-pane .rank-icon {background-color: #fff;border-radius: 50%;text-align: center;padding: 3px 0px;display: inline-block;width: 26px;}.ecr-pane .player-name a {font-size: 15px;font-family: 'Raleway', sans-serif;color: #454545;font-weight: 400;}.ecr-pane .player-name a:hover {color: #449DFC;}.ecr-pane .pos {color: #8b8b8b;font-family: 'Raleway', sans-serif;font-weight: 400;}.ecr-pane .read-more a {font-size: 14px;font-family: 'Raleway', sans-serif;font-weight: 400;}.side-content section .rank-table {margin-bottom: 18px;}.side-content section .rank-table:nth-child(n+2) {display: none;}.side-content .heading a:hover {color: #449DFC;}@media (min-width: 600px) {.side-content section .rank-table tr.read-more {display: none;}.side-content section .rank-table {float: left;clear: none;width: 33%;padding-right: 10px;}.side-content section .rank-table:nth-child(n+2) {display: table;}}@media (min-width: 1200px) {.side-content section .rank-table {float: none;clear: both;width: 100%;padding-right: 0;}.side-content section .rank-table:nth-child(n+2) {display: none;}.side-content section .rank-table tr.read-more {display: table-row;}}</style>

    
    
    
    
                <script type='text/javascript'>
                    if ( /(iPad).*AppleWebKit.*Mobile.*Safari/.test(navigator.userAgent) ) {
                    } else {
                        var headNode = document.getElementsByTagName('head')[0];
                        var sbNode = document.createElement('meta');
                        sbNode.name = 'apple-itunes-app';
                        sbNode.content = 'app-id=1132708558, affiliate-data=1l3votR';
                        headNode.appendChild(sbNode);
                    }
                </script>

                <meta name='google-play-app' content='app-id=com.fantasypros.draftwizard.football'>
                <link rel='stylesheet' style='text/css' href='//cdn.fantasypros.com/js/smartbanner/jquery.smartbanner.css' media='screen' />
                <script src='//cdn.fantasypros.com/js/smartbanner/jquery.smartbanner-android-layer.js'></script>
                <script type='text/javascript'>
                    $(function() { $.smartbanner({title:'Free Draft Wizard App',url:'https://play.google.com/store/apps/details?id=com.fantasypros.draftwizard.football',author:'FantasyPros',price: 'FREE',icon:'https://lh3.googleusercontent.com/YP36sGilWqMJlccyi_Xkavti7kipLDuvUolJe44bf6CvE3awRMK5y0N_pmrlqVrxCjQ=w300-rw',daysHidden:3,daysReminder:7,iOSUniversalApp:false,inGooglePlay:'Download Now!',button:'Install'}) } );
                </script>

<script type='text/javascript'>
googletag.cmd.push(function() {
    if($(window).width() > 730) {
        // Show leaderboard
        googletag.defineSlot('/2705664/fantasypros_nfl_content_leaderboard_728x90_1', [728, 90], 'div-gpt-ad-1358392502308-0').addService(googletag.pubads());

        if ($(window).width() < 900) {
            // Show tablet sized ads
            googletag.defineSlot('/2705664/fantasypros_nfl_728x90_2', [728, 90], 'div-gpt-ad-1470375448721-0').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_728x90_3', [728, 90], 'div-gpt-ad-1470375518515-0').addService(googletag.pubads());
        } else {
            // Left sidebar size ads for nfl
            googletag.defineSlot('/2705664/fantasypros_nfl_content_skyscraper_160x600_2', [160, 600], 'div-gpt-ad-1349066428961-7').addService(googletag.pubads());
        }
    } else {
        // Mobile size ads for nfl
        googletag.defineSlot('/2705664/fantasypros_nfl_mobile_content_300x250', [300, 250], 'div-gpt-ad-1404326955317-0').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_mobile_content_300x250_2', [300, 250], 'div-gpt-ad-1425357685381-0').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_mobile_content_320x50', [320, 50], 'div-gpt-ad-1404326777280-0').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_mobile_content_320x50_2', [320, 50], 'div-gpt-ad-1404326895972-0').addService(googletag.pubads());
    }

    if($(window).width() >= 1200) {

        // Right sidebar size ads for nfl
        googletag.defineSlot('/2705664/fantasypros_nfl_content_sidebar_300x250_1', [300, 250], 'div-gpt-ad-1349068144086-9').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_content_sidebar_300x250_2', [300, 250], 'div-gpt-ad-1349068144086-10').addService(googletag.pubads());
googletag.defineSlot('/2705664/fantasypros_nfl_content_sidebar_300x250_3', [300, 250], 'div-gpt-ad-1349068144086-11').addService(googletag.pubads());

            var ad = googletag.defineSlot('/2705664/fantasypros_house_sidebar_300x250', [300, 250], 'div-gpt-ad-1364781516886-0');
        ad.addService(googletag.pubads());
        ad.setTargeting('MPB', ['b']);
        }
    googletag.pubads().enableSingleRequest();
    googletag.enableServices();
});

</script>    
        <script async src='//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js'></script>
    <script>
      (adsbygoogle = window.adsbygoogle || []).push({
        google_ad_client: 'ca-pub-0830611673308371',
        enable_page_level_ads: true
      });
    </script>
        <style>
    .table .tier-row td {
        line-height: 10px;
        background-color: #9f9f9f !important;
        color: #fff !important;
        border: none;
        font-size: 10px;
    }
    .table .tier-row td a {
        color: #fff;
    }
    .table .tier-row td.right{
        text-align: center;
    }
</style>
</head>


<body class='body-sticky'>

    <div id='fb-root'></div>
    <script>(function(d, s, id) {
      var js, fjs = d.getElementsByTagName(s)[0];
      if (d.getElementById(id)) return;
      js = d.createElement(s); js.id = id;
      js.src = '//connect.facebook.net/en_US/all.js#xfbml=1';
      fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));</script>

    <div class='body-wrap'>
        <div id='nav-top'>
            <nav class='container'>
                <div class='mobile-menu'>
                    <a href='javascript:;' class='dl-trigger' data-toggle='collapse' data-target='.nav-collapse'>
                        <i class='fa fa-bars'></i>
                    </a>
                </div>
                <div class='tablet-menu dropdown-wrap'>
                    <a href='#'><i class='fa fa-bars'></i></a>
                    <div class='fp-dropdown-menu'>
                        <a href='/nfl/'>NFL</a>
                        <a href='/mlb/'>MLB</a>
                        <a href='/nba/'>NBA</a>
                        <a href='/nhl/'>NHL</a>
                        <a href='http://draftwizard.fantasypros.com/?sport=nfl'>Draft Wizard <sup>&#174;</sup></a>
                        <a href='/nfl/myplaybook/'>My Playbook</a>
                        <a href='/nfl/players/'>Search</a>
                        
                                                    <a href='https://secure.fantasypros.com/accounts/login/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Log in</a>
                            <a href='https://secure.fantasypros.com/accounts/register/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Register</a>
                                            </div>
                </div>
                <div class='brand'>
                    <a href='/'><img src='//images.fantasypros.com/images/logos/300x60_r.png' alt='FantasyPros.com'></a>
                </div>

                <div class='top-link sport-link mega-dropdown-wrap active-menu '><a href='/nfl/'>NFL</a><i class='caret'></i><ul class='mega-dropdown fp-dropdown-menu'><li><ul><li><a href='#'>Main Links</a></li><li><a href='/nfl'>Home</a></li><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Consensus Rankings</a></li><li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Mock Drafts</a></li><li><a href='/nfl/adp/overall.php'>ADP Consensus</a></li><li><a href='/nfl/player-news.php'>Player News</a></li><li><a href='/nfl/articles/'>Articles</a></li><li><a href='/nfl/projections/qb.php?week=draft'>Projections</a></li><li><a href='/football-podcast/'>Podcast</a></li><li><a href='/fantasy-mobile-apps/'>Apps</a></li><li><a href='/nfl/myplaybook/'>My Playbook</a></li></ul></li><li><ul><li><a href='#'>Draft Tools</a></li><li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft Wizard</a></li><li><a href='http://draftwizard.fantasypros.com/simulator/?partner=fpros&sport=nfl'>Draft Simulator</a></li><li><a href='http://draftwizard.fantasypros.com/assistant/?partner=fpros&sport=nfl'>Draft Assistant</a></li><li><a href='http://draftwizard.fantasypros.com/editor/?partner=fpros&sport=nfl'>Cheat Sheet Creator</a></li><li><a href='http://draftwizard.fantasypros.com/analyzer/?partner=fpros&sport=nfl'>Draft Analyzer</a></li><li><a href='/nfl/auction-values/calculator.php'>Auction Calculator</a></li><li><a href='http://draftwizard.fantasypros.com/simulator/?auction=Y&sport=nfl'>Auction Simulator</a></li><li><a href='/nfl/draft/'>Who Should I Draft?</a></li><li><a href='/nfl/draft-order-generator.php'>Draft Order Generator</a></li></ul></li><li><ul><li><a href='#'>Draft Research</a></li><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Expert Rankings</a></li><li><a href='/nfl/adp/overall.php'>ADP Consensus</a></li><li><a href='/nfl/projections/qb.php?week=draft'>Projections</a></li><li><a href='/nfl/stats/leaders.php'>Stat Leaders</a></li><li><a href='/nfl/strength-of-schedule.php'>Strength of Schedule</a></li><li><a href='/nfl/matchups/qb.php'>Matchup Calendar</a></li><li><a href='/nfl/depth-charts.php'>Depth Charts</a></li><li><a href='/nfl/bye-week-cheatsheet.php'>Bye Week Cheat Sheet</a></li><li><a href='/fantasy-football-draft-kit/'>2016 Draft Kit</a></li></ul></li><li><ul><li><a href='#'>In-Season Tools</a></li><li><a href='/nfl/myplaybook/'>My Playbook</a></li><li><a href='/nfl/start/'>Who Should I Start?</a></li><li><a href='/football-start-sit-assistant/'>Start/Sit Assistant</a></li><li><a href='/nfl/myplaybook/waiver-wire-assistant.php'>Waiver Assistant</a></li><li><a href='/nfl/myplaybook/trade-assistant.php'>Trade Assistant</a></li><li><a href='/nfl/myplaybook/trade-analyzer.php'>Trade Analyzer</a></li><li><a href='/nfl/myplaybook/research-assistant-setup.php'>Research Assistant</a></li><li><a href='/football-multi-league-assistant/'>Multi-League Assistant</a></li><li><a href='/nfl/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li></ul></li><li><ul><li><a href='#'>In-Season Research</a></li><li><a href='/nfl/rankings/qb.php'>Weekly Rankings</a></li><li><a href='/nfl/rankings/qb.php'>ROS Rankings</a></li><li><a href='/nfl/projections/qb.php'>Projections</a></li><li><a href='/nfl/stats/leaders.php'>Stat Leaders</a></li><li><a href='/nfl/accuracy/'>Expert Accuracy</a></li><li><a href='/nfl/strength-of-schedule.php'>Strength of Schedule</a></li><li><a href='/nfl/matchups/qb.php'>Matchup Calendar</a></li><li><a href='/nfl/depth-charts.php'>Depth Charts</a></li><li><a href='/nfl/reports/targets/'>Target Leaders</a></li></ul></li></div>
<div class='top-link sport-link mega-dropdown-wrap '><a href='/mlb/'>MLB</a><i class='caret'></i><ul class='mega-dropdown fp-dropdown-menu'><li><ul><li><a href='#'>Main Links</a></li><li><a href='/mlb'>Home</a></li><li><a href='/mlb/myplaybook/'>My Playbook</a></li><li><a href='/mlb/projections/ros-hitters.php'>Projections</a></li><li><a href='/mlb/rankings/ros-overall.php'>Consensus Rankings</a></li><li><a href='/mlb/stats/hitters.php'>Statistics</a></li><li><a href='/mlb/player-news.php'>Player News</a></li><li><a href='/mlb/articles/'>Articles</a></li><li><a href='/mlb/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li><li><a href='/baseball-podcast/'>Podcast</a></li><li><a href='/fantasy-mobile-apps/'>Apps</a></li></ul></li><li><ul><li><a href='#'>In-Season Tools</a></li><li><a href='/mlb/myplaybook/'>My Playbook</a></li><li><a href='/baseball-waiver-wire-assistant/'>Waiver Assistant</a></li><li><a href='/mlb/myplaybook/lineup-assistant.php'>Lineup Assistant</a></li><li><a href='/baseball-trade-analyzer/'>Trade Analyzer</a></li><li><a href='/baseball-trade-finder/'>Trade Finder</a></li><li><a href='/mlb/myplaybook/research-assistant-setup.php'>Research Assistant</a></li><li><a href='/mlb/myplaybook/league-analysis.php?league=135&team=2'>League Analyzer</a></li><li><a href='/mlb/start/'>Who Should I Start?</a></li><li><a href='/mlb/trade/'>Should I Trade...?</a></li></ul></li><li><ul><li><a href='#'>In-Season Research</a></li><li><a href='/mlb/rankings/ros-overall.php'>Expert Rankings</a></li><li><a href='/mlb/projections/ros-hitters.php'>Projections</a></li><li><a href='/mlb/stats/hitters.php'>Player Rater</a></li><li><a href='/mlb/lineups/'>Today's Lineups</a></li><li><a href='/mlb/probable-pitchers.php'>Pitcher Planner</a></li><li><a href='/mlb/two-start-pitchers.php'>Two Start Pitchers</a></li><li><a href='/mlb/streaming-pitchers.php'>Streamers</a></li><li><a href='/mlb/closer-depth-charts.php'>Closer Report</a></li><li><a href='/mlb/most-added-dropped'>Most Added/Dropped</a></li></ul></li><li><ul><li><a href='#'>Daily Fantasy</a></li><li><a href='/mlb/daily-fantasy-lineup-optimizer.php'>Lineup Optimizer</a></li><li><a href='/mlb/fanduel-cheatsheet.php'>Cheat Sheets</a></li><li><a href='/mlb/fanduel-undervalued-plays.php'>Value Plays</a></li><li><a href='/mlb/daily-fantasy/roi-analyzer.php'>ROI Analyzer</a></li><li><a href='/mlb/fanduel-salary-changes.php'>Salary Changes</a></li><li><a href='/mlb/articles/daily-fantasy.php'>Articles</a></li></ul></li><li><ul><li><a href='#'>Draft Tools</a></li><li><a href='https://draftwizard.fantasypros.com/?sport=mlb&partner=fpros'>Draft Wizard</a></li><li><a href='https://draftwizard.fantasypros.com/simulator/?sport=mlb&partner=fpros'>Draft Simulator</a></li><li><a href='https://draftwizard.fantasypros.com/assistant/?sport=mlb&partner=fpros'>Draft Assistant</a></li><li><a href='https://draftwizard.fantasypros.com/editor/?sport=mlb&partner=fpros'>Cheat Sheet Creator</a></li><li><a href='https://draftwizard.fantasypros.com/analyzer/?sport=mlb&partner=fpros'>Draft Analyzer</a></li><li><a href='/mlb/auction-values/calculator.php'>Auction Calculator</a></li><li><a href='/mlb/draftwizard/premium-features.php?#auction-simulator'>Auction Simulator</a></li><li><a href='/mlb/draft/'>Who Should I Draft?</a></li><li><a href='/mlb/draft-order-generator.php'>Draft Order Generator</a></li></ul></li></div>
<div class='top-link sport-link mega-dropdown-wrap '><a href='/nba/'>NBA</a><i class='caret'></i><ul class='mega-dropdown fp-dropdown-menu'><li><ul><li><a href='#'>Main Links</a></li><li><a href='/nba'>Home</a></li><li><a href='/nba/rankings/ros-overall.php'>Consensus Rankings</a></li><li><a href='http://draftwizard.fantasypros.com/?sport=nba&partner=fpros'>Mock Drafts</a></li><li><a href='/nba/adp/overall.php'>ADP Consensus</a></li><li><a href='/nba/player-news.php'>Player News</a></li><li><a href='/nba/articles/'>Articles</a></li><li><a href='/nba/projections/ros-overall.php'>Projections</a></li><li><a href='/nba/stats/leaders.php'>Statistics</a></li><li><a href='/fantasy-mobile-apps/'>Apps</a></li><li><a href='/nba/myplaybook/'>My Playbook</a></li></ul></li><li><ul><li><a href='#'>Draft Tools</a></li><li><a href='https://draftwizard.fantasypros.com/?sport=nba&partner=fpros'>Draft Wizard</a></li><li><a href='https://draftwizard.fantasypros.com/simulator/?sport=nba&partner=fpros'>Draft Simulator</a></li><li><a href='https://draftwizard.fantasypros.com/assistant/?sport=nba&partner=fpros'>Draft Assistant</a></li><li><a href='https://draftwizard.fantasypros.com/editor/?sport=nba&partner=fpros'>Cheat Sheet Creator</a></li><li><a href='https://draftwizard.fantasypros.com/analyzer/?sport=nba&partner=fpros'>Draft Analyzer</a></li><li><a href='/nba/draft/'>Who Should I Draft?</a></li></ul></li><li><ul><li><a href='#'>Draft Research</a></li><li><a href='/nba/rankings/overall.php'>Expert Rankings</a></li><li><a href='/nba/adp/overall.php'>ADP Consensus</a></li><li><a href='/nba/projections/overall.php'>Projections</a></li><li><a href='/nba/stats/overall.php'>Stat Leaders</a></li><li><a href='/nba/schedules/grid.php'>Matchup Calendar</a></li></ul></li><li><ul><li><a href='#'>In-Season Tools</a></li><li><a href='/nba/myplaybook/'>My Playbook</a></li><li><a href='/nba/myplaybook/research-assistant-setup.php'>Research Assistant</a></li><li><a href='/nba/myplaybook/#analysis'>League Analyzer</a></li><li><a href='/nba/start/'>Who Should I Start?</a></li><li><a href='/nba/trade/'>Should I Trade...?</a></li></ul></li><li><ul><li><a href='#'>In-Season Research</a></li><li><a href='/nba/rankings/ros-overall.php'>Expert Rankings</a></li><li><a href='/nba/projections/overall.php'>Projections</a></li><li><a href='/nba/player-rater.php'>Player Rater</a></li><li><a href='/nba/stats/overall.php'>Stat Leaders</a></li><li><a href='/nba/stats-leaders.php'>Category Leaders</a></li><li><a href='/nba/schedules/'>Schedule</a></li><li><a href='/nba/offense-vs-defense.php'>Matchup Ratings</a></li><li><a href='/nba/defense-vs-position.php'>Defense vs. Position</a></li></ul></li></div>
<div class='top-link sport-link dropdown-wrap '><a href='/nhl/'>NHL</a><i class='caret'></i><ul class='fp-dropdown-menu'><li><ul><li><a href='/nhl/'>Home</a></li><li><a href='/nhl/rankings/ros-overall.php'>Consensus Rankings</a></li><li><a href='/nhl/player-news.php'>Player News</a></li><li><a href='/nhl/articles/'>Articles</a></li></ul></li></div>

                <div class='pull-right nav-end'>
                    <div class='top-link dropdown-wrap product-link'>
                        <a href='http://draftwizard.fantasypros.com/?sport=nfl'>Draft Wizard</a><i class='caret'></i>
                        <ul class='fp-dropdown-menu'>
                            <li>
                                <ul>
                                    <li><a href='http://draftwizard.fantasypros.com/?sport=NFL'>NFL Draft Wizard</a></li>
                                    <li><a href='http://draftwizard.fantasypros.com/?sport=NBA'>NBA Draft Wizard</a></li>
                                    <li><a href='http://draftwizard.fantasypros.com/?sport=MLB'>MLB Draft Wizard</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <div class='top-link dropdown-wrap product-link '>
                        <a href='/nfl/myplaybook/'>My Playbook</a><i class='caret'></i>
                        <ul class='fp-dropdown-menu'>
                            <li>
                                <ul>
                                    <li><a href='/nfl/myplaybook/'>NFL My Playbook</a></li>
                                    <li><a href='/nba/myplaybook/'>NBA My Playbook</a></li>
                                    <li><a href='/mlb/myplaybook/'>MLB My Playbook</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <div class='top-link top-search'>
                        <a href='/nfl/players/'><i class='fa fa-search'></i></a>
                    </div>
                    <div class='top-link user-menu dropdown-wrap'>
                        <div class='user-menu-label'>
                            <div class='pull-left username'><span>Log in / Register</span></div> <i class='fa fa-angle-down pull-left'></i>
                        </div><i class='caret'></i>
                        <div class='user-dropdown fp-dropdown-menu'>
                                                            <a href='https://secure.fantasypros.com/accounts/login/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Log in</a>
                                <a href='https://secure.fantasypros.com/accounts/register/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Register</a>
                                                    </div>
                    </div>
                </div>
            </nav>
        </div>
        <div class='mobile-menu mobile-menu-wrap'>
            <div id='dl-menu' class='dl-menuwrapper'><ul class='dl-menu'><li><a href='#'>Sports <i class='fa fa-chevron-right pull-right'></i></a>
        <ul class='dl-submenu'>
          <li><a href='/nfl/'>NFL Home</a></li>
          <li><a href='/mlb/'>MLB Home</a></li>
          <li><a href='/nba/'>NBA Home</a></li>
          <li><a href='/nhl/'>NHL Home</a></li>
        </ul>
    </li><li><a href='#'>NFL Rankings <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='#'>Draft Rankings <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Standard</a></li><li><a href='/nfl/rankings/ppr-cheatsheets.php'>PPR</a></li><li><a href='/nfl/rankings/half-point-ppr-cheatsheets.php'>Half-PPR</a></li><li><a href='/nfl/adp/overall.php'>ADP</a></li></ul></li><li><a href='#'>Rest of Season Rankings <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='/nfl/rankings/ros-qb.php'>Standard</a></li><li><a href='/nfl/rankings/ros-qb.php'>PPR</a></li><li><a href='/nfl/rankings/ros-qb.php'>Half-PPR</a></li></ul></li><li><a href='#'>Dynasty Rankings <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='/nfl/rankings/dynasty-overall.php'>PPR</a></li></ul></li></ul></li><li><a href='#'>Draft Tools <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft Simulator</a></li><li><a href='http://draftwizard.fantasypros.com/assistant/?partner=fpros&sport=nfl'>Draft Assistant</a></li><li><a href='http://draftwizard.fantasypros.com/editor/?partner=fpros&sport=nfl'>Cheat Sheet Creator</a></li><li><a href='http://draftwizard.fantasypros.com/simulator/?auction=Y&sport=nfl'>Auction Simulator</a></li><li><a href='/nfl/draft/'>Who Should I Draft?</a></li><li><a href='/nfl/auction-values/calculator.php'>Auction Calculator</a></li></ul></li><li><a href='#'>Draft Research <i class='fa fa-chevron-right pull-right'></i></a><ul class='dl-submenu'><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Expert Rankings</a></li><li><a href='/nfl/adp/overall.php'>ADP Consensus</a></li><li><a href='/nfl/projections/qb.php?week=draft'>Projections</a></li><li><a href='/nfl/bye-week-cheatsheet.php'>Bye Week Cheat Sheet</a></li><li><a href='/nfl/strength-of-schedule.php'>Strength of Schedule</a></li><li><a href='/fantasy-football-draft-kit/'>2016 Draft Kit</a></li></ul></li><li><a href='#'>My Playbook <i class='fa fa-chevron-right pull-right'></i></a>
        <ul class='dl-submenu'>
          <li><a href='/nfl/myplaybook/'>NFL My Playbook</a></li>
          <li><a href='/mlb/myplaybook/'>MLB My Playbook</a></li>
          <li><a href='/nba/myplaybook/'>NBA My Playbook</a></li>
        </ul>
    </li>
    <li><a href='http://draftwizard.fantasypros.com/?partner=fpros&sport=nfl' target='_blank'>Draft Wizard</a></li><li><a href='https://secure.fantasypros.com/accounts/register/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Register</a></li>
        <li><a href='https://secure.fantasypros.com/accounts/login/?next=http://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Log In</a></li><li><a href='/nfl/players/'>Search</a></li>
    <li><a href='//www.fantasypros.com/fantasy-mobile-apps/'>Apps</a></li></ul></div>        </div>
        
        <div id='nav-sub'>
            <nav class='container'>
                <ul class='nav nfl'><li><a href='/nfl/'>NFL Home</a></li><li class='dropdown-wrap mega-dropdown-wrap'><a href='http://draftwizard.fantasypros.com/home.jsp?sport=nfl'>Tools <i class='fa fa-angle-down'></i></a><ul class='fp-dropdown-menu mega-dropdown'><li><ul><li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft</a></li><li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft Simulator</a></li><li><a href='http://draftwizard.fantasypros.com/assistant/?sport=nfl&partner=fpros'>Live Draft Assistant</a></li><li><a href='http://draftwizard.fantasypros.com/editor/?partner=fpros&sport=nfl'>Cheat Sheet Creator</a></li><li><a href='http://draftwizard.fantasypros.com/simulator/?auction=Y&sport=nfl'>Auction Simulator</a></li><li><a href='/nfl/auction-values/calculator.php'>Auction Calculator</a></li><li><a href='http://draftwizard.fantasypros.com/analyzer/?partner=fpros&sport=nfl'>Draft Analyzer</a></li><li><a href='/nfl/qb-by-committee.php'>QBBC Finder</a></li><li><a href='/nfl/draft/'>Who Should I Draft?</a></li><li><a href='/nfl/draft-order-generator.php'>Draft Order Generator</a></li><li><a href='/fantasy-football-draft-kit/'>2016 Draft Kit</a></li></li></ul><li><ul><li><a href='/nfl/myplaybook/'>In-Season</a></li><li><a href='/nfl/myplaybook/'>My Playbook</a></li><li><a href='/nfl/start/'>Who Should I Start?</a></li><li><a href='/football-start-sit-assistant/'>Start/Sit Assistant</a></li><li><a href='/waiver-wire-assistant.php'>Waiver Assistant</a></li><li><a href='/trade-assistant.php'>Trade Assistant</a></li><li><a href='/trade-analyzer.php'>Trade Analyzer</a></li><li><a href='/nfl/myplaybook/research-assistant-setup.php'>Research Assitant</a></li><li><a href='/football-multi-league-assistant/'>Multi-League Assistant</a></li><li><a href='/nfl/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li></li></ul></ul></li><li class='dropdown-wrap active-menu mega-dropdown-wrap'><a href='/nfl/rankings/consensus-cheatsheets.php'>2016 Rankings <i class='fa fa-angle-down'></i></a><ul class='fp-dropdown-menu mega-dropdown'><li><ul><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Draft</a></li><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Expert Consensus Rankings</a></li><li><a href='/nfl/rankings/consensus-cheatsheets.php'>Standard Rankings</a></li><li><a href='/nfl/rankings/ppr-cheatsheets.php'>PPR Rankings</a></li><li><a href='/nfl/rankings/half-point-ppr-cheatsheets.php'>Half PPR Rankings</a></li><li><a href='/nfl/adp/overall.php'>Average Draft Position</a></li></li></ul><li><ul><li><a href='/nfl/rankings/dynasty-overall.php'>Dynasty</a></li><li><a href='/nfl/rankings/dynasty-overall.php'>Expert Consensus Rankings</a></li><li><a href='/nfl/rankings/rookies.php'>Rookie Rankings</a></li><li><a href='/nfl/rankings/dynasty-idp.php'>IDP Rankings</a></li></li></ul><li><ul><li><a href='/nfl/rankings/qb.php'>Week 1</a></li><li><a href='/nfl/rankings/qb.php'>Expert Consensus Rankings</a></li><li><a href='/nfl/rankings/rb.php'>Standard Rankings</a></li><li><a href='/nfl/rankings/ppr-rb.php'>PPR Rankings</a></li><li><a href='/nfl/rankings/half-point-ppr-rb.php'>Half PPR Rankings</a></li></li></ul></ul></li><li class='dropdown-wrap mega-dropdown-wrap'><a href='/nfl/projections/qb.php?week=draft'>Research <i class='fa fa-angle-down'></i></a><ul class='fp-dropdown-menu mega-dropdown'><li><ul><li><a href='/nfl/projections/qb.php?week=draft'>Projections</a></li><li><a href='/nfl/projections/qb.php?week=draft'>Season Projections</a></li><li><a href='/nfl/projections/qb.php'>Weekly Projections</a></li><li><a href='/nfl/projections/leaders.php'>Projected Leaders</a></li></li></ul><li><ul><li><a href='/nfl/leaders-trends/'>Leaders & Trends</a></li><li><a href='/nfl/reports/leaders/'>2015 Fantasy Leaders</a></li><li><a href='/nfl/stats/leaders.php'>2015 Stats Leaders</a></li><li><a href='/nfl/reports/targets/'>2015 Targets Leaders</a></li><li><a href='/nfl/depth-charts.php'>Fantasy Depth Charts</a></li><li><a href='/nfl/running-back-handcuffs.php'>RB Handcuffs</a></li><li><a href='/nfl/points-allowed.php'>Fantasy Points Allowed</a></li></li></ul><li><ul><li><a href='/nfl/schedule.php'>Schedules</a></li><li><a href='/nfl/schedule.php'>2016 NFL Schedule</a></li><li><a href='/nfl/strength-of-schedule.php'>Strength of Schedule</a></li><li><a href='/nfl/matchups/qb.php'>Matchup Calendar</a></li><li><a href='/nfl/bye-week-cheatsheet.php'>Bye Week Cheat Sheet</a></li></li></ul><li><ul><li><a href='/nfl/expert-reports/'>Experts</a></li><li><a href='/nfl/accuracy/leaderboard.php'>Draft Accuracy</a></li><li><a href='/nfl/accuracy/'>In-Season Accuracy</a></li><li><a href='/fantasy-football-videos/'>Videos</a></li><li><a href='/nfl/sleepers.php'>Consensus Sleepers</a></li><li><a href='/nfl/busts.php'>Consensus Busts</a></li><li><a href='/nfl/rankings/compare-experts.php'>Dissenting Opinions</a></li><li><a href='/experts/'>Expert Directory</a></li></li></ul></ul></li><li class='dropdown-wrap mega-dropdown-wrap'><a href='/nfl/player-news.php'>News <i class='fa fa-angle-down'></i></a><ul class='fp-dropdown-menu mega-dropdown'><li><ul><li><a href='/nfl/player-news.php'>Player Updates</a></li><li><a href='/nfl/player-news.php'>All News</a></li><li><a href='/nfl/breaking-news.php'>Breaking</a></li><li><a href='/nfl/rumors.php'>Rumors</a></li><li><a href='/nfl/draft-coverage.php'>NFL Draft</a></li><li><a href='/nfl/injury-news.php'>Injuries</a></li><li><a href='/nfl/transactions.php'>Transactions</a></li></li></ul><li><ul><li><a href='/nfl/articles/'>Featured</a></li><li><a href='/content/nfl-draft/'>2016 NFL Draft</a></li><li><a href='/nfl/articles/dynasty.php'>Dynasty</a></li><li><a href='/nfl/articles/player-profiles.php'>Player Profiles</a></li><li><a href='/nfl/articles/injuries.php'>Injuries</a></li><li><a href='/nfl/articles/prospects.php'>Rookies</a></li><li><a href='/nfl/advice/'>Partner Articles</a></li><li><a href='/nfl/podcasts/'>Podcasts</a></li><li><a href='/fantasy-football-videos/'>Videos</a></li></li></ul></ul></li><li class='dropdown-wrap'><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Mock Drafts</a></li><li class='dropdown-wrap mega-dropdown-wrap'><a href='/nfl/daily-fantasy.php'>Daily Fantasy <i class='fa fa-angle-down'></i></a><ul class='fp-dropdown-menu mega-dropdown'><li><ul><li><a href='/nfl/daily-fantasy.php'>DFS Tools</a></li><li><a href='/nfl/daily-fantasy.php'>DFS Home</a></li><li><a href='/nfl/daily-fantasy-lineup-optimizer.php'>Lineup Optimizer</a></li><li><a href='/nfl/fanduel-undervalued-plays.php'>Value Plays</a></li><li><a href='/nfl/fanduel-cheatsheet.php'>Cheat Sheets</a></li><li><a href='/nfl/daily-fantasy/roi-analyzer.php'>ROI Analyzer</a></li><li><a href='/nfl/fanduel-salary-changes.php'>Salary Changes</a></li></li></ul><li><ul><li><a href='/nfl/daily-fantasy.php'>DFS Advice</a></li><li><a href='/nfl/daily-fantasy.php'>DFS Home Page</a></li><li><a href='/content/daily/dfs-glossary/'>Strategy Guide</a></li><li><a href='/nfl/daily-fantasy/fanduel.php'>FanDuel</a></li><li><a href='/nfl/daily-fantasy/draftkings.php'>DraftKings</a></li><li><a href='/nfl/daily-fantasy/fantasyaces.php'>FantasyAces</a></li><li><a href='/nfl/daily-fantasy/draftpot.php'>Draftpot</a></li><li><a href='/nfl/daily-fantasy/yahoo.php'>Yahoo Daily Fantasy</a></li></li></ul><li><ul><li><a href='/nfl/daily-fantasy.php'>DFS Games</a></li><li><a href='http://partners.fanduel.com/processing/clickthrgh.asp?btag=a_770b_867'>FanDuel</a></li><li><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000'>Yahoo</a></li></li></ul></ul></li><li class='dropdown-wrap'><a href='/football-podcast/'>Podcast</a></li><li class='dropdown-wrap'><a href='/fantasy-mobile-apps/'>Apps</a></li></ul>            </nav>
        </div>
                        <div class='ad-320'>
            <!-- fantasypros_nfl_mobile_content_320x50 -->
<div id='div-gpt-ad-1404326777280-0' style='width:320px; height:50px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1404326777280-0'); });
</script>
</div>
        </div>

        
            <div class='leaderboard-wrap'>
                <div id='leaderboard'>
                    <!-- fantasypros_nfl_content_leaderboard_728x90_1 -->
<div id='div-gpt-ad-1358392502308-0' style='width:728px; height:90px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1358392502308-0'); });
</script>
</div>
                </div>
            </div>
        
<div class='container'>
    <div class='main-content-wrap'>

        <div class='main-content'>
            <div class='inner'>
                <div class='clearfix'>
                    <div class='primary-heading-subheading nine columns'>
                        <h1>Fantasy Football Draft Rankings (2016)</h1>
                        <h5>Consensus of 87 Experts (107 available) - Updated 8/31</h5>
                    </div>
                    
                                        <div class='three columns' style='margin-top:4px; min-width:140px; text-align:right;'>
                        <a href='#edit-experts' role='button' data-toggle='modal' class='btn btn-primary' style='margin-right:0px;'>Pick Experts</a>
                    </div>
                                    </div>

                <div class='pills-wrap feature-bg feature-stretch'>
                    <ul class='pills desktop-pills' data-mobile-label='Positions'>
                        <li class='active'><a href='/nfl/rankings/consensus-cheatsheets.php' class='mpb-link'>Overall</a></li><li><a href='/nfl/rankings/qb-cheatsheets.php' class='mpb-link'>QB</a></li><li><a href='/nfl/rankings/rb-cheatsheets.php' class='mpb-link'>RB</a></li><li><a href='/nfl/rankings/wr-cheatsheets.php' class='mpb-link'>WR</a></li><li><a href='/nfl/rankings/te-cheatsheets.php' class='mpb-link'>TE</a></li><li><a href='/nfl/rankings/k-cheatsheets.php' class='mpb-link'>K</a></li><li><a href='/nfl/rankings/dst-cheatsheets.php' class='mpb-link'>DST</a></li><li><a href='/nfl/rankings/idp-cheatsheets.php' class='mpb-link'>IDP</a></li><li><a href='/nfl/rankings/dl-cheatsheets.php' class='mpb-link'>DL</a></li><li><a href='/nfl/rankings/lb-cheatsheets.php' class='mpb-link'>LB</a></li><li><a href='/nfl/rankings/db-cheatsheets.php' class='mpb-link'>DB</a></li>                    </ul>
                </div>

                <div class='promo feature-bg feature-stretch below-pills'><p>
                                            <a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=ecr_strip'><i class='fa fa-star'></i> Practice with our free Mock Draft Simulator</a>
                                    </p></div>
                
                                <div class='clearfix' style='margin-top:10px;'>
                                    <div class='pull-left report-buttons' style='margin-bottom:5px;'>
                                            <div class='select-wrap'>
                            <select class='select-links' style='width:135px; margin-right:5px;'>
                                <option value='/nfl/rankings/consensus-cheatsheets.php' selected='selected'>Standard Scoring</option>
<option value='/nfl/rankings/ppr-cheatsheets.php'>PPR Scoring</option>
<option value='/nfl/rankings/half-point-ppr-cheatsheets.php'>Half PPR Scoring</option>
                            </select>
                        </div>
                                                                <a class='btn btn-secondary' href='http://draftwizard.fantasypros.com/editor/?sport=nfl&partner=fpros'>Edit Cheat Sheet</a>
                                        </div>
                    <div class='pull-right' style='margin-top:10px;'>
                        <a href='#export' role='button' data-toggle='modal' rel='nofollow'>Download</a>
                         | <a href='/nfl/cheatsheets/top-players.php' rel='nofollow'>Print</a>                    </div>
                </div>
                
                
                <div class='mobile-table'>
                      <table cellpadding='0' cellspacing='0' border='0' id='data' class='table table-bordered table-striped player-table table-hover pad-below'>
                          <thead>
                              <tr>
                                  <th style='width:50px;' class='rank-row'>Rank</td>

                                  <th style='width:220px;' class='player-label'>Player <small>(Team)</small></th>
<th style='width:50px;'>Pos</th><th style='width:50px;'>Bye</th>                                  <th style='width:50px;'>Best</th>
                                  <th style='width:50px;'>Worst</th>
                                  <th style='width:50px;'>Avg</th>
                                  <th style='width:50px;'>Std Dev</th>
                                  <th style='width:50px;'>ADP</th>
<th style='width:50px;'>vs. ADP</th>
                              </tr>
                          </thead>
                          <tbody>
                              <tr class='tier-row static'><td>Tier 1</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9808'><td>1</td>
<td class='player-label'><a href='/nfl/players/antonio-brown.php?type=overall&week=draft'>Antonio Brown</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-9808' fp-player-name='Antonio Brown'></a></td>
<td>WR1</td>
<td>8</td>
<td>1</td>
<td>4</td>
<td>1.3</td>
<td>0.7</td>
<td>1.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-12127'><td>2</td>
<td class='player-label'><a href='/nfl/players/odell-beckham.php?type=overall&week=draft'>Odell Beckham Jr.</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-12127' fp-player-name='Odell Beckham Jr.'></a></td>
<td>WR2</td>
<td>8</td>
<td>1</td>
<td>9</td>
<td>3.0</td>
<td>1.5</td>
<td>2.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9867'><td>3</td>
<td class='player-label'><a href='/nfl/players/julio-jones.php?type=overall&week=draft'>Julio Jones</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-9867' fp-player-name='Julio Jones'></a></td>
<td>WR3</td>
<td>11</td>
<td>2</td>
<td>6</td>
<td>3.3</td>
<td>1.1</td>
<td>4.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-13912'><td>4</td>
<td class='player-label'><a href='/nfl/players/todd-gurley.php?type=overall&week=draft'>Todd Gurley</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-13912' fp-player-name='Todd Gurley'></a></td>
<td>RB1</td>
<td>8</td>
<td>1</td>
<td>13</td>
<td>4.9</td>
<td>2.9</td>
<td>3.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-13948'><td>5</td>
<td class='player-label'><a href='/nfl/players/david-johnson-rb.php?type=overall&week=draft'>David Johnson</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-13948' fp-player-name='David Johnson'></a></td>
<td>RB2</td>
<td>9</td>
<td>1</td>
<td>36</td>
<td>5.8</td>
<td>4.5</td>
<td>5.0</td>
<td>0.0</td>
</tr>
<tr class='tier-row static'><td>Tier 2</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9006'><td>6</td>
<td class='player-label'><a href='/nfl/players/adrian-peterson-min.php?type=overall&week=draft'>Adrian Peterson</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-9006' fp-player-name='Adrian Peterson'></a></td>
<td>RB3</td>
<td>6</td>
<td>1</td>
<td>25</td>
<td>8.0</td>
<td>3.8</td>
<td>6.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9857'><td>7</td>
<td class='player-label'><a href='/nfl/players/aj-green.php?type=overall&week=draft'>A.J. Green</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-9857' fp-player-name='A.J. Green'></a></td>
<td>WR4</td>
<td>9</td>
<td>2</td>
<td>16</td>
<td>8.1</td>
<td>2.7</td>
<td>10.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-11606'><td>8</td>
<td class='player-label'><a href='/nfl/players/deandre-hopkins.php?type=overall&week=draft'>DeAndre Hopkins</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-11606' fp-player-name='DeAndre Hopkins'></a></td>
<td>WR5</td>
<td>9</td>
<td>3</td>
<td>19</td>
<td>9.0</td>
<td>3.1</td>
<td>7.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-15498'><td>9</td>
<td class='player-label'><a href='/nfl/players/ezekiel-elliott.php?type=overall&week=draft'>Ezekiel Elliott</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-15498' fp-player-name='Ezekiel Elliott'></a></td>
<td>RB4</td>
<td>7</td>
<td>1</td>
<td>28</td>
<td>9.1</td>
<td>4.4</td>
<td>8.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-11185'><td>10</td>
<td class='player-label'><a href='/nfl/players/lamar-miller.php?type=overall&week=draft'>Lamar Miller</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-11185' fp-player-name='Lamar Miller'></a></td>
<td>RB5</td>
<td>9</td>
<td>4</td>
<td>27</td>
<td>10.9</td>
<td>4.1</td>
<td>12.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-9721'><td>11</td>
<td class='player-label'><a href='/nfl/players/rob-gronkowski.php?type=overall&week=draft'>Rob Gronkowski</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9721' fp-player-name='Rob Gronkowski'></a></td>
<td>TE1</td>
<td>9</td>
<td>5</td>
<td>26</td>
<td>11.1</td>
<td>4.5</td>
<td>9.0</td>
<td>&#45;2.0</td>
</tr>
<tr class='mpb-player-12126'><td>12</td>
<td class='player-label'><a href='/nfl/players/allen-robinson.php?type=overall&week=draft'>Allen Robinson</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-12126' fp-player-name='Allen Robinson'></a></td>
<td>WR6</td>
<td>5</td>
<td>4</td>
<td>23</td>
<td>12.2</td>
<td>3.6</td>
<td>15.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='tier-row static'><td>Tier 3</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9681'><td>13</td>
<td class='player-label'><a href='/nfl/players/dez-bryant.php?type=overall&week=draft'>Dez Bryant</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-9681' fp-player-name='Dez Bryant'></a></td>
<td>WR7</td>
<td>7</td>
<td>7</td>
<td>33</td>
<td>14.8</td>
<td>6.2</td>
<td>11.0</td>
<td>&#45;2.0</td>
</tr>
<tr class='mpb-player-11645'><td>14</td>
<td class='player-label'><a href='/nfl/players/leveon-bell.php?type=overall&week=draft'>Le'Veon Bell</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-11645' fp-player-name='Le'Veon Bell'></a></td>
<td>RB6</td>
<td>8</td>
<td>6</td>
<td>45</td>
<td>17.0</td>
<td>6.1</td>
<td>13.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-9258'><td>15</td>
<td class='player-label'><a href='/nfl/players/jamaal-charles.php?type=overall&week=draft'>Jamaal Charles</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-9258' fp-player-name='Jamaal Charles'></a></td>
<td>RB7</td>
<td>5</td>
<td>5</td>
<td>38</td>
<td>17.2</td>
<td>6.4</td>
<td>16.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-12119'><td>16</td>
<td class='player-label'><a href='/nfl/players/mike-evans.php?type=overall&week=draft'>Mike Evans</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-12119' fp-player-name='Mike Evans'></a></td>
<td>WR8</td>
<td>6</td>
<td>9</td>
<td>36</td>
<td>19.2</td>
<td>5.5</td>
<td>25.0</td>
<td>&#43;9.0</td>
</tr>
<tr class='mpb-player-9064'><td>17</td>
<td class='player-label'><a href='/nfl/players/brandon-marshall.php?type=overall&week=draft'>Brandon Marshall</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9064' fp-player-name='Brandon Marshall'></a></td>
<td>WR9</td>
<td>11</td>
<td>4</td>
<td>40</td>
<td>19.5</td>
<td>6.7</td>
<td>19.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-9320'><td>18</td>
<td class='player-label'><a href='/nfl/players/jordy-nelson.php?type=overall&week=draft'>Jordy Nelson</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9320' fp-player-name='Jordy Nelson'></a></td>
<td>WR10</td>
<td>4</td>
<td>7</td>
<td>37</td>
<td>21.0</td>
<td>6.2</td>
<td>18.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9872'><td>19</td>
<td class='player-label'><a href='/nfl/players/mark-ingram.php?type=overall&week=draft'>Mark Ingram</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-9872' fp-player-name='Mark Ingram'></a></td>
<td>RB8</td>
<td>5</td>
<td>11</td>
<td>52</td>
<td>21.0</td>
<td>6.4</td>
<td>20.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-11199'><td>20</td>
<td class='player-label'><a href='/nfl/players/alshon-jeffery.php?type=overall&week=draft'>Alshon Jeffery</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-11199' fp-player-name='Alshon Jeffery'></a></td>
<td>WR11</td>
<td>9</td>
<td>11</td>
<td>36</td>
<td>21.4</td>
<td>5.6</td>
<td>23.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-12108'><td>21</td>
<td class='player-label'><a href='/nfl/players/devonta-freeman.php?type=overall&week=draft'>Devonta Freeman</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-12108' fp-player-name='Devonta Freeman'></a></td>
<td>RB9</td>
<td>11</td>
<td>8</td>
<td>103</td>
<td>21.5</td>
<td>13.3</td>
<td>14.0</td>
<td>&#45;7.0</td>
</tr>
<tr class='mpb-player-11616'><td>22</td>
<td class='player-label'><a href='/nfl/players/keenan-allen.php?type=overall&week=draft'>Keenan Allen</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-11616' fp-player-name='Keenan Allen'></a></td>
<td>WR12</td>
<td>11</td>
<td>7</td>
<td>40</td>
<td>22.4</td>
<td>6.3</td>
<td>24.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-9398'><td>23</td>
<td class='player-label'><a href='/nfl/players/lesean-mccoy.php?type=overall&week=draft'>LeSean McCoy</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-9398' fp-player-name='LeSean McCoy'></a></td>
<td>RB10</td>
<td>10</td>
<td>13</td>
<td>38</td>
<td>22.9</td>
<td>5.5</td>
<td>26.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-11186'><td>24</td>
<td class='player-label'><a href='/nfl/players/doug-martin.php?type=overall&week=draft'>Doug Martin</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-11186' fp-player-name='Doug Martin'></a></td>
<td>RB11</td>
<td>6</td>
<td>11</td>
<td>43</td>
<td>23.2</td>
<td>7.5</td>
<td>21.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-11636'><td>25</td>
<td class='player-label'><a href='/nfl/players/eddie-lacy.php?type=overall&week=draft'>Eddie Lacy</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-11636' fp-player-name='Eddie Lacy'></a></td>
<td>RB12</td>
<td>4</td>
<td>13</td>
<td>56</td>
<td>23.2</td>
<td>7.2</td>
<td>22.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='tier-row static'><td>Tier 4</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-12122'><td>26</td>
<td class='player-label'><a href='/nfl/players/brandin-cooks.php?type=overall&week=draft'>Brandin Cooks</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-12122' fp-player-name='Brandin Cooks'></a></td>
<td>WR13</td>
<td>5</td>
<td>13</td>
<td>44</td>
<td>26.3</td>
<td>6.7</td>
<td>29.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-13894'><td>27</td>
<td class='player-label'><a href='/nfl/players/amari-cooper.php?type=overall&week=draft'>Amari Cooper</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-13894' fp-player-name='Amari Cooper'></a></td>
<td>WR14</td>
<td>10</td>
<td>11</td>
<td>52</td>
<td>27.0</td>
<td>6.6</td>
<td>28.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-11206'><td>28</td>
<td class='player-label'><a href='/nfl/players/ty-hilton.php?type=overall&week=draft'>T.Y. Hilton</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-11206' fp-player-name='T.Y. Hilton'></a></td>
<td>WR15</td>
<td>10</td>
<td>13</td>
<td>58</td>
<td>28.8</td>
<td>7.7</td>
<td>34.0</td>
<td>&#43;6.0</td>
</tr>
<tr class='mpb-player-11896'><td>29</td>
<td class='player-label'><a href='/nfl/players/cj-anderson.php?type=overall&week=draft'>C.J. Anderson</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-11896' fp-player-name='C.J. Anderson'></a></td>
<td>RB13</td>
<td>11</td>
<td>14</td>
<td>83</td>
<td>29.3</td>
<td>9.0</td>
<td>30.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-12118'><td>30</td>
<td class='player-label'><a href='/nfl/players/sammy-watkins.php?type=overall&week=draft'>Sammy Watkins</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-12118' fp-player-name='Sammy Watkins'></a></td>
<td>WR16</td>
<td>10</td>
<td>11</td>
<td>55</td>
<td>29.4</td>
<td>7.9</td>
<td>31.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-9691'><td>31</td>
<td class='player-label'><a href='/nfl/players/demaryius-thomas.php?type=overall&week=draft'>Demaryius Thomas</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-9691' fp-player-name='Demaryius Thomas'></a></td>
<td>WR17</td>
<td>11</td>
<td>17</td>
<td>64</td>
<td>33.4</td>
<td>7.7</td>
<td>32.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-9869'><td>32</td>
<td class='player-label'><a href='/nfl/players/cam-newton.php?type=overall&week=draft'>Cam Newton</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9869' fp-player-name='Cam Newton'></a></td>
<td>QB1</td>
<td>7</td>
<td>18</td>
<td>71</td>
<td>34.5</td>
<td>10.2</td>
<td>17.0</td>
<td>&#45;15.0</td>
</tr>
<tr class='mpb-player-9001'><td>33</td>
<td class='player-label'><a href='/nfl/players/aaron-rodgers.php?type=overall&week=draft'>Aaron Rodgers</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9001' fp-player-name='Aaron Rodgers'></a></td>
<td>QB2</td>
<td>4</td>
<td>13</td>
<td>74</td>
<td>35.3</td>
<td>11.2</td>
<td>27.0</td>
<td>&#45;6.0</td>
</tr>
<tr class='mpb-player-12105'><td>34</td>
<td class='player-label'><a href='/nfl/players/carlos-hyde.php?type=overall&week=draft'>Carlos Hyde</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-12105' fp-player-name='Carlos Hyde'></a></td>
<td>RB14</td>
<td>8</td>
<td>19</td>
<td>72</td>
<td>37.4</td>
<td>10.3</td>
<td>35.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-9902'><td>35</td>
<td class='player-label'><a href='/nfl/players/randall-cobb.php?type=overall&week=draft'>Randall Cobb</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9902' fp-player-name='Randall Cobb'></a></td>
<td>WR18</td>
<td>4</td>
<td>21</td>
<td>61</td>
<td>37.5</td>
<td>7.1</td>
<td>43.0</td>
<td>&#43;8.0</td>
</tr>
<tr class='mpb-player-11821'><td>36</td>
<td class='player-label'><a href='/nfl/players/latavius-murray.php?type=overall&week=draft'>Latavius Murray</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-11821' fp-player-name='Latavius Murray'></a></td>
<td>RB15</td>
<td>10</td>
<td>19</td>
<td>92</td>
<td>38.7</td>
<td>11.0</td>
<td>39.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='tier-row static'><td>Tier 5</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9289'><td>37</td>
<td class='player-label'><a href='/nfl/players/jeremy-maclin.php?type=overall&week=draft'>Jeremy Maclin</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-9289' fp-player-name='Jeremy Maclin'></a></td>
<td>WR19</td>
<td>5</td>
<td>24</td>
<td>63</td>
<td>41.5</td>
<td>7.6</td>
<td>49.0</td>
<td>&#43;12.0</td>
</tr>
<tr class='mpb-player-11690'><td>38</td>
<td class='player-label'><a href='/nfl/players/jordan-reed.php?type=overall&week=draft'>Jordan Reed</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-11690' fp-player-name='Jordan Reed'></a></td>
<td>TE2</td>
<td>9</td>
<td>22</td>
<td>77</td>
<td>42.2</td>
<td>8.4</td>
<td>37.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-14403'><td>39</td>
<td class='player-label'><a href='/nfl/players/thomas-rawls.php?type=overall&week=draft'>Thomas Rawls</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-14403' fp-player-name='Thomas Rawls'></a></td>
<td>RB16</td>
<td>5</td>
<td>21</td>
<td>131</td>
<td>42.8</td>
<td>15.5</td>
<td>33.0</td>
<td>&#45;6.0</td>
</tr>
<tr class='mpb-player-9437'><td>40</td>
<td class='player-label'><a href='/nfl/players/matt-forte.php?type=overall&week=draft'>Matt Forte</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9437' fp-player-name='Matt Forte'></a></td>
<td>RB17</td>
<td>11</td>
<td>22</td>
<td>80</td>
<td>43.4</td>
<td>11.0</td>
<td>38.0</td>
<td>&#45;2.0</td>
</tr>
<tr class='mpb-player-11180'><td>41</td>
<td class='player-label'><a href='/nfl/players/russell-wilson.php?type=overall&week=draft'>Russell Wilson</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-11180' fp-player-name='Russell Wilson'></a></td>
<td>QB3</td>
<td>5</td>
<td>20</td>
<td>72</td>
<td>44.2</td>
<td>9.9</td>
<td>36.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-9708'><td>42</td>
<td class='player-label'><a href='/nfl/players/eric-decker.php?type=overall&week=draft'>Eric Decker</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9708' fp-player-name='Eric Decker'></a></td>
<td>WR20</td>
<td>11</td>
<td>27</td>
<td>67</td>
<td>45.6</td>
<td>9.2</td>
<td>51.0</td>
<td>&#43;9.0</td>
</tr>
<tr class='mpb-player-9238'><td>43</td>
<td class='player-label'><a href='/nfl/players/greg-olsen.php?type=overall&week=draft'>Greg Olsen</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9238' fp-player-name='Greg Olsen'></a></td>
<td>TE3</td>
<td>7</td>
<td>30</td>
<td>85</td>
<td>46.5</td>
<td>8.8</td>
<td>41.0</td>
<td>&#45;2.0</td>
</tr>
<tr class='mpb-player-12128'><td>44</td>
<td class='player-label'><a href='/nfl/players/jarvis-landry.php?type=overall&week=draft'>Jarvis Landry</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-12128' fp-player-name='Jarvis Landry'></a></td>
<td>WR21</td>
<td>8</td>
<td>20</td>
<td>74</td>
<td>46.6</td>
<td>11.2</td>
<td>44.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-12102'><td>45</td>
<td class='player-label'><a href='/nfl/players/jeremy-hill.php?type=overall&week=draft'>Jeremy Hill</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-12102' fp-player-name='Jeremy Hill'></a></td>
<td>RB18</td>
<td>9</td>
<td>25</td>
<td>89</td>
<td>46.8</td>
<td>11.4</td>
<td>52.0</td>
<td>&#43;7.0</td>
</tr>
<tr class='mpb-player-11172'><td>46</td>
<td class='player-label'><a href='/nfl/players/andrew-luck.php?type=overall&week=draft'>Andrew Luck</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-11172' fp-player-name='Andrew Luck'></a></td>
<td>QB4</td>
<td>10</td>
<td>14</td>
<td>87</td>
<td>47.8</td>
<td>13.6</td>
<td>42.0</td>
<td>&#45;4.0</td>
</tr>
<tr class='mpb-player-9332'><td>47</td>
<td class='player-label'><a href='/nfl/players/julian-edelman.php?type=overall&week=draft'>Julian Edelman</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9332' fp-player-name='Julian Edelman'></a></td>
<td>WR22</td>
<td>9</td>
<td>25</td>
<td>90</td>
<td>48.5</td>
<td>11.4</td>
<td>40.0</td>
<td>&#45;7.0</td>
</tr>
<tr class='mpb-player-9896'><td>48</td>
<td class='player-label'><a href='/nfl/players/demarco-murray.php?type=overall&week=draft'>DeMarco Murray</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-9896' fp-player-name='DeMarco Murray'></a></td>
<td>RB19</td>
<td>13</td>
<td>25</td>
<td>117</td>
<td>49.3</td>
<td>14.5</td>
<td>47.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-10992'><td>49</td>
<td class='player-label'><a href='/nfl/players/doug-baldwin.php?type=overall&week=draft'>Doug Baldwin</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-10992' fp-player-name='Doug Baldwin'></a></td>
<td>WR23</td>
<td>5</td>
<td>31</td>
<td>73</td>
<td>50.8</td>
<td>9.7</td>
<td>48.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-12125'><td>50</td>
<td class='player-label'><a href='/nfl/players/donte-moncrief.php?type=overall&week=draft'>Donte Moncrief</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-12125' fp-player-name='Donte Moncrief'></a></td>
<td>WR24</td>
<td>10</td>
<td>25</td>
<td>93</td>
<td>51.5</td>
<td>13.3</td>
<td>62.0</td>
<td>&#43;12.0</td>
</tr>
<!-- fantasypros_nfl_mobile_content_320x50_2 -->
                                              <tr class='table-ad'><td colspan='100'><span style='display: none;'>50</span><div id='div-gpt-ad-1404326895972-0' style='width:320px; height:50px;' class='ad-phone'>
                                              <script type='text/javascript'>
                                              googletag.cmd.push(function() { googletag.display('div-gpt-ad-1404326895972-0'); });
                                              </script>
                                              </div></td></tr><tr class='mpb-player-9317'><td>51</td>
<td class='player-label'><a href='/nfl/players/jonathan-stewart.php?type=overall&week=draft'>Jonathan Stewart</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9317' fp-player-name='Jonathan Stewart'></a></td>
<td>RB20</td>
<td>7</td>
<td>18</td>
<td>94</td>
<td>51.9</td>
<td>13.3</td>
<td>46.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-9683'><td>52</td>
<td class='player-label'><a href='/nfl/players/golden-tate.php?type=overall&week=draft'>Golden Tate</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-9683' fp-player-name='Golden Tate'></a></td>
<td>WR25</td>
<td>10</td>
<td>23</td>
<td>108</td>
<td>52.9</td>
<td>14.3</td>
<td>54.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-9200'><td>53</td>
<td class='player-label'><a href='/nfl/players/drew-brees.php?type=overall&week=draft'>Drew Brees</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-9200' fp-player-name='Drew Brees'></a></td>
<td>QB5</td>
<td>5</td>
<td>27</td>
<td>157</td>
<td>54.6</td>
<td>16.1</td>
<td>50.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-11198'><td>54</td>
<td class='player-label'><a href='/nfl/players/michael-floyd.php?type=overall&week=draft'>Michael Floyd</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-11198' fp-player-name='Michael Floyd'></a></td>
<td>WR26</td>
<td>9</td>
<td>28</td>
<td>105</td>
<td>55.4</td>
<td>13.0</td>
<td>56.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-12121'><td>55</td>
<td class='player-label'><a href='/nfl/players/kelvin-benjamin.php?type=overall&week=draft'>Kelvin Benjamin</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-12121' fp-player-name='Kelvin Benjamin'></a></td>
<td>WR27</td>
<td>7</td>
<td>26</td>
<td>94</td>
<td>55.8</td>
<td>14.9</td>
<td>45.0</td>
<td>&#45;10.0</td>
</tr>
<tr class='mpb-player-9687'><td>56</td>
<td class='player-label'><a href='/nfl/players/ryan-mathews.php?type=overall&week=draft'>Ryan Mathews</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-9687' fp-player-name='Ryan Mathews'></a></td>
<td>RB21</td>
<td>4</td>
<td>36</td>
<td>160</td>
<td>56.6</td>
<td>17.6</td>
<td>55.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='tier-row static'><td>Tier 6</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-13946'><td>57</td>
<td class='player-label'><a href='/nfl/players/jeremy-langford.php?type=overall&week=draft'>Jeremy Langford</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-13946' fp-player-name='Jeremy Langford'></a></td>
<td>RB22</td>
<td>9</td>
<td>24</td>
<td>142</td>
<td>59.3</td>
<td>15.1</td>
<td>61.0</td>
<td>&#43;4.0</td>
</tr>
<tr class='mpb-player-9218'><td>58</td>
<td class='player-label'><a href='/nfl/players/frank-gore.php?type=overall&week=draft'>Frank Gore</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-9218' fp-player-name='Frank Gore'></a></td>
<td>RB23</td>
<td>10</td>
<td>33</td>
<td>110</td>
<td>61.6</td>
<td>14.9</td>
<td>72.0</td>
<td>&#43;14.0</td>
</tr>
<tr class='mpb-player-9383'><td>59</td>
<td class='player-label'><a href='/nfl/players/larry-fitzgerald.php?type=overall&week=draft'>Larry Fitzgerald</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-9383' fp-player-name='Larry Fitzgerald'></a></td>
<td>WR28</td>
<td>9</td>
<td>37</td>
<td>84</td>
<td>62.0</td>
<td>9.6</td>
<td>60.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-11594'><td>60</td>
<td class='player-label'><a href='/nfl/players/travis-kelce.php?type=overall&week=draft'>Travis Kelce</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-11594' fp-player-name='Travis Kelce'></a></td>
<td>TE4</td>
<td>5</td>
<td>35</td>
<td>94</td>
<td>62.8</td>
<td>13.9</td>
<td>57.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-12124'><td>61</td>
<td class='player-label'><a href='/nfl/players/jordan-matthews.php?type=overall&week=draft'>Jordan Matthews</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-12124' fp-player-name='Jordan Matthews'></a></td>
<td>WR29</td>
<td>4</td>
<td>27</td>
<td>104</td>
<td>63.7</td>
<td>12.5</td>
<td>68.0</td>
<td>&#43;7.0</td>
</tr>
<tr class='mpb-player-13903'><td>62</td>
<td class='player-label'><a href='/nfl/players/melvin-gordon.php?type=overall&week=draft'>Melvin Gordon</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-13903' fp-player-name='Melvin Gordon'></a></td>
<td>RB24</td>
<td>11</td>
<td>25</td>
<td>130</td>
<td>64.8</td>
<td>17.1</td>
<td>66.0</td>
<td>&#43;4.0</td>
</tr>
<tr class='mpb-player-11644'><td>63</td>
<td class='player-label'><a href='/nfl/players/giovani-bernard.php?type=overall&week=draft'>Giovani Bernard</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-11644' fp-player-name='Giovani Bernard'></a></td>
<td>RB25</td>
<td>9</td>
<td>38</td>
<td>108</td>
<td>65.3</td>
<td>13.0</td>
<td>75.0</td>
<td>&#43;12.0</td>
</tr>
<tr class='mpb-player-9039'><td>64</td>
<td class='player-label'><a href='/nfl/players/ben-roethlisberger.php?type=overall&week=draft'>Ben Roethlisberger</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-9039' fp-player-name='Ben Roethlisberger'></a></td>
<td>QB6</td>
<td>8</td>
<td>39</td>
<td>122</td>
<td>67.9</td>
<td>16.8</td>
<td>53.0</td>
<td>&#45;11.0</td>
</tr>
<tr class='mpb-player-9172'><td>65</td>
<td class='player-label'><a href='/nfl/players/delanie-walker.php?type=overall&week=draft'>Delanie Walker</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-9172' fp-player-name='Delanie Walker'></a></td>
<td>TE5</td>
<td>13</td>
<td>35</td>
<td>103</td>
<td>68.6</td>
<td>12.4</td>
<td>59.0</td>
<td>&#45;6.0</td>
</tr>
<tr class='mpb-player-12231'><td>66</td>
<td class='player-label'><a href='/nfl/players/john-brown.php?type=overall&week=draft'>John Brown</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-12231' fp-player-name='John Brown'></a></td>
<td>WR30</td>
<td>9</td>
<td>31</td>
<td>94</td>
<td>68.9</td>
<td>11.3</td>
<td>73.0</td>
<td>&#43;7.0</td>
</tr>
<tr class='mpb-player-13947'><td>67</td>
<td class='player-label'><a href='/nfl/players/matt-jones-rb.php?type=overall&week=draft'>Matt Jones</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-13947' fp-player-name='Matt Jones'></a></td>
<td>RB26</td>
<td>9</td>
<td>38</td>
<td>148</td>
<td>69.5</td>
<td>19.5</td>
<td>63.0</td>
<td>&#45;4.0</td>
</tr>
<tr class='mpb-player-9707'><td>68</td>
<td class='player-label'><a href='/nfl/players/emmanuel-sanders.php?type=overall&week=draft'>Emmanuel Sanders</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-9707' fp-player-name='Emmanuel Sanders'></a></td>
<td>WR31</td>
<td>11</td>
<td>41</td>
<td>128</td>
<td>69.7</td>
<td>13.2</td>
<td>65.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-9098'><td>69</td>
<td class='player-label'><a href='/nfl/players/carson-palmer.php?type=overall&week=draft'>Carson Palmer</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-9098' fp-player-name='Carson Palmer'></a></td>
<td>QB7</td>
<td>9</td>
<td>40</td>
<td>111</td>
<td>71.3</td>
<td>14.2</td>
<td>58.0</td>
<td>&#45;11.0</td>
</tr>
<tr class='mpb-player-11215'><td>70</td>
<td class='player-label'><a href='/nfl/players/marvin-jones.php?type=overall&week=draft'>Marvin Jones</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-11215' fp-player-name='Marvin Jones'></a></td>
<td>WR32</td>
<td>10</td>
<td>41</td>
<td>107</td>
<td>73.3</td>
<td>15.8</td>
<td>91.0</td>
<td>&#43;21.0</td>
</tr>
<tr class='mpb-player-12996'><td>71</td>
<td class='player-label'><a href='/nfl/players/allen-hurns.php?type=overall&week=draft'>Allen Hurns</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-12996' fp-player-name='Allen Hurns'></a></td>
<td>WR33</td>
<td>5</td>
<td>37</td>
<td>156</td>
<td>75.0</td>
<td>16.3</td>
<td>71.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9030'><td>72</td>
<td class='player-label'><a href='/nfl/players/arian-foster.php?type=overall&week=draft'>Arian Foster</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-9030' fp-player-name='Arian Foster'></a></td>
<td>RB27</td>
<td>8</td>
<td>35</td>
<td>157</td>
<td>76.1</td>
<td>22.8</td>
<td>69.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-13971'><td>73</td>
<td class='player-label'><a href='/nfl/players/tyler-lockett.php?type=overall&week=draft'>Tyler Lockett</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-13971' fp-player-name='Tyler Lockett'></a></td>
<td>WR34</td>
<td>5</td>
<td>25</td>
<td>122</td>
<td>76.4</td>
<td>15.2</td>
<td>83.0</td>
<td>&#43;10.0</td>
</tr>
<tr class='mpb-player-13939'><td>74</td>
<td class='player-label'><a href='/nfl/players/duke-johnson.php?type=overall&week=draft'>Duke Johnson</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-13939' fp-player-name='Duke Johnson'></a></td>
<td>RB28</td>
<td>13</td>
<td>49</td>
<td>110</td>
<td>75.6</td>
<td>14.1</td>
<td>77.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-11220'><td>75</td>
<td class='player-label'><a href='/nfl/players/coby-fleener.php?type=overall&week=draft'>Coby Fleener</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-11220' fp-player-name='Coby Fleener'></a></td>
<td>TE6</td>
<td>5</td>
<td>40</td>
<td>171</td>
<td>77.6</td>
<td>19.9</td>
<td>67.0</td>
<td>&#45;8.0</td>
</tr>
<tr class='mpb-player-9520'><td>76</td>
<td class='player-label'><a href='/nfl/players/rashad-jennings.php?type=overall&week=draft'>Rashad Jennings</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-9520' fp-player-name='Rashad Jennings'></a></td>
<td>RB29</td>
<td>8</td>
<td>41</td>
<td>129</td>
<td>77.8</td>
<td>17.8</td>
<td>88.0</td>
<td>&#43;12.0</td>
</tr>
<tr class='mpb-player-9186'><td>77</td>
<td class='player-label'><a href='/nfl/players/desean-jackson.php?type=overall&week=draft'>DeSean Jackson</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-9186' fp-player-name='DeSean Jackson'></a></td>
<td>WR35</td>
<td>9</td>
<td>46</td>
<td>119</td>
<td>77.9</td>
<td>13.6</td>
<td>84.0</td>
<td>&#43;7.0</td>
</tr>
<tr class='mpb-player-9148'><td>78</td>
<td class='player-label'><a href='/nfl/players/danny-woodhead.php?type=overall&week=draft'>Danny Woodhead</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-9148' fp-player-name='Danny Woodhead'></a></td>
<td>RB30</td>
<td>11</td>
<td>31</td>
<td>148</td>
<td>78.8</td>
<td>17.6</td>
<td>80.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-13924'><td>79</td>
<td class='player-label'><a href='/nfl/players/ameer-abdullah.php?type=overall&week=draft'>Ameer Abdullah</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-13924' fp-player-name='Ameer Abdullah'></a></td>
<td>RB31</td>
<td>10</td>
<td>42</td>
<td>139</td>
<td>79.7</td>
<td>14.7</td>
<td>87.0</td>
<td>&#43;8.0</td>
</tr>
<tr class='mpb-player-9213'><td>80</td>
<td class='player-label'><a href='/nfl/players/eli-manning.php?type=overall&week=draft'>Eli Manning</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-9213' fp-player-name='Eli Manning'></a></td>
<td>QB8</td>
<td>8</td>
<td>48</td>
<td>141</td>
<td>81.0</td>
<td>15.9</td>
<td>70.0</td>
<td>&#45;10.0</td>
</tr>
<tr class='tier-row static'><td>Tier 7</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9460'><td>81</td>
<td class='player-label'><a href='/nfl/players/michael-crabtree.php?type=overall&week=draft'>Michael Crabtree</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-9460' fp-player-name='Michael Crabtree'></a></td>
<td>WR36</td>
<td>10</td>
<td>56</td>
<td>122</td>
<td>82.0</td>
<td>13.2</td>
<td>86.0</td>
<td>&#43;5.0</td>
</tr>
<tr class='mpb-player-13897'><td>82</td>
<td class='player-label'><a href='/nfl/players/devante-parker.php?type=overall&week=draft'>Devante Parker</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-13897' fp-player-name='Devante Parker'></a></td>
<td>WR37</td>
<td>8</td>
<td>43</td>
<td>156</td>
<td>83.7</td>
<td>23.3</td>
<td>81.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-9749'><td>83</td>
<td class='player-label'><a href='/nfl/players/christopher-ivory.php?type=overall&week=draft'>Chris Ivory</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-9749' fp-player-name='Chris Ivory'></a></td>
<td>RB32</td>
<td>5</td>
<td>43</td>
<td>141</td>
<td>84.7</td>
<td>16.0</td>
<td>78.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-12090'><td>84</td>
<td class='player-label'><a href='/nfl/players/blake-bortles.php?type=overall&week=draft'>Blake Bortles</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-12090' fp-player-name='Blake Bortles'></a></td>
<td>QB9</td>
<td>5</td>
<td>22</td>
<td>168</td>
<td>86.4</td>
<td>23.7</td>
<td>74.0</td>
<td>&#45;10.0</td>
</tr>
<tr class='mpb-player-9509'><td>85</td>
<td class='player-label'><a href='/nfl/players/philip-rivers.php?type=overall&week=draft'>Philip Rivers</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-9509' fp-player-name='Philip Rivers'></a></td>
<td>QB10</td>
<td>11</td>
<td>54</td>
<td>150</td>
<td>88.2</td>
<td>17.1</td>
<td>85.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9226'><td>86</td>
<td class='player-label'><a href='/nfl/players/gary-barnidge.php?type=overall&week=draft'>Gary Barnidge</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-9226' fp-player-name='Gary Barnidge'></a></td>
<td>TE7</td>
<td>13</td>
<td>53</td>
<td>131</td>
<td>91.5</td>
<td>13.9</td>
<td>79.0</td>
<td>&#45;7.0</td>
</tr>
<tr class='mpb-player-11440'><td>87</td>
<td class='player-label'><a href='/nfl/players/josh-gordon.php?type=overall&week=draft'>Josh Gordon</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-11440' fp-player-name='Josh Gordon'></a></td>
<td>WR38</td>
<td>13</td>
<td>22</td>
<td>219</td>
<td>89.6</td>
<td>30.0</td>
<td>96.0</td>
<td>&#43;9.0</td>
</tr>
<tr class='mpb-player-13941'><td>88</td>
<td class='player-label'><a href='/nfl/players/tj-yeldon.php?type=overall&week=draft'>T.J. Yeldon</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-13941' fp-player-name='T.J. Yeldon'></a></td>
<td>RB33</td>
<td>5</td>
<td>42</td>
<td>143</td>
<td>91.1</td>
<td>17.9</td>
<td>98.0</td>
<td>&#43;10.0</td>
</tr>
<tr class='mpb-player-9603'><td>89</td>
<td class='player-label'><a href='/nfl/players/tom-brady.php?type=overall&week=draft'>Tom Brady</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9603' fp-player-name='Tom Brady'></a></td>
<td>QB11</td>
<td>9</td>
<td>44</td>
<td>161</td>
<td>92.6</td>
<td>22.1</td>
<td>64.0</td>
<td>&#45;25.0</td>
</tr>
<tr class='mpb-player-11689'><td>90</td>
<td class='player-label'><a href='/nfl/players/zach-ertz.php?type=overall&week=draft'>Zach Ertz</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-11689' fp-player-name='Zach Ertz'></a></td>
<td>TE8</td>
<td>4</td>
<td>44</td>
<td>156</td>
<td>95.3</td>
<td>17.8</td>
<td>102.0</td>
<td>&#43;12.0</td>
</tr>
<tr class='mpb-player-9966'><td>91</td>
<td class='player-label'><a href='/nfl/players/julius-thomas.php?type=overall&week=draft'>Julius Thomas</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-9966' fp-player-name='Julius Thomas'></a></td>
<td>TE9</td>
<td>5</td>
<td>53</td>
<td>143</td>
<td>96.5</td>
<td>17.5</td>
<td>92.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-13899'><td>92</td>
<td class='player-label'><a href='/nfl/players/kevin-white.php?type=overall&week=draft'>Kevin White</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-13899' fp-player-name='Kevin White'></a></td>
<td>WR39</td>
<td>9</td>
<td>57</td>
<td>152</td>
<td>97.0</td>
<td>20.2</td>
<td>95.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-15569'><td>93</td>
<td class='player-label'><a href='/nfl/players/sterling-shepard.php?type=overall&week=draft'>Sterling Shepard</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-15569' fp-player-name='Sterling Shepard'></a></td>
<td>WR40</td>
<td>8</td>
<td>68</td>
<td>185</td>
<td>98.6</td>
<td>20.6</td>
<td>99.0</td>
<td>&#43;6.0</td>
</tr>
<tr class='mpb-player-9027'><td>94</td>
<td class='player-label'><a href='/nfl/players/antonio-gates.php?type=overall&week=draft'>Antonio Gates</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-9027' fp-player-name='Antonio Gates'></a></td>
<td>TE10</td>
<td>11</td>
<td>73</td>
<td>158</td>
<td>99.9</td>
<td>16.5</td>
<td>100.0</td>
<td>&#43;6.0</td>
</tr>
<tr class='mpb-player-9170'><td>95</td>
<td class='player-label'><a href='/nfl/players/deangelo-williams.php?type=overall&week=draft'>DeAngelo Williams</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-9170' fp-player-name='DeAngelo Williams'></a></td>
<td>RB34</td>
<td>8</td>
<td>54</td>
<td>161</td>
<td>99.1</td>
<td>19.5</td>
<td>82.0</td>
<td>&#45;13.0</td>
</tr>
<tr class='mpb-player-12116'><td>96</td>
<td class='player-label'><a href='/nfl/players/isaiah-crowell.php?type=overall&week=draft'>Isaiah Crowell</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-12116' fp-player-name='Isaiah Crowell'></a></td>
<td>RB35</td>
<td>13</td>
<td>65</td>
<td>177</td>
<td>99.2</td>
<td>19.9</td>
<td>122.0</td>
<td>&#43;26.0</td>
</tr>
<tr class='mpb-player-12104'><td>97</td>
<td class='player-label'><a href='/nfl/players/charles-sims.php?type=overall&week=draft'>Charles Sims</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-12104' fp-player-name='Charles Sims'></a></td>
<td>RB36</td>
<td>6</td>
<td>66</td>
<td>168</td>
<td>100.4</td>
<td>19.1</td>
<td>113.0</td>
<td>&#43;16.0</td>
</tr>
<tr class='mpb-player-9717'><td>98</td>
<td class='player-label'><a href='/nfl/players/legarrette-blount.php?type=overall&week=draft'>LeGarrette Blount</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9717' fp-player-name='LeGarrette Blount'></a></td>
<td>RB37</td>
<td>9</td>
<td>63</td>
<td>173</td>
<td>99.4</td>
<td>21.7</td>
<td>109.0</td>
<td>&#43;11.0</td>
</tr>
<tr class='mpb-player-13940'><td>99</td>
<td class='player-label'><a href='/nfl/players/jay-ajayi.php?type=overall&week=draft'>Jay Ajayi</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-13940' fp-player-name='Jay Ajayi'></a></td>
<td>RB38</td>
<td>8</td>
<td>48</td>
<td>161</td>
<td>102.3</td>
<td>23.8</td>
<td>94.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-12904'><td>100</td>
<td class='player-label'><a href='/nfl/players/willie-snead.php?type=overall&week=draft'>Willie Snead</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-12904' fp-player-name='Willie Snead'></a></td>
<td>WR41</td>
<td>5</td>
<td>78</td>
<td>138</td>
<td>103.6</td>
<td>14.2</td>
<td>120.0</td>
<td>&#43;20.0</td>
</tr>
<tr class='mpb-player-9335'><td>101</td>
<td class='player-label'><a href='/nfl/players/justin-forsett.php?type=overall&week=draft'>Justin Forsett</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-9335' fp-player-name='Justin Forsett'></a></td>
<td>RB39</td>
<td>8</td>
<td>41</td>
<td>175</td>
<td>103.9</td>
<td>20.6</td>
<td>97.0</td>
<td>&#45;4.0</td>
</tr>
<tr class='mpb-player-15514'><td>102</td>
<td class='player-label'><a href='/nfl/players/derrick-henry.php?type=overall&week=draft'>Derrick Henry</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-15514' fp-player-name='Derrick Henry'></a></td>
<td>RB40</td>
<td>13</td>
<td>59</td>
<td>184</td>
<td>103.1</td>
<td>21.9</td>
<td>104.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-15506'><td>103</td>
<td class='player-label'><a href='/nfl/players/corey-coleman.php?type=overall&week=draft'>Corey Coleman</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-15506' fp-player-name='Corey Coleman'></a></td>
<td>WR42</td>
<td>13</td>
<td>60</td>
<td>173</td>
<td>104.7</td>
<td>19.2</td>
<td>115.0</td>
<td>&#43;12.0</td>
</tr>
<tr class='mpb-player-11692'><td>104</td>
<td class='player-label'><a href='/nfl/players/tyler-eifert.php?type=overall&week=draft'>Tyler Eifert</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-11692' fp-player-name='Tyler Eifert'></a></td>
<td>TE11</td>
<td>9</td>
<td>49</td>
<td>220</td>
<td>107.1</td>
<td>27.6</td>
<td>76.0</td>
<td>&#45;28.0</td>
</tr>
<tr class='mpb-player-13981'><td>105</td>
<td class='player-label'><a href='/nfl/players/stefon-diggs.php?type=overall&week=draft'>Stefon Diggs</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-13981' fp-player-name='Stefon Diggs'></a></td>
<td>WR43</td>
<td>6</td>
<td>75</td>
<td>174</td>
<td>107.4</td>
<td>17.9</td>
<td>108.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='tier-row static'><td>Tier 8</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-10007'><td>106</td>
<td class='player-label'><a href='/nfl/players/tyrod-taylor.php?type=overall&week=draft'>Tyrod Taylor</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-10007' fp-player-name='Tyrod Taylor'></a></td>
<td>QB12</td>
<td>10</td>
<td>56</td>
<td>148</td>
<td>108.4</td>
<td>19.0</td>
<td>121.0</td>
<td>&#43;15.0</td>
</tr>
<tr class='mpb-player-9624'><td>107</td>
<td class='player-label'><a href='/nfl/players/vincent-jackson.php?type=overall&week=draft'>Vincent Jackson</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-9624' fp-player-name='Vincent Jackson'></a></td>
<td>WR44</td>
<td>6</td>
<td>74</td>
<td>158</td>
<td>111.3</td>
<td>18.3</td>
<td>136.0</td>
<td>&#43;29.0</td>
</tr>
<tr class='mpb-player-11177'><td>108</td>
<td class='player-label'><a href='/nfl/players/kirk-cousins.php?type=overall&week=draft'>Kirk Cousins</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-11177' fp-player-name='Kirk Cousins'></a></td>
<td>QB13</td>
<td>9</td>
<td>51</td>
<td>199</td>
<td>110.5</td>
<td>22.4</td>
<td>114.0</td>
<td>&#43;6.0</td>
</tr>
<tr class='mpb-player-9884'><td>109</td>
<td class='player-label'><a href='/nfl/players/torrey-smith.php?type=overall&week=draft'>Torrey Smith</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-9884' fp-player-name='Torrey Smith'></a></td>
<td>WR45</td>
<td>8</td>
<td>62</td>
<td>198</td>
<td>111.5</td>
<td>26.4</td>
<td>112.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-11625'><td>110</td>
<td class='player-label'><a href='/nfl/players/tavon-austin.php?type=overall&week=draft'>Tavon Austin</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-11625' fp-player-name='Tavon Austin'></a></td>
<td>WR46</td>
<td>8</td>
<td>60</td>
<td>168</td>
<td>112.5</td>
<td>20.5</td>
<td>111.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-12092'><td>111</td>
<td class='player-label'><a href='/nfl/players/derek-carr.php?type=overall&week=draft'>Derek Carr</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-12092' fp-player-name='Derek Carr'></a></td>
<td>QB14</td>
<td>10</td>
<td>41</td>
<td>183</td>
<td>111.0</td>
<td>21.1</td>
<td>106.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-11214'><td>112</td>
<td class='player-label'><a href='/nfl/players/travis-benjamin.php?type=overall&week=draft'>Travis Benjamin</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-11214' fp-player-name='Travis Benjamin'></a></td>
<td>WR47</td>
<td>11</td>
<td>53</td>
<td>185</td>
<td>115.0</td>
<td>22.4</td>
<td>131.0</td>
<td>&#43;19.0</td>
</tr>
<tr class='mpb-player-11219'><td>113</td>
<td class='player-label'><a href='/nfl/players/dwayne-allen.php?type=overall&week=draft'>Dwayne Allen</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-11219' fp-player-name='Dwayne Allen'></a></td>
<td>TE12</td>
<td>10</td>
<td>50</td>
<td>181</td>
<td>115.5</td>
<td>21.6</td>
<td>149.0</td>
<td>&#43;36.0</td>
</tr>
<tr class='mpb-player-13891'><td>114</td>
<td class='player-label'><a href='/nfl/players/jameis-winston.php?type=overall&week=draft'>Jameis Winston</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-13891' fp-player-name='Jameis Winston'></a></td>
<td>QB15</td>
<td>6</td>
<td>58</td>
<td>171</td>
<td>115.1</td>
<td>21.1</td>
<td>127.0</td>
<td>&#43;13.0</td>
</tr>
<tr class='mpb-player-9451'><td>115</td>
<td class='player-label'><a href='/nfl/players/matthew-stafford.php?type=overall&week=draft'>Matthew Stafford</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-9451' fp-player-name='Matthew Stafford'></a></td>
<td>QB16</td>
<td>10</td>
<td>63</td>
<td>169</td>
<td>115.7</td>
<td>18.9</td>
<td>128.0</td>
<td>&#43;13.0</td>
</tr>
<tr class='mpb-player-9963'><td>116</td>
<td class='player-label'><a href='/nfl/players/bilal-powell.php?type=overall&week=draft'>Bilal Powell</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9963' fp-player-name='Bilal Powell'></a></td>
<td>RB41</td>
<td>11</td>
<td>73</td>
<td>173</td>
<td>115.6</td>
<td>18.7</td>
<td>132.0</td>
<td>&#43;16.0</td>
</tr>
<tr class='mpb-player-13926'><td>117</td>
<td class='player-label'><a href='/nfl/players/tevin-coleman.php?type=overall&week=draft'>Tevin Coleman</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-13926' fp-player-name='Tevin Coleman'></a></td>
<td>RB42</td>
<td>11</td>
<td>43</td>
<td>194</td>
<td>117.6</td>
<td>22.3</td>
<td>133.0</td>
<td>&#43;16.0</td>
</tr>
<tr class='mpb-player-13915'><td>118</td>
<td class='player-label'><a href='/nfl/players/devin-funchess.php?type=overall&week=draft'>Devin Funchess</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-13915' fp-player-name='Devin Funchess'></a></td>
<td>WR48</td>
<td>7</td>
<td>77</td>
<td>167</td>
<td>120.7</td>
<td>21.8</td>
<td>138.0</td>
<td>&#43;20.0</td>
</tr>
<tr class='mpb-player-9907'><td>119</td>
<td class='player-label'><a href='/nfl/players/andy-dalton.php?type=overall&week=draft'>Andy Dalton</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-9907' fp-player-name='Andy Dalton'></a></td>
<td>QB17</td>
<td>9</td>
<td>61</td>
<td>192</td>
<td>121.6</td>
<td>22.0</td>
<td>123.0</td>
<td>&#43;4.0</td>
</tr>
<tr class='mpb-player-11609'><td>120</td>
<td class='player-label'><a href='/nfl/players/markus-wheaton.php?type=overall&week=draft'>Markus Wheaton</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-11609' fp-player-name='Markus Wheaton'></a></td>
<td>WR49</td>
<td>8</td>
<td>78</td>
<td>192</td>
<td>122.8</td>
<td>19.7</td>
<td>118.0</td>
<td>&#45;2.0</td>
</tr>
<tr class='mpb-player-9429'><td>121</td>
<td class='player-label'><a href='/nfl/players/martellus-bennett.php?type=overall&week=draft'>Martellus Bennett</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9429' fp-player-name='Martellus Bennett'></a></td>
<td>TE13</td>
<td>9</td>
<td>76</td>
<td>183</td>
<td>122.3</td>
<td>22.7</td>
<td>124.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-13890'><td>122</td>
<td class='player-label'><a href='/nfl/players/marcus-mariota.php?type=overall&week=draft'>Marcus Mariota</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-13890' fp-player-name='Marcus Mariota'></a></td>
<td>QB18</td>
<td>13</td>
<td>73</td>
<td>174</td>
<td>124.4</td>
<td>20.7</td>
<td>140.0</td>
<td>&#43;18.0</td>
</tr>
<tr class='mpb-player-11081'><td>123</td>
<td class='player-label'><a href='/nfl/players/kamar-aiken.php?type=overall&week=draft'>Kamar Aiken</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-11081' fp-player-name='Kamar Aiken'></a></td>
<td>WR50</td>
<td>8</td>
<td>74</td>
<td>236</td>
<td>124.9</td>
<td>28.4</td>
<td>142.0</td>
<td>&#43;19.0</td>
</tr>
<tr class='mpb-player-11649'><td>124</td>
<td class='player-label'><a href='/nfl/players/theo-riddick.php?type=overall&week=draft'>Theo Riddick</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-11649' fp-player-name='Theo Riddick'></a></td>
<td>RB43</td>
<td>10</td>
<td>81</td>
<td>184</td>
<td>124.7</td>
<td>20.5</td>
<td>125.0</td>
<td>&#43;1.0</td>
</tr>
<tr class='mpb-player-9579'><td>125</td>
<td class='player-label'><a href='/nfl/players/steve-smith.php?type=overall&week=draft'>Steve Smith</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-9579' fp-player-name='Steve Smith'></a></td>
<td>WR51</td>
<td>8</td>
<td>64</td>
<td>199</td>
<td>129.7</td>
<td>25.8</td>
<td>145.0</td>
<td>&#43;20.0</td>
</tr>
<tr class='mpb-player-13979'><td>126</td>
<td class='player-label'><a href='/nfl/players/phillip-dorsett.php?type=overall&week=draft'>Phillip Dorsett</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-13979' fp-player-name='Phillip Dorsett'></a></td>
<td>WR52</td>
<td>10</td>
<td>91</td>
<td>187</td>
<td>135.8</td>
<td>19.1</td>
<td>170.0</td>
<td>&#43;44.0</td>
</tr>
<tr class='mpb-player-9275'><td>127</td>
<td class='player-label'><a href='/nfl/players/jason-witten.php?type=overall&week=draft'>Jason Witten</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-9275' fp-player-name='Jason Witten'></a></td>
<td>TE14</td>
<td>7</td>
<td>94</td>
<td>183</td>
<td>135.2</td>
<td>20.5</td>
<td>129.0</td>
<td>&#43;2.0</td>
</tr>
<tr class='mpb-player-12143'><td>128</td>
<td class='player-label'><a href='/nfl/players/eric-ebron.php?type=overall&week=draft'>Eric Ebron</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-12143' fp-player-name='Eric Ebron'></a></td>
<td>TE15</td>
<td>10</td>
<td>92</td>
<td>200</td>
<td>130.9</td>
<td>21.9</td>
<td>179.0</td>
<td>&#43;51.0</td>
</tr>
<tr class='mpb-player-15528'><td>129</td>
<td class='player-label'><a href='/nfl/players/michael-thomas-wr.php?type=overall&week=draft'>Michael Thomas</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-15528' fp-player-name='Michael Thomas'></a></td>
<td>WR53</td>
<td>5</td>
<td>84</td>
<td>292</td>
<td>133.2</td>
<td>26.5</td>
<td>147.0</td>
<td>&#43;18.0</td>
</tr>
<tr class='mpb-player-9444'><td>130</td>
<td class='player-label'><a href='/nfl/players/matt-ryan.php?type=overall&week=draft'>Matt Ryan</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-9444' fp-player-name='Matt Ryan'></a></td>
<td>QB19</td>
<td>11</td>
<td>99</td>
<td>195</td>
<td>135.7</td>
<td>20.9</td>
<td>144.0</td>
<td>&#43;14.0</td>
</tr>
<tr class='mpb-player-11200'><td>131</td>
<td class='player-label'><a href='/nfl/players/mohamed-sanu.php?type=overall&week=draft'>Mohamed Sanu</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-11200' fp-player-name='Mohamed Sanu'></a></td>
<td>WR54</td>
<td>11</td>
<td>83</td>
<td>208</td>
<td>136.4</td>
<td>22.8</td>
<td>159.0</td>
<td>&#43;28.0</td>
</tr>
<tr class='mpb-player-11174'><td>132</td>
<td class='player-label'><a href='/nfl/players/ryan-tannehill.php?type=overall&week=draft'>Ryan Tannehill</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-11174' fp-player-name='Ryan Tannehill'></a></td>
<td>QB20</td>
<td>8</td>
<td>80</td>
<td>195</td>
<td>137.1</td>
<td>23.2</td>
<td>176.0</td>
<td>&#43;44.0</td>
</tr>
<tr class='tier-row static'><td>Tier 9</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9712'><td>133</td>
<td class='player-label'><a href='/nfl/players/jimmy-graham.php?type=overall&week=draft'>Jimmy Graham</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-9712' fp-player-name='Jimmy Graham'></a></td>
<td>TE16</td>
<td>5</td>
<td>76</td>
<td>241</td>
<td>140.1</td>
<td>26.0</td>
<td>110.0</td>
<td>&#45;23.0</td>
</tr>
<tr class='mpb-player-9545'><td>134</td>
<td class='player-label'><a href='/nfl/players/ryan-fitzpatrick.php?type=overall&week=draft'>Ryan Fitzpatrick</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9545' fp-player-name='Ryan Fitzpatrick'></a></td>
<td>QB21</td>
<td>11</td>
<td>96</td>
<td>193</td>
<td>139.0</td>
<td>22.1</td>
<td>174.0</td>
<td>&#43;40.0</td>
</tr>
<tr class='mpb-player-8260'><td>135</td>
<td class='player-label'><a href='/nfl/teams/seattle-defense.php'>Seattle Seahawks</a> <a href='#' class='fp-player-link fp-id-8260' fp-player-name='Seattle Seahawks'></a></td>
<td>DST1</td>
<td>5</td>
<td>117</td>
<td>209</td>
<td>142.1</td>
<td>16.5</td>
<td>101.0</td>
<td>&#45;34.0</td>
</tr>
<tr class='mpb-player-11380'><td>136</td>
<td class='player-label'><a href='/nfl/players/rishard-matthews.php?type=overall&week=draft'>Rishard Matthews</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-11380' fp-player-name='Rishard Matthews'></a></td>
<td>WR55</td>
<td>13</td>
<td>90</td>
<td>209</td>
<td>141.5</td>
<td>25.6</td>
<td>198.0</td>
<td>&#43;62.0</td>
</tr>
<tr class='mpb-player-8090'><td>137</td>
<td class='player-label'><a href='/nfl/teams/denver-defense.php'>Denver Broncos</a> <a href='#' class='fp-player-link fp-id-8090' fp-player-name='Denver Broncos'></a></td>
<td>DST2</td>
<td>11</td>
<td>119</td>
<td>210</td>
<td>142.6</td>
<td>15.9</td>
<td>90.0</td>
<td>&#45;47.0</td>
</tr>
<tr class='mpb-player-9635'><td>138</td>
<td class='player-label'><a href='/nfl/players/zach-miller-chi.php?type=overall&week=draft'>Zach Miller</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9635' fp-player-name='Zach Miller'></a></td>
<td>TE17</td>
<td>9</td>
<td>103</td>
<td>231</td>
<td>146.0</td>
<td>21.2</td>
<td>163.0</td>
<td>&#43;25.0</td>
</tr>
<tr class='mpb-player-12195'><td>139</td>
<td class='player-label'><a href='/nfl/players/james-white.php?type=overall&week=draft'>James White</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-12195' fp-player-name='James White'></a></td>
<td>RB44</td>
<td>9</td>
<td>59</td>
<td>257</td>
<td>138.9</td>
<td>44.7</td>
<td>154.0</td>
<td>&#43;15.0</td>
</tr>
<tr class='mpb-player-9479'><td>140</td>
<td class='player-label'><a href='/nfl/players/mike-wallace.php?type=overall&week=draft'>Mike Wallace</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-9479' fp-player-name='Mike Wallace'></a></td>
<td>WR56</td>
<td>8</td>
<td>79</td>
<td>229</td>
<td>146.8</td>
<td>26.5</td>
<td>197.0</td>
<td>&#43;57.0</td>
</tr>
<tr class='mpb-player-11658'><td>141</td>
<td class='player-label'><a href='/nfl/players/christine-michael.php?type=overall&week=draft'>Christine Michael</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-11658' fp-player-name='Christine Michael'></a></td>
<td>RB45</td>
<td>5</td>
<td>72</td>
<td>252</td>
<td>143.2</td>
<td>38.5</td>
<td>150.0</td>
<td>&#43;9.0</td>
</tr>
<tr class='mpb-player-12209'><td>142</td>
<td class='player-label'><a href='/nfl/players/jerick-mckinnon.php?type=overall&week=draft'>Jerick McKinnon</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-12209' fp-player-name='Jerick McKinnon'></a></td>
<td>RB46</td>
<td>6</td>
<td>87</td>
<td>223</td>
<td>146.8</td>
<td>25.3</td>
<td>185.0</td>
<td>&#43;43.0</td>
</tr>
<tr class='mpb-player-15495'><td>143</td>
<td class='player-label'><a href='/nfl/players/laquon-treadwell.php?type=overall&week=draft'>Laquon Treadwell</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-15495' fp-player-name='Laquon Treadwell'></a></td>
<td>WR57</td>
<td>6</td>
<td>82</td>
<td>219</td>
<td>144.2</td>
<td>30.6</td>
<td>139.0</td>
<td>&#45;4.0</td>
</tr>
<tr class='mpb-player-15806'><td>144</td>
<td class='player-label'><a href='/nfl/players/deandre-washington.php?type=overall&week=draft'>DeAndre Washington</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-15806' fp-player-name='DeAndre Washington'></a></td>
<td>RB47</td>
<td>10</td>
<td>49</td>
<td>209</td>
<td>146.4</td>
<td>28.2</td>
<td>167.0</td>
<td>&#43;23.0</td>
</tr>
<tr class='mpb-player-8000'><td>145</td>
<td class='player-label'><a href='/nfl/teams/arizona-defense.php'>Arizona Cardinals</a> <a href='#' class='fp-player-link fp-id-8000' fp-player-name='Arizona Cardinals'></a></td>
<td>DST3</td>
<td>9</td>
<td>120</td>
<td>192</td>
<td>147.1</td>
<td>15.2</td>
<td>105.0</td>
<td>&#45;40.0</td>
</tr>
<tr class='mpb-player-15547'><td>146</td>
<td class='player-label'><a href='/nfl/players/tyler-boyd.php?type=overall&week=draft'>Tyler Boyd</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-15547' fp-player-name='Tyler Boyd'></a></td>
<td>WR58</td>
<td>9</td>
<td>84</td>
<td>294</td>
<td>149.9</td>
<td>31.1</td>
<td>188.0</td>
<td>&#43;42.0</td>
</tr>
<tr class='mpb-player-9155'><td>147</td>
<td class='player-label'><a href='/nfl/players/darren-sproles.php?type=overall&week=draft'>Darren Sproles</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-9155' fp-player-name='Darren Sproles'></a></td>
<td>RB48</td>
<td>4</td>
<td>83</td>
<td>195</td>
<td>150.6</td>
<td>26.0</td>
<td>146.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-15555'><td>148</td>
<td class='player-label'><a href='/nfl/players/devontae-booker.php?type=overall&week=draft'>Devontae Booker</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-15555' fp-player-name='Devontae Booker'></a></td>
<td>RB49</td>
<td>11</td>
<td>56</td>
<td>196</td>
<td>147.9</td>
<td>24.8</td>
<td>155.0</td>
<td>&#43;7.0</td>
</tr>
<tr class='mpb-player-9711'><td>149</td>
<td class='player-label'><a href='/nfl/players/james-starks.php?type=overall&week=draft'>James Starks</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9711' fp-player-name='James Starks'></a></td>
<td>RB50</td>
<td>4</td>
<td>100</td>
<td>211</td>
<td>150.8</td>
<td>25.5</td>
<td>148.0</td>
<td>&#45;1.0</td>
</tr>
<tr class='mpb-player-13944'><td>150</td>
<td class='player-label'><a href='/nfl/players/javorius-allen.php?type=overall&week=draft'>Javorius Allen</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-13944' fp-player-name='Javorius Allen'></a></td>
<td>RB51</td>
<td>8</td>
<td>108</td>
<td>269</td>
<td>151.5</td>
<td>30.2</td>
<td>192.0</td>
<td>&#43;42.0</td>
</tr>
<tr class='mpb-player-15577'><td>151</td>
<td class='player-label'><a href='/nfl/players/kenneth-dixon.php?type=overall&week=draft'>Kenneth Dixon</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-15577' fp-player-name='Kenneth Dixon'></a></td>
<td>RB52</td>
<td>8</td>
<td>76</td>
<td>245</td>
<td>147.9</td>
<td>31.1</td>
<td>169.0</td>
<td>&#43;18.0</td>
</tr>
<tr class='mpb-player-15587'><td>152</td>
<td class='player-label'><a href='/nfl/players/tajae-sharpe.php?type=overall&week=draft'>Tajae Sharpe</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-15587' fp-player-name='Tajae Sharpe'></a></td>
<td>WR59</td>
<td>13</td>
<td>89</td>
<td>257</td>
<td>153.3</td>
<td>39.2</td>
<td>190.0</td>
<td>&#43;38.0</td>
</tr>
<tr class='mpb-player-13911'><td>153</td>
<td class='player-label'><a href='/nfl/players/sammie-coates.php?type=overall&week=draft'>Sammie Coates</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-13911' fp-player-name='Sammie Coates'></a></td>
<td>WR60</td>
<td>8</td>
<td>92</td>
<td>295</td>
<td>157.4</td>
<td>33.3</td>
<td>168.0</td>
<td>&#43;15.0</td>
</tr>
<tr class='mpb-player-9280'><td>154</td>
<td class='player-label'><a href='/nfl/players/jay-cutler.php?type=overall&week=draft'>Jay Cutler</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9280' fp-player-name='Jay Cutler'></a></td>
<td>QB22</td>
<td>9</td>
<td>106</td>
<td>243</td>
<td>159.4</td>
<td>22.7</td>
<td>206.0</td>
<td>&#43;52.0</td>
</tr>
<tr class='mpb-player-15585'><td>155</td>
<td class='player-label'><a href='/nfl/players/jordan-howard.php?type=overall&week=draft'>Jordan Howard</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-15585' fp-player-name='Jordan Howard'></a></td>
<td>RB53</td>
<td>9</td>
<td>100</td>
<td>211</td>
<td>151.5</td>
<td>25.8</td>
<td>200.0</td>
<td>&#43;45.0</td>
</tr>
<tr class='mpb-player-9897'><td>156</td>
<td class='player-label'><a href='/nfl/players/shane-vereen.php?type=overall&week=draft'>Shane Vereen</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-9897' fp-player-name='Shane Vereen'></a></td>
<td>RB54</td>
<td>8</td>
<td>110</td>
<td>218</td>
<td>155.7</td>
<td>27.3</td>
<td>202.0</td>
<td>&#43;46.0</td>
</tr>
<tr class='mpb-player-8040'><td>157</td>
<td class='player-label'><a href='/nfl/teams/carolina-defense.php'>Carolina Panthers</a> <a href='#' class='fp-player-link fp-id-8040' fp-player-name='Carolina Panthers'></a></td>
<td>DST4</td>
<td>7</td>
<td>120</td>
<td>193</td>
<td>158.4</td>
<td>14.3</td>
<td>103.0</td>
<td>&#45;54.0</td>
</tr>
<tr class='mpb-player-9265'><td>158</td>
<td class='player-label'><a href='/nfl/players/jared-cook.php?type=overall&week=draft'>Jared Cook</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9265' fp-player-name='Jared Cook'></a></td>
<td>TE18</td>
<td>4</td>
<td>90</td>
<td>233</td>
<td>158.7</td>
<td>29.0</td>
<td>180.0</td>
<td>&#43;22.0</td>
</tr>
<tr class='mpb-player-11638'><td>159</td>
<td class='player-label'><a href='/nfl/players/spencer-ware.php?type=overall&week=draft'>Spencer Ware</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-11638' fp-player-name='Spencer Ware'></a></td>
<td>RB55</td>
<td>5</td>
<td>91</td>
<td>234</td>
<td>156.2</td>
<td>32.3</td>
<td>186.0</td>
<td>&#43;27.0</td>
</tr>
<tr class='mpb-player-9983'><td>160</td>
<td class='player-label'><a href='/nfl/players/dion-lewis.php?type=overall&week=draft'>Dion Lewis</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9983' fp-player-name='Dion Lewis'></a></td>
<td>RB56</td>
<td>9</td>
<td>38</td>
<td>271</td>
<td>153.8</td>
<td>51.4</td>
<td>89.0</td>
<td>&#45;71.0</td>
</tr>
<tr class='mpb-player-9300'><td>161</td>
<td class='player-label'><a href='/nfl/players/joe-flacco.php?type=overall&week=draft'>Joe Flacco</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-9300' fp-player-name='Joe Flacco'></a></td>
<td>QB23</td>
<td>8</td>
<td>107</td>
<td>226</td>
<td>158.7</td>
<td>24.1</td>
<td>187.0</td>
<td>&#43;26.0</td>
</tr>
<tr class='mpb-player-10003'><td>162</td>
<td class='player-label'><a href='/nfl/players/charles-clay.php?type=overall&week=draft'>Charles Clay</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-10003' fp-player-name='Charles Clay'></a></td>
<td>TE19</td>
<td>10</td>
<td>108</td>
<td>239</td>
<td>158.0</td>
<td>24.7</td>
<td>211.0</td>
<td>&#43;49.0</td>
</tr>
<tr class='mpb-player-11627'><td>163</td>
<td class='player-label'><a href='/nfl/players/terrance-williams.php?type=overall&week=draft'>Terrance Williams</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-11627' fp-player-name='Terrance Williams'></a></td>
<td>WR61</td>
<td>7</td>
<td>106</td>
<td>221</td>
<td>160.0</td>
<td>22.6</td>
<td>194.0</td>
<td>&#43;31.0</td>
</tr>
<tr class='mpb-player-9510'><td>164</td>
<td class='player-label'><a href='/nfl/players/pierre-garcon.php?type=overall&week=draft'>Pierre Garcon</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-9510' fp-player-name='Pierre Garcon'></a></td>
<td>WR62</td>
<td>9</td>
<td>100</td>
<td>240</td>
<td>159.1</td>
<td>23.8</td>
<td>207.0</td>
<td>&#43;43.0</td>
</tr>
<tr class='mpb-player-15614'><td>165</td>
<td class='player-label'><a href='/nfl/players/cj-prosise.php?type=overall&week=draft'>C.J. Prosise</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-15614' fp-player-name='C.J. Prosise'></a></td>
<td>RB57</td>
<td>5</td>
<td>102</td>
<td>273</td>
<td>157.2</td>
<td>28.8</td>
<td>171.0</td>
<td>&#43;6.0</td>
</tr>
<tr class='mpb-player-11221'><td>166</td>
<td class='player-label'><a href='/nfl/players/ladarius-green.php?type=overall&week=draft'>Ladarius Green</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-11221' fp-player-name='Ladarius Green'></a></td>
<td>TE20</td>
<td>8</td>
<td>81</td>
<td>245</td>
<td>154.1</td>
<td>37.0</td>
<td>134.0</td>
<td>&#45;32.0</td>
</tr>
<tr class='mpb-player-8120'><td>167</td>
<td class='player-label'><a href='/nfl/teams/houston-defense.php'>Houston Texans</a> <a href='#' class='fp-player-link fp-id-8120' fp-player-name='Houston Texans'></a></td>
<td>DST5</td>
<td>9</td>
<td>134</td>
<td>228</td>
<td>164.3</td>
<td>17.9</td>
<td>117.0</td>
<td>&#45;50.0</td>
</tr>
<tr class='mpb-player-11477'><td>168</td>
<td class='player-label'><a href='/nfl/players/chris-hogan.php?type=overall&week=draft'>Chris Hogan</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-11477' fp-player-name='Chris Hogan'></a></td>
<td>WR63</td>
<td>9</td>
<td>96</td>
<td>318</td>
<td>166.1</td>
<td>37.2</td>
<td>209.0</td>
<td>&#43;41.0</td>
</tr>
<tr class='mpb-player-13904'><td>169</td>
<td class='player-label'><a href='/nfl/players/dorial-green-beckham.php?type=overall&week=draft'>Dorial Green-Beckham</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-13904' fp-player-name='Dorial Green-Beckham'></a></td>
<td>WR64</td>
<td>4</td>
<td>90</td>
<td>244</td>
<td>158.7</td>
<td>36.7</td>
<td>164.0</td>
<td>&#45;5.0</td>
</tr>
<tr class='mpb-player-13956'><td>170</td>
<td class='player-label'><a href='/nfl/players/clive-walford.php?type=overall&week=draft'>Clive Walford</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-13956' fp-player-name='Clive Walford'></a></td>
<td>TE21</td>
<td>10</td>
<td>84</td>
<td>242</td>
<td>166.2</td>
<td>23.4</td>
<td>235.0</td>
<td>&#43;65.0</td>
</tr>
<tr class='mpb-player-9123'><td>171</td>
<td class='player-label'><a href='/nfl/players/chris-johnson.php?type=overall&week=draft'>Chris Johnson</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-9123' fp-player-name='Chris Johnson'></a></td>
<td>RB58</td>
<td>9</td>
<td>87</td>
<td>255</td>
<td>163.1</td>
<td>28.8</td>
<td>157.0</td>
<td>&#45;14.0</td>
</tr>
<tr class='tier-row static'><td>Tier 10</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-9012'><td>172</td>
<td class='player-label'><a href='/nfl/players/alex-smith-sf.php?type=overall&week=draft'>Alex Smith</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-9012' fp-player-name='Alex Smith'></a></td>
<td>QB24</td>
<td>5</td>
<td>116</td>
<td>266</td>
<td>167.8</td>
<td>25.0</td>
<td>172.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-15629'><td>173</td>
<td class='player-label'><a href='/nfl/players/will-fuller.php?type=overall&week=draft'>Will Fuller</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-15629' fp-player-name='Will Fuller'></a></td>
<td>WR65</td>
<td>9</td>
<td>99</td>
<td>297</td>
<td>169.3</td>
<td>35.6</td>
<td>196.0</td>
<td>&#43;23.0</td>
</tr>
<tr class='mpb-player-11197'><td>174</td>
<td class='player-label'><a href='/nfl/players/kendall-wright.php?type=overall&week=draft'>Kendall Wright</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-11197' fp-player-name='Kendall Wright'></a></td>
<td>WR66</td>
<td>13</td>
<td>95</td>
<td>262</td>
<td>165.0</td>
<td>29.1</td>
<td>248.0</td>
<td>&#43;74.0</td>
</tr>
<tr class='mpb-player-12145'><td>175</td>
<td class='player-label'><a href='/nfl/players/austin-seferian-jenkins.php?type=overall&week=draft'>Austin Seferian-Jenkins</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-12145' fp-player-name='Austin Seferian-Jenkins'></a></td>
<td>TE22</td>
<td>6</td>
<td>108</td>
<td>290</td>
<td>168.6</td>
<td>31.3</td>
<td>215.0</td>
<td>&#43;40.0</td>
</tr>
<tr class='mpb-player-15511'><td>176</td>
<td class='player-label'><a href='/nfl/players/josh-doctson.php?type=overall&week=draft'>Josh Doctson</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-15511' fp-player-name='Josh Doctson'></a></td>
<td>WR67</td>
<td>9</td>
<td>112</td>
<td>246</td>
<td>168.5</td>
<td>26.5</td>
<td>181.0</td>
<td>&#43;5.0</td>
</tr>
<tr class='mpb-player-9020'><td>177</td>
<td class='player-label'><a href='/nfl/players/anquan-boldin.php?type=overall&week=draft'>Anquan Boldin</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-9020' fp-player-name='Anquan Boldin'></a></td>
<td>WR68</td>
<td>10</td>
<td>91</td>
<td>251</td>
<td>166.7</td>
<td>29.0</td>
<td>204.0</td>
<td>&#43;27.0</td>
</tr>
<tr class='mpb-player-9609'><td>178</td>
<td class='player-label'><a href='/nfl/players/tony-romo.php?type=overall&week=draft'>Tony Romo</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-9609' fp-player-name='Tony Romo'></a></td>
<td>QB25</td>
<td>7</td>
<td>68</td>
<td>296</td>
<td>151.6</td>
<td>50.0</td>
<td>107.0</td>
<td>&#45;71.0</td>
</tr>
<tr class='mpb-player-12137'><td>179</td>
<td class='player-label'><a href='/nfl/players/bruce-ellington.php?type=overall&week=draft'>Bruce Ellington</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-12137' fp-player-name='Bruce Ellington'></a></td>
<td>WR69</td>
<td>8</td>
<td>96</td>
<td>283</td>
<td>163.0</td>
<td>36.3</td>
<td>213.0</td>
<td>&#43;34.0</td>
</tr>
<tr class='mpb-player-11173'><td>180</td>
<td class='player-label'><a href='/nfl/players/robert-griffin-iii.php?type=overall&week=draft'>Robert Griffin</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-11173' fp-player-name='Robert Griffin'></a></td>
<td>QB26</td>
<td>13</td>
<td>91</td>
<td>260</td>
<td>172.8</td>
<td>31.6</td>
<td>183.0</td>
<td>&#43;3.0</td>
</tr>
<tr class='mpb-player-11651'><td>181</td>
<td class='player-label'><a href='/nfl/players/chris-thompson.php?type=overall&week=draft'>Chris Thompson</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-11651' fp-player-name='Chris Thompson'></a></td>
<td>RB59</td>
<td>9</td>
<td>96</td>
<td>237</td>
<td>172.1</td>
<td>28.2</td>
<td>359.0</td>
<td>&#43;178.0</td>
</tr>
<tr class='mpb-player-11347'><td>182</td>
<td class='player-label'><a href='/nfl/players/alfred-morris.php?type=overall&week=draft'>Alfred Morris</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-11347' fp-player-name='Alfred Morris'></a></td>
<td>RB60</td>
<td>7</td>
<td>98</td>
<td>334</td>
<td>175.0</td>
<td>34.2</td>
<td>137.0</td>
<td>&#45;45.0</td>
</tr>
<tr class='mpb-player-9588'><td>183</td>
<td class='player-label'><a href='/nfl/players/ted-ginn-jr.php?type=overall&week=draft'>Ted Ginn</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9588' fp-player-name='Ted Ginn'></a></td>
<td>WR70</td>
<td>7</td>
<td>118</td>
<td>217</td>
<td>173.7</td>
<td>22.6</td>
<td>160.0</td>
<td>&#45;23.0</td>
</tr>
<tr class='mpb-player-9946'><td>184</td>
<td class='player-label'><a href='/nfl/players/jordan-cameron.php?type=overall&week=draft'>Jordan Cameron</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-9946' fp-player-name='Jordan Cameron'></a></td>
<td>TE23</td>
<td>8</td>
<td>124</td>
<td>235</td>
<td>174.6</td>
<td>24.3</td>
<td>231.0</td>
<td>&#43;47.0</td>
</tr>
<tr class='mpb-player-11699'><td>185</td>
<td class='player-label'><a href='/nfl/players/vance-mcdonald.php?type=overall&week=draft'>Vance McDonald</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-11699' fp-player-name='Vance McDonald'></a></td>
<td>TE24</td>
<td>8</td>
<td>115</td>
<td>283</td>
<td>174.8</td>
<td>31.7</td>
<td>280.0</td>
<td>&#43;95.0</td>
</tr>
<tr class='mpb-player-12194'><td>186</td>
<td class='player-label'><a href='/nfl/players/terrance-west.php?type=overall&week=draft'>Terrance West</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-12194' fp-player-name='Terrance West'></a></td>
<td>RB61</td>
<td>8</td>
<td>99</td>
<td>287</td>
<td>173.5</td>
<td>38.2</td>
<td>205.0</td>
<td>&#43;19.0</td>
</tr>
<tr class='mpb-player-9154'><td>187</td>
<td class='player-label'><a href='/nfl/players/darren-mcfadden.php?type=overall&week=draft'>Darren McFadden</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-9154' fp-player-name='Darren McFadden'></a></td>
<td>RB62</td>
<td>7</td>
<td>112</td>
<td>247</td>
<td>172.6</td>
<td>27.8</td>
<td>178.0</td>
<td>&#45;9.0</td>
</tr>
<tr class='mpb-player-8280'><td>188</td>
<td class='player-label'><a href='/nfl/teams/los-angeles-defense.php'>Los Angeles Rams</a> <a href='#' class='fp-player-link fp-id-8280' fp-player-name='Los Angeles Rams'></a></td>
<td>DST6</td>
<td>8</td>
<td>139</td>
<td>243</td>
<td>174.6</td>
<td>17.2</td>
<td>135.0</td>
<td>&#45;53.0</td>
</tr>
<tr class='mpb-player-9596'><td>189</td>
<td class='player-label'><a href='/nfl/players/tim-hightower.php?type=overall&week=draft'>Tim Hightower</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-9596' fp-player-name='Tim Hightower'></a></td>
<td>RB63</td>
<td>5</td>
<td>123</td>
<td>254</td>
<td>174.9</td>
<td>26.6</td>
<td>221.0</td>
<td>&#43;32.0</td>
</tr>
<tr class='mpb-player-11611'><td>190</td>
<td class='player-label'><a href='/nfl/players/kenny-stills.php?type=overall&week=draft'>Kenny Stills</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-11611' fp-player-name='Kenny Stills'></a></td>
<td>WR71</td>
<td>8</td>
<td>99</td>
<td>293</td>
<td>169.8</td>
<td>42.6</td>
<td>299.0</td>
<td>&#43;109.0</td>
</tr>
<tr class='mpb-player-15551'><td>191</td>
<td class='player-label'><a href='/nfl/players/paul-perkins.php?type=overall&week=draft'>Paul Perkins</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-15551' fp-player-name='Paul Perkins'></a></td>
<td>RB64</td>
<td>8</td>
<td>123</td>
<td>285</td>
<td>176.9</td>
<td>26.8</td>
<td>223.0</td>
<td>&#43;32.0</td>
</tr>
<tr class='mpb-player-11179'><td>192</td>
<td class='player-label'><a href='/nfl/players/brock-osweiler.php?type=overall&week=draft'>Brock Osweiler</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-11179' fp-player-name='Brock Osweiler'></a></td>
<td>QB27</td>
<td>9</td>
<td>130</td>
<td>234</td>
<td>179.3</td>
<td>22.4</td>
<td>175.0</td>
<td>&#45;17.0</td>
</tr>
<tr class='mpb-player-8150'><td>193</td>
<td class='player-label'><a href='/nfl/teams/kansas-city-defense.php'>Kansas City Chiefs</a> <a href='#' class='fp-player-link fp-id-8150' fp-player-name='Kansas City Chiefs'></a></td>
<td>DST7</td>
<td>5</td>
<td>124</td>
<td>209</td>
<td>176.5</td>
<td>17.3</td>
<td>119.0</td>
<td>&#45;74.0</td>
</tr>
<tr class='mpb-player-13975'><td>194</td>
<td class='player-label'><a href='/nfl/players/breshad-perriman.php?type=overall&week=draft'>Breshad Perriman</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-13975' fp-player-name='Breshad Perriman'></a></td>
<td>WR72</td>
<td>8</td>
<td>123</td>
<td>260</td>
<td>179.7</td>
<td>27.1</td>
<td>253.0</td>
<td>&#43;59.0</td>
</tr>
<tr class='mpb-player-9906'><td>195</td>
<td class='player-label'><a href='/nfl/players/kyle-rudolph.php?type=overall&week=draft'>Kyle Rudolph</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-9906' fp-player-name='Kyle Rudolph'></a></td>
<td>TE25</td>
<td>6</td>
<td>134</td>
<td>245</td>
<td>181.6</td>
<td>23.2</td>
<td>247.0</td>
<td>&#43;52.0</td>
</tr>
<tr class='mpb-player-15600'><td>196</td>
<td class='player-label'><a href='/nfl/players/dak-prescott.php?type=overall&week=draft'>Dak Prescott</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-15600' fp-player-name='Dak Prescott'></a></td>
<td>QB28</td>
<td>7</td>
<td>89</td>
<td>267</td>
<td>174.6</td>
<td>35.8</td>
<td>272.0</td>
<td>&#43;76.0</td>
</tr>
<tr class='mpb-player-14439'><td>197</td>
<td class='player-label'><a href='/nfl/players/will-tye.php?type=overall&week=draft'>Will Tye</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-14439' fp-player-name='Will Tye'></a></td>
<td>TE26</td>
<td>8</td>
<td>133</td>
<td>270</td>
<td>183.8</td>
<td>28.9</td>
<td>310.0</td>
<td>&#43;113.0</td>
</tr>
<tr class='mpb-player-8180'><td>198</td>
<td class='player-label'><a href='/nfl/teams/new-england-defense.php'>New England Patriots</a> <a href='#' class='fp-player-link fp-id-8180' fp-player-name='New England Patriots'></a></td>
<td>DST8</td>
<td>9</td>
<td>138</td>
<td>228</td>
<td>183.5</td>
<td>17.3</td>
<td>141.0</td>
<td>&#45;57.0</td>
</tr>
<tr class='mpb-player-13969'><td>199</td>
<td class='player-label'><a href='/nfl/players/nelson-agholor.php?type=overall&week=draft'>Nelson Agholor</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-13969' fp-player-name='Nelson Agholor'></a></td>
<td>WR73</td>
<td>4</td>
<td>102</td>
<td>261</td>
<td>181.4</td>
<td>25.5</td>
<td>246.0</td>
<td>&#43;47.0</td>
</tr>
<tr class='mpb-player-13951'><td>200</td>
<td class='player-label'><a href='/nfl/players/karlos-williams.php?type=overall&week=draft'>Karlos Williams</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-13951' fp-player-name='Karlos Williams'></a></td>
<td>RB65</td>
<td></td>
<td>87</td>
<td>310</td>
<td>171.1</td>
<td>55.3</td>
<td>151.0</td>
<td>&#45;49.0</td>
</tr>
<tr class='mpb-player-11171'><td>201</td>
<td class='player-label'><a href='/nfl/players/shaun-draughn.php?type=overall&week=draft'>Shaun Draughn</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-11171' fp-player-name='Shaun Draughn'></a></td>
<td>RB66</td>
<td>8</td>
<td>115</td>
<td>323</td>
<td>190.0</td>
<td>39.4</td>
<td>330.0</td>
<td>&#43;129.0</td>
</tr>
<tr class='mpb-player-15672'><td>202</td>
<td class='player-label'><a href='/nfl/players/wendell-smallwood.php?type=overall&week=draft'>Wendell Smallwood</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-15672' fp-player-name='Wendell Smallwood'></a></td>
<td>RB67</td>
<td>4</td>
<td>103</td>
<td>258</td>
<td>182.8</td>
<td>29.7</td>
<td>250.0</td>
<td>&#43;48.0</td>
</tr>
<tr class='mpb-player-8170'><td>203</td>
<td class='player-label'><a href='/nfl/teams/minnesota-defense.php'>Minnesota Vikings</a> <a href='#' class='fp-player-link fp-id-8170' fp-player-name='Minnesota Vikings'></a></td>
<td>DST9</td>
<td>6</td>
<td>136</td>
<td>245</td>
<td>189.7</td>
<td>28.3</td>
<td>143.0</td>
<td>&#45;60.0</td>
</tr>
<tr class='mpb-player-11610'><td>204</td>
<td class='player-label'><a href='/nfl/players/robert-woods.php?type=overall&week=draft'>Robert Woods</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-11610' fp-player-name='Robert Woods'></a></td>
<td>WR74</td>
<td>10</td>
<td>142</td>
<td>248</td>
<td>193.2</td>
<td>28.3</td>
<td>282.0</td>
<td>&#43;78.0</td>
</tr>
<tr class='mpb-player-8060'><td>205</td>
<td class='player-label'><a href='/nfl/teams/cincinnati-defense.php'>Cincinnati Bengals</a> <a href='#' class='fp-player-link fp-id-8060' fp-player-name='Cincinnati Bengals'></a></td>
<td>DST10</td>
<td>9</td>
<td>128</td>
<td>229</td>
<td>190.9</td>
<td>26.0</td>
<td>156.0</td>
<td>&#45;49.0</td>
</tr>
<tr class='tier-row static'><td>Tier 11</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-10026'><td>206</td>
<td class='player-label'><a href='/nfl/players/virgil-green.php?type=overall&week=draft'>Virgil Green</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-10026' fp-player-name='Virgil Green'></a></td>
<td>TE27</td>
<td>11</td>
<td>132</td>
<td>351</td>
<td>183.4</td>
<td>39.4</td>
<td>279.0</td>
<td>&#43;73.0</td>
</tr>
<tr class='mpb-player-9699'><td>207</td>
<td class='player-label'><a href='/nfl/players/brandon-lafell.php?type=overall&week=draft'>Brandon LaFell</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-9699' fp-player-name='Brandon LaFell'></a></td>
<td>WR75</td>
<td>9</td>
<td>120</td>
<td>274</td>
<td>191.5</td>
<td>29.9</td>
<td>336.0</td>
<td>&#43;129.0</td>
</tr>
<tr class='mpb-player-12123'><td>208</td>
<td class='player-label'><a href='/nfl/players/davante-adams.php?type=overall&week=draft'>Davante Adams</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-12123' fp-player-name='Davante Adams'></a></td>
<td>WR76</td>
<td>4</td>
<td>103</td>
<td>313</td>
<td>194.8</td>
<td>36.7</td>
<td>227.0</td>
<td>&#43;19.0</td>
</tr>
<tr class='mpb-player-10092'><td>209</td>
<td class='player-label'><a href='/nfl/players/terrelle-pryor.php?type=overall&week=draft'>Terrelle Pryor</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-10092' fp-player-name='Terrelle Pryor'></a></td>
<td>WR77</td>
<td>13</td>
<td>127</td>
<td>328</td>
<td>186.8</td>
<td>34.3</td>
<td>203.0</td>
<td>&#45;6.0</td>
</tr>
<tr class='mpb-player-13942'><td>210</td>
<td class='player-label'><a href='/nfl/players/cameron-artis-payne.php?type=overall&week=draft'>Cameron Artis-Payne</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-13942' fp-player-name='Cameron Artis-Payne'></a></td>
<td>RB68</td>
<td>7</td>
<td>128</td>
<td>294</td>
<td>201.4</td>
<td>35.4</td>
<td>236.0</td>
<td>&#43;26.0</td>
</tr>
<tr class='mpb-player-9353'><td>211</td>
<td class='player-label'><a href='/nfl/players/kenny-britt.php?type=overall&week=draft'>Kenny Britt</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-9353' fp-player-name='Kenny Britt'></a></td>
<td>WR78</td>
<td>8</td>
<td>133</td>
<td>251</td>
<td>193.3</td>
<td>25.7</td>
<td>325.0</td>
<td>&#43;114.0</td>
</tr>
<tr class='mpb-player-8210'><td>212</td>
<td class='player-label'><a href='/nfl/teams/new-york-jets-defense.php'>New York Jets</a> <a href='#' class='fp-player-link fp-id-8210' fp-player-name='New York Jets'></a></td>
<td>DST11</td>
<td>11</td>
<td>155</td>
<td>252</td>
<td>194.0</td>
<td>21.1</td>
<td>166.0</td>
<td>&#45;46.0</td>
</tr>
<tr class='mpb-player-13729'><td>213</td>
<td class='player-label'><a href='/nfl/players/charcandrick-west.php?type=overall&week=draft'>Charcandrick West</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-13729' fp-player-name='Charcandrick West'></a></td>
<td>RB69</td>
<td>5</td>
<td>123</td>
<td>297</td>
<td>193.8</td>
<td>28.4</td>
<td>189.0</td>
<td>&#45;24.0</td>
</tr>
<tr class='mpb-player-13976'><td>214</td>
<td class='player-label'><a href='/nfl/players/jamison-crowder.php?type=overall&week=draft'>Jamison Crowder</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-13976' fp-player-name='Jamison Crowder'></a></td>
<td>WR79</td>
<td>9</td>
<td>134</td>
<td>265</td>
<td>199.2</td>
<td>34.0</td>
<td>312.0</td>
<td>&#43;98.0</td>
</tr>
<tr class='mpb-player-11548'><td>215</td>
<td class='player-label'><a href='/nfl/players/jermaine-kearse.php?type=overall&week=draft'>Jermaine Kearse</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-11548' fp-player-name='Jermaine Kearse'></a></td>
<td>WR80</td>
<td>5</td>
<td>135</td>
<td>289</td>
<td>203.0</td>
<td>33.0</td>
<td>233.0</td>
<td>&#43;18.0</td>
</tr>
<tr class='mpb-player-9573'><td>216</td>
<td class='player-label'><a href='/nfl/players/stephen-gostkowski.php?type=overall&week=draft'>Stephen Gostkowski</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9573' fp-player-name='Stephen Gostkowski'></a></td>
<td>K1</td>
<td>9</td>
<td>135</td>
<td>229</td>
<td>201.8</td>
<td>27.0</td>
<td>93.0</td>
<td>&#45;123.0</td>
</tr>
<tr class='mpb-player-13906'><td>217</td>
<td class='player-label'><a href='/nfl/players/jaelen-strong.php?type=overall&week=draft'>Jaelen Strong</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-13906' fp-player-name='Jaelen Strong'></a></td>
<td>WR81</td>
<td>9</td>
<td>122</td>
<td>253</td>
<td>195.9</td>
<td>27.5</td>
<td>328.0</td>
<td>&#43;111.0</td>
</tr>
<tr class='mpb-player-9680'><td>218</td>
<td class='player-label'><a href='/nfl/players/cj-spiller.php?type=overall&week=draft'>C.J. Spiller</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-9680' fp-player-name='C.J. Spiller'></a></td>
<td>RB70</td>
<td>5</td>
<td>118</td>
<td>335</td>
<td>202.6</td>
<td>40.9</td>
<td>335.0</td>
<td>&#43;117.0</td>
</tr>
<tr class='mpb-player-11289'><td>219</td>
<td class='player-label'><a href='/nfl/players/ronnie-hillman.php?type=overall&week=draft'>Ronnie Hillman</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-11289' fp-player-name='Ronnie Hillman'></a></td>
<td>RB71</td>
<td>11</td>
<td>110</td>
<td>281</td>
<td>196.1</td>
<td>34.1</td>
<td>229.0</td>
<td>&#43;10.0</td>
</tr>
<tr class='mpb-player-14307'><td>220</td>
<td class='player-label'><a href='/nfl/players/eli-rogers.php?type=overall&week=draft'>Eli Rogers</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-14307' fp-player-name='Eli Rogers'></a></td>
<td>WR82</td>
<td>8</td>
<td>120</td>
<td>307</td>
<td>190.8</td>
<td>41.2</td>
<td>314.0</td>
<td>&#43;94.0</td>
</tr>
<tr class='mpb-player-15734'><td>221</td>
<td class='player-label'><a href='/nfl/players/josh-ferguson.php?type=overall&week=draft'>Josh Ferguson</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-15734' fp-player-name='Josh Ferguson'></a></td>
<td>RB72</td>
<td>10</td>
<td>133</td>
<td>282</td>
<td>200.8</td>
<td>31.5</td>
<td>238.0</td>
<td>&#43;17.0</td>
</tr>
<tr class='mpb-player-8030'><td>222</td>
<td class='player-label'><a href='/nfl/teams/buffalo-defense.php'>Buffalo Bills</a> <a href='#' class='fp-player-link fp-id-8030' fp-player-name='Buffalo Bills'></a></td>
<td>DST12</td>
<td>10</td>
<td>141</td>
<td>272</td>
<td>200.3</td>
<td>30.2</td>
<td>222.0</td>
<td>0.0</td>
</tr>
<tr class='mpb-player-9525'><td>223</td>
<td class='player-label'><a href='/nfl/players/reggie-bush.php?type=overall&week=draft'>Reggie Bush</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-9525' fp-player-name='Reggie Bush'></a></td>
<td>RB73</td>
<td>10</td>
<td>111</td>
<td>369</td>
<td>197.5</td>
<td>57.2</td>
<td>271.0</td>
<td>&#43;48.0</td>
</tr>
<tr class='mpb-player-11840'><td>224</td>
<td class='player-label'><a href='/nfl/players/charles-johnson-wr.php?type=overall&week=draft'>Charles Johnson</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-11840' fp-player-name='Charles Johnson'></a></td>
<td>WR83</td>
<td>6</td>
<td>87</td>
<td>317</td>
<td>194.5</td>
<td>44.7</td>
<td>353.0</td>
<td>&#43;129.0</td>
</tr>
<tr class='mpb-player-11662'><td>225</td>
<td class='player-label'><a href='/nfl/players/andre-ellington.php?type=overall&week=draft'>Andre Ellington</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-11662' fp-player-name='Andre Ellington'></a></td>
<td>RB74</td>
<td>9</td>
<td>148</td>
<td>279</td>
<td>203.0</td>
<td>23.5</td>
<td>254.0</td>
<td>&#43;29.0</td>
</tr>
<tr class='mpb-player-11863'><td>226</td>
<td class='player-label'><a href='/nfl/players/benny-cunningham.php?type=overall&week=draft'>Benny Cunningham</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-11863' fp-player-name='Benny Cunningham'></a></td>
<td>RB75</td>
<td>8</td>
<td>153</td>
<td>218</td>
<td>185.6</td>
<td>18.3</td>
<td>337.0</td>
<td>&#43;111.0</td>
</tr>
<tr class='mpb-player-11657'><td>227</td>
<td class='player-label'><a href='/nfl/players/mike-gillislee.php?type=overall&week=draft'>Mike Gillislee</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-11657' fp-player-name='Mike Gillislee'></a></td>
<td>RB76</td>
<td>10</td>
<td>96</td>
<td>355</td>
<td>206.4</td>
<td>48.0</td>
<td>261.0</td>
<td>&#43;34.0</td>
</tr>
<tr class='mpb-player-13470'><td>228</td>
<td class='player-label'><a href='/nfl/players/cameron-brate.php?type=overall&week=draft'>Cameron Brate</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-13470' fp-player-name='Cameron Brate'></a></td>
<td>TE28</td>
<td>6</td>
<td>133</td>
<td>290</td>
<td>203.1</td>
<td>31.2</td>
<td>225.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-9790'><td>229</td>
<td class='player-label'><a href='/nfl/players/victor-cruz.php?type=overall&week=draft'>Victor Cruz</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-9790' fp-player-name='Victor Cruz'></a></td>
<td>WR84</td>
<td>8</td>
<td>146</td>
<td>321</td>
<td>210.4</td>
<td>35.7</td>
<td>165.0</td>
<td>&#45;64.0</td>
</tr>
<tr class='mpb-player-8110'><td>230</td>
<td class='player-label'><a href='/nfl/teams/green-bay-defense.php'>Green Bay Packers</a> <a href='#' class='fp-player-link fp-id-8110' fp-player-name='Green Bay Packers'></a></td>
<td>DST13</td>
<td>4</td>
<td>129</td>
<td>255</td>
<td>199.3</td>
<td>36.3</td>
<td>182.0</td>
<td>&#45;48.0</td>
</tr>
<tr class='mpb-player-14185'><td>231</td>
<td class='player-label'><a href='/nfl/players/zach-zenner.php?type=overall&week=draft'>Zach Zenner</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-14185' fp-player-name='Zach Zenner'></a></td>
<td>RB77</td>
<td>10</td>
<td>125</td>
<td>298</td>
<td>209.0</td>
<td>32.3</td>
<td>344.0</td>
<td>&#43;113.0</td>
</tr>
<tr class='mpb-player-16154'><td>232</td>
<td class='player-label'><a href='/nfl/players/robert-kelley.php?type=overall&week=draft'>Robert Kelley</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-16154' fp-player-name='Robert Kelley'></a></td>
<td>RB78</td>
<td>9</td>
<td>138</td>
<td>281</td>
<td>185.1</td>
<td>41.3</td>
<td>1,053.0</td>
<td>&#43;821.0</td>
</tr>
<tr class='mpb-player-9678'><td>233</td>
<td class='player-label'><a href='/nfl/players/sam-bradford.php?type=overall&week=draft'>Sam Bradford</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-9678' fp-player-name='Sam Bradford'></a></td>
<td>QB29</td>
<td>4</td>
<td>137</td>
<td>268</td>
<td>203.4</td>
<td>25.6</td>
<td>349.0</td>
<td>&#43;116.0</td>
</tr>
<tr class='mpb-player-12233'><td>234</td>
<td class='player-label'><a href='/nfl/players/richard-rodgers.php?type=overall&week=draft'>Richard Rodgers</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-12233' fp-player-name='Richard Rodgers'></a></td>
<td>TE29</td>
<td>4</td>
<td>155</td>
<td>292</td>
<td>206.4</td>
<td>27.8</td>
<td>210.0</td>
<td>&#45;24.0</td>
</tr>
<tr class='mpb-player-15637'><td>235</td>
<td class='player-label'><a href='/nfl/players/kenyan-drake.php?type=overall&week=draft'>Kenyan Drake</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-15637' fp-player-name='Kenyan Drake'></a></td>
<td>RB79</td>
<td>8</td>
<td>147</td>
<td>384</td>
<td>208.8</td>
<td>40.0</td>
<td>220.0</td>
<td>&#45;15.0</td>
</tr>
<tr class='mpb-player-11202'><td>236</td>
<td class='player-label'><a href='/nfl/players/reuben-randle.php?type=overall&week=draft'>Rueben Randle</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-11202' fp-player-name='Rueben Randle'></a></td>
<td>WR85</td>
<td></td>
<td>143</td>
<td>400</td>
<td>208.2</td>
<td>45.7</td>
<td>297.0</td>
<td>&#43;61.0</td>
</tr>
<tr class='mpb-player-8240'><td>237</td>
<td class='player-label'><a href='/nfl/teams/pittsburgh-defense.php'>Pittsburgh Steelers</a> <a href='#' class='fp-player-link fp-id-8240' fp-player-name='Pittsburgh Steelers'></a></td>
<td>DST14</td>
<td>8</td>
<td>147</td>
<td>288</td>
<td>199.8</td>
<td>46.9</td>
<td>173.0</td>
<td>&#45;64.0</td>
</tr>
<tr class='mpb-player-8220'><td>238</td>
<td class='player-label'><a href='/nfl/teams/oakland-defense.php'>Oakland Raiders</a> <a href='#' class='fp-player-link fp-id-8220' fp-player-name='Oakland Raiders'></a></td>
<td>DST15</td>
<td>10</td>
<td>150</td>
<td>243</td>
<td>197.6</td>
<td>29.3</td>
<td>195.0</td>
<td>&#45;43.0</td>
</tr>
<tr class='mpb-player-13959'><td>239</td>
<td class='player-label'><a href='/nfl/players/jesse-james.php?type=overall&week=draft'>Jesse James</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-13959' fp-player-name='Jesse James'></a></td>
<td>TE30</td>
<td>8</td>
<td>154</td>
<td>293</td>
<td>203.8</td>
<td>36.8</td>
<td>273.0</td>
<td>&#43;34.0</td>
</tr>
<tr class='mpb-player-11660'><td>240</td>
<td class='player-label'><a href='/nfl/players/kenjon-barner.php?type=overall&week=draft'>Kenjon Barner</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-11660' fp-player-name='Kenjon Barner'></a></td>
<td>RB80</td>
<td>4</td>
<td>140</td>
<td>240</td>
<td>184.0</td>
<td>29.7</td>
<td>287.0</td>
<td>&#43;47.0</td>
</tr>
<tr class='mpb-player-15656'><td>241</td>
<td class='player-label'><a href='/nfl/players/malcolm-mitchell.php?type=overall&week=draft'>Malcolm Mitchell</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-15656' fp-player-name='Malcolm Mitchell'></a></td>
<td>WR86</td>
<td>9</td>
<td>97</td>
<td>375</td>
<td>203.3</td>
<td>72.3</td>
<td>322.0</td>
<td>&#43;81.0</td>
</tr>
<tr class='mpb-player-15836'><td>242</td>
<td class='player-label'><a href='/nfl/players/keith-marshall.php?type=overall&week=draft'>Keith Marshall</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-15836' fp-player-name='Keith Marshall'></a></td>
<td>RB81</td>
<td>9</td>
<td>147</td>
<td>266</td>
<td>207.8</td>
<td>30.3</td>
<td>342.0</td>
<td>&#43;100.0</td>
</tr>
<tr class='mpb-player-15914'><td>243</td>
<td class='player-label'><a href='/nfl/players/mike-thomas-wr.php?type=overall&week=draft'>Mike Thomas</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-15914' fp-player-name='Mike Thomas'></a></td>
<td>WR87</td>
<td>8</td>
<td>118</td>
<td>213</td>
<td>167.0</td>
<td>41.4</td>
<td></td>
<td></td>
</tr>
<tr class='mpb-player-12100'><td>244</td>
<td class='player-label'><a href='/nfl/players/kadeem-carey.php?type=overall&week=draft'>Ka'Deem Carey</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-12100' fp-player-name='Ka'Deem Carey'></a></td>
<td>RB82</td>
<td>9</td>
<td>149</td>
<td>289</td>
<td>215.8</td>
<td>31.0</td>
<td>332.0</td>
<td>&#43;88.0</td>
</tr>
<tr class='mpb-player-14151'><td>245</td>
<td class='player-label'><a href='/nfl/players/chris-conley.php?type=overall&week=draft'>Chris Conley</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-14151' fp-player-name='Chris Conley'></a></td>
<td>WR88</td>
<td>5</td>
<td>157</td>
<td>302</td>
<td>207.8</td>
<td>33.6</td>
<td>258.0</td>
<td>&#43;13.0</td>
</tr>
<tr class='mpb-player-9156'><td>246</td>
<td class='player-label'><a href='/nfl/players/darrius-heyward-bey.php?type=overall&week=draft'>Darrius Heyward-Bey</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-9156' fp-player-name='Darrius Heyward-Bey'></a></td>
<td>WR89</td>
<td>8</td>
<td>140</td>
<td>390</td>
<td>209.9</td>
<td>45.9</td>
<td>309.0</td>
<td>&#43;63.0</td>
</tr>
<tr class='mpb-player-9581'><td>247</td>
<td class='player-label'><a href='/nfl/players/steven-hauschka.php?type=overall&week=draft'>Steven Hauschka</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-9581' fp-player-name='Steven Hauschka'></a></td>
<td>K2</td>
<td>5</td>
<td>149</td>
<td>247</td>
<td>202.2</td>
<td>33.8</td>
<td>116.0</td>
<td>&#45;131.0</td>
</tr>
<tr class='tier-row static'><td>Tier 12</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-10970'><td>248</td>
<td class='player-label'><a href='/nfl/players/dan-bailey.php?type=overall&week=draft'>Dan Bailey</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-10970' fp-player-name='Dan Bailey'></a></td>
<td>K3</td>
<td>7</td>
<td>144</td>
<td>291</td>
<td>206.6</td>
<td>50.6</td>
<td>152.0</td>
<td>&#45;96.0</td>
</tr>
<tr class='mpb-player-11465'><td>249</td>
<td class='player-label'><a href='/nfl/players/justin-tucker.php?type=overall&week=draft'>Justin Tucker</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-11465' fp-player-name='Justin Tucker'></a></td>
<td>K4</td>
<td>8</td>
<td>152</td>
<td>280</td>
<td>203.3</td>
<td>37.4</td>
<td>130.0</td>
<td>&#45;119.0</td>
</tr>
<tr class='mpb-player-9858'><td>250</td>
<td class='player-label'><a href='/nfl/players/blaine-gabbert.php?type=overall&week=draft'>Blaine Gabbert</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-9858' fp-player-name='Blaine Gabbert'></a></td>
<td>QB30</td>
<td>8</td>
<td>138</td>
<td>286</td>
<td>216.8</td>
<td>30.6</td>
<td>315.0</td>
<td>&#43;65.0</td>
</tr>
<tr class='mpb-player-13840'><td>251</td>
<td class='player-label'><a href='/nfl/players/seth-roberts.php?type=overall&week=draft'>Seth Roberts</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-13840' fp-player-name='Seth Roberts'></a></td>
<td>WR90</td>
<td>10</td>
<td>145</td>
<td>263</td>
<td>208.0</td>
<td>23.4</td>
<td>301.0</td>
<td>&#43;50.0</td>
</tr>
<tr class='mpb-player-15623'><td>252</td>
<td class='player-label'><a href='/nfl/players/tyler-higbee.php?type=overall&week=draft'>Tyler Higbee</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-15623' fp-player-name='Tyler Higbee'></a></td>
<td>TE31</td>
<td>8</td>
<td>133</td>
<td>306</td>
<td>208.6</td>
<td>34.0</td>
<td>360.0</td>
<td>&#43;108.0</td>
</tr>
<tr class='mpb-player-15661'><td>253</td>
<td class='player-label'><a href='/nfl/players/tyler-ervin.php?type=overall&week=draft'>Tyler Ervin</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-15661' fp-player-name='Tyler Ervin'></a></td>
<td>RB83</td>
<td>9</td>
<td>162</td>
<td>313</td>
<td>217.3</td>
<td>32.5</td>
<td>317.0</td>
<td>&#43;64.0</td>
</tr>
<tr class='mpb-player-9016'><td>254</td>
<td class='player-label'><a href='/nfl/players/andre-johnson.php?type=overall&week=draft'>Andre Johnson</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-9016' fp-player-name='Andre Johnson'></a></td>
<td>WR91</td>
<td>13</td>
<td>88</td>
<td>324</td>
<td>209.0</td>
<td>66.1</td>
<td>268.0</td>
<td>&#43;14.0</td>
</tr>
<tr class='mpb-player-12318'><td>255</td>
<td class='player-label'><a href='/nfl/players/jeff-janis.php?type=overall&week=draft'>Jeff Janis</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-12318' fp-player-name='Jeff Janis'></a></td>
<td>WR92</td>
<td>4</td>
<td>174</td>
<td>396</td>
<td>218.5</td>
<td>42.8</td>
<td>307.0</td>
<td>&#43;52.0</td>
</tr>
<tr class='mpb-player-9004'><td>256</td>
<td class='player-label'><a href='/nfl/players/adam-vinatieri.php?type=overall&week=draft'>Adam Vinatieri</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-9004' fp-player-name='Adam Vinatieri'></a></td>
<td>K5</td>
<td>10</td>
<td>155</td>
<td>286</td>
<td>211.4</td>
<td>47.9</td>
<td>177.0</td>
<td>&#45;79.0</td>
</tr>
<tr class='mpb-player-9433'><td>257</td>
<td class='player-label'><a href='/nfl/players/mason-crosby.php?type=overall&week=draft'>Mason Crosby</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-9433' fp-player-name='Mason Crosby'></a></td>
<td>K6</td>
<td>4</td>
<td>149</td>
<td>277</td>
<td>209.6</td>
<td>43.3</td>
<td>158.0</td>
<td>&#45;99.0</td>
</tr>
<tr class='mpb-player-9146'><td>258</td>
<td class='player-label'><a href='/nfl/players/danny-amendola.php?type=overall&week=draft'>Danny Amendola</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-9146' fp-player-name='Danny Amendola'></a></td>
<td>WR93</td>
<td>9</td>
<td>140</td>
<td>296</td>
<td>216.2</td>
<td>26.1</td>
<td>208.0</td>
<td>&#45;50.0</td>
</tr>
<tr class='mpb-player-13919'><td>259</td>
<td class='player-label'><a href='/nfl/players/maxx-williams.php?type=overall&week=draft'>Maxx Williams</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-13919' fp-player-name='Maxx Williams'></a></td>
<td>TE32</td>
<td>8</td>
<td>168</td>
<td>311</td>
<td>216.0</td>
<td>30.7</td>
<td>714.0</td>
<td>&#43;455.0</td>
</tr>
<tr class='mpb-player-15611'><td>260</td>
<td class='player-label'><a href='/nfl/players/jonathan-williams.php?type=overall&week=draft'>Jonathan Williams</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-15611' fp-player-name='Jonathan Williams'></a></td>
<td>RB84</td>
<td>10</td>
<td>133</td>
<td>406</td>
<td>224.3</td>
<td>68.7</td>
<td>230.0</td>
<td>&#45;30.0</td>
</tr>
<tr class='mpb-player-13606'><td>261</td>
<td class='player-label'><a href='/nfl/players/chandler-catanzaro.php?type=overall&week=draft'>Chandler Catanzaro</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-13606' fp-player-name='Chandler Catanzaro'></a></td>
<td>K7</td>
<td>9</td>
<td>151</td>
<td>292</td>
<td>211.0</td>
<td>43.9</td>
<td>162.0</td>
<td>&#45;99.0</td>
</tr>
<tr class='mpb-player-11909'><td>262</td>
<td class='player-label'><a href='/nfl/players/khiry-robinson.php?type=overall&week=draft'>Khiry Robinson</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-11909' fp-player-name='Khiry Robinson'></a></td>
<td>RB85</td>
<td>11</td>
<td>160</td>
<td>278</td>
<td>211.9</td>
<td>29.3</td>
<td>321.0</td>
<td>&#43;59.0</td>
</tr>
<tr class='mpb-player-15501'><td>263</td>
<td class='player-label'><a href='/nfl/players/jared-goff.php?type=overall&week=draft'>Jared Goff</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-15501' fp-player-name='Jared Goff'></a></td>
<td>QB31</td>
<td>8</td>
<td>158</td>
<td>320</td>
<td>217.8</td>
<td>38.6</td>
<td>212.0</td>
<td>&#45;51.0</td>
</tr>
<tr class='mpb-player-12109'><td>264</td>
<td class='player-label'><a href='/nfl/players/tyler-gaffney.php?type=overall&week=draft'>Tyler Gaffney</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-12109' fp-player-name='Tyler Gaffney'></a></td>
<td>RB86</td>
<td>9</td>
<td>142</td>
<td>264</td>
<td>196.8</td>
<td>34.8</td>
<td>239.0</td>
<td>&#45;25.0</td>
</tr>
<tr class='mpb-player-8230'><td>265</td>
<td class='player-label'><a href='/nfl/teams/philadelphia-defense.php'>Philadelphia Eagles</a> <a href='#' class='fp-player-link fp-id-8230' fp-player-name='Philadelphia Eagles'></a></td>
<td>DST16</td>
<td>4</td>
<td>166</td>
<td>297</td>
<td>218.8</td>
<td>39.4</td>
<td>217.0</td>
<td>&#45;48.0</td>
</tr>
<tr class='mpb-player-9232'><td>266</td>
<td class='player-label'><a href='/nfl/players/graham-gano.php?type=overall&week=draft'>Graham Gano</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9232' fp-player-name='Graham Gano'></a></td>
<td>K8</td>
<td>7</td>
<td>157</td>
<td>298</td>
<td>212.4</td>
<td>48.0</td>
<td>126.0</td>
<td>&#45;140.0</td>
</tr>
<tr class='mpb-player-13970'><td>267</td>
<td class='player-label'><a href='/nfl/players/justin-hardy.php?type=overall&week=draft'>Justin Hardy</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-13970' fp-player-name='Justin Hardy'></a></td>
<td>WR94</td>
<td>11</td>
<td>142</td>
<td>298</td>
<td>219.4</td>
<td>30.1</td>
<td>286.0</td>
<td>&#43;19.0</td>
</tr>
<tr class='mpb-player-11349'><td>268</td>
<td class='player-label'><a href='/nfl/players/blair-walsh.php?type=overall&week=draft'>Blair Walsh</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-11349' fp-player-name='Blair Walsh'></a></td>
<td>K9</td>
<td>6</td>
<td>158</td>
<td>297</td>
<td>212.0</td>
<td>46.6</td>
<td>161.0</td>
<td>&#45;107.0</td>
</tr>
<tr class='mpb-player-9208'><td>269</td>
<td class='player-label'><a href='/nfl/players/eddie-royal.php?type=overall&week=draft'>Eddie Royal</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9208' fp-player-name='Eddie Royal'></a></td>
<td>WR95</td>
<td>9</td>
<td>142</td>
<td>274</td>
<td>229.1</td>
<td>29.4</td>
<td>382.0</td>
<td>&#43;113.0</td>
</tr>
<tr class='mpb-player-11441'><td>270</td>
<td class='player-label'><a href='/nfl/players/lance-dunbar.php?type=overall&week=draft'>Lance Dunbar</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-11441' fp-player-name='Lance Dunbar'></a></td>
<td>RB87</td>
<td>7</td>
<td>115</td>
<td>284</td>
<td>221.0</td>
<td>32.4</td>
<td>306.0</td>
<td>&#43;36.0</td>
</tr>
<tr class='mpb-player-11191'><td>271</td>
<td class='player-label'><a href='/nfl/players/robert-turbin.php?type=overall&week=draft'>Robert Turbin</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-11191' fp-player-name='Robert Turbin'></a></td>
<td>RB88</td>
<td>10</td>
<td>152</td>
<td>292</td>
<td>216.2</td>
<td>32.7</td>
<td>339.0</td>
<td>&#43;68.0</td>
</tr>
<tr class='mpb-player-9264'><td>272</td>
<td class='player-label'><a href='/nfl/players/james-jones.php?type=overall&week=draft'>James Jones</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-9264' fp-player-name='James Jones'></a></td>
<td>WR96</td>
<td>11</td>
<td>135</td>
<td>327</td>
<td>216.2</td>
<td>59.1</td>
<td>232.0</td>
<td>&#45;40.0</td>
</tr>
<tr class='mpb-player-13274'><td>273</td>
<td class='player-label'><a href='/nfl/players/brandon-mcmanus.php?type=overall&week=draft'>Brandon McManus</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-13274' fp-player-name='Brandon McManus'></a></td>
<td>K10</td>
<td>11</td>
<td>157</td>
<td>290</td>
<td>232.0</td>
<td>48.9</td>
<td>184.0</td>
<td>&#45;89.0</td>
</tr>
<tr class='mpb-player-9443'><td>274</td>
<td class='player-label'><a href='/nfl/players/matt-prater.php?type=overall&week=draft'>Matt Prater</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-9443' fp-player-name='Matt Prater'></a></td>
<td>K11</td>
<td>10</td>
<td>160</td>
<td>266</td>
<td>207.6</td>
<td>43.6</td>
<td>251.0</td>
<td>&#45;23.0</td>
</tr>
<tr class='mpb-player-9563'><td>275</td>
<td class='player-label'><a href='/nfl/players/shaun-hill.php?type=overall&week=draft'>Shaun Hill</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-9563' fp-player-name='Shaun Hill'></a></td>
<td>QB32</td>
<td>6</td>
<td>153</td>
<td>232</td>
<td>188.0</td>
<td>28.3</td>
<td>407.0</td>
<td>&#43;132.0</td>
</tr>
<tr class='mpb-player-9252'><td>276</td>
<td class='player-label'><a href='/nfl/players/jacob-tamme.php?type=overall&week=draft'>Jacob Tamme</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-9252' fp-player-name='Jacob Tamme'></a></td>
<td>TE33</td>
<td>11</td>
<td>169</td>
<td>270</td>
<td>217.4</td>
<td>26.7</td>
<td>269.0</td>
<td>&#45;7.0</td>
</tr>
<tr class='mpb-player-14142'><td>277</td>
<td class='player-label'><a href='/nfl/players/trevor-siemian.php?type=overall&week=draft'>Trevor Siemian</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-14142' fp-player-name='Trevor Siemian'></a></td>
<td>QB33</td>
<td>11</td>
<td>152</td>
<td>269</td>
<td>210.7</td>
<td>28.8</td>
<td>765.0</td>
<td>&#43;488.0</td>
</tr>
<tr class='mpb-player-12202'><td>278</td>
<td class='player-label'><a href='/nfl/players/brandon-coleman.php?type=overall&week=draft'>Brandon Coleman</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-12202' fp-player-name='Brandon Coleman'></a></td>
<td>WR97</td>
<td>5</td>
<td>145</td>
<td>312</td>
<td>230.1</td>
<td>35.9</td>
<td>324.0</td>
<td>&#43;46.0</td>
</tr>
<tr class='mpb-player-15581'><td>279</td>
<td class='player-label'><a href='/nfl/players/austin-hooper.php?type=overall&week=draft'>Austin Hooper</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-15581' fp-player-name='Austin Hooper'></a></td>
<td>TE34</td>
<td>11</td>
<td>152</td>
<td>326</td>
<td>219.3</td>
<td>30.2</td>
<td>262.0</td>
<td>&#45;17.0</td>
</tr>
<tr class='mpb-player-9140'><td>280</td>
<td class='player-label'><a href='/nfl/players/dan-carpenter.php?type=overall&week=draft'>Dan Carpenter</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-9140' fp-player-name='Dan Carpenter'></a></td>
<td>K12</td>
<td>10</td>
<td>161</td>
<td>186</td>
<td>176.3</td>
<td>11.0</td>
<td>343.0</td>
<td>&#43;63.0</td>
</tr>
<tr class='mpb-player-9912'><td>281</td>
<td class='player-label'><a href='/nfl/players/lance-kendricks.php?type=overall&week=draft'>Lance Kendricks</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-9912' fp-player-name='Lance Kendricks'></a></td>
<td>TE35</td>
<td>8</td>
<td>174</td>
<td>300</td>
<td>228.7</td>
<td>29.9</td>
<td>441.0</td>
<td>&#43;160.0</td>
</tr>
<tr class='mpb-player-14324'><td>282</td>
<td class='player-label'><a href='/nfl/players/tyrell-williams.php?type=overall&week=draft'>Tyrell Williams</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-14324' fp-player-name='Tyrell Williams'></a></td>
<td>WR98</td>
<td>11</td>
<td>177</td>
<td>304</td>
<td>211.6</td>
<td>36.5</td>
<td>807.0</td>
<td>&#43;525.0</td>
</tr>
<tr class='mpb-player-8200'><td>283</td>
<td class='player-label'><a href='/nfl/teams/new-york-giants-defense.php'>New York Giants</a> <a href='#' class='fp-player-link fp-id-8200' fp-player-name='New York Giants'></a></td>
<td>DST17</td>
<td>8</td>
<td>162</td>
<td>279</td>
<td>209.6</td>
<td>41.4</td>
<td>243.0</td>
<td>&#45;40.0</td>
</tr>
<tr class='mpb-player-15557'><td>284</td>
<td class='player-label'><a href='/nfl/players/pharoh-cooper.php?type=overall&week=draft'>Pharoh Cooper</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-15557' fp-player-name='Pharoh Cooper'></a></td>
<td>WR99</td>
<td>8</td>
<td>170</td>
<td>315</td>
<td>219.2</td>
<td>26.9</td>
<td>356.0</td>
<td>&#43;72.0</td>
</tr>
<tr class='mpb-player-8140'><td>285</td>
<td class='player-label'><a href='/nfl/teams/jacksonville-defense.php'>Jacksonville Jaguars</a> <a href='#' class='fp-player-link fp-id-8140' fp-player-name='Jacksonville Jaguars'></a></td>
<td>DST18</td>
<td>5</td>
<td>169</td>
<td>278</td>
<td>222.1</td>
<td>32.4</td>
<td>237.0</td>
<td>&#45;48.0</td>
</tr>
<tr class='mpb-player-11212'><td>286</td>
<td class='player-label'><a href='/nfl/players/brian-quick.php?type=overall&week=draft'>Brian Quick</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-11212' fp-player-name='Brian Quick'></a></td>
<td>WR100</td>
<td>8</td>
<td>145</td>
<td>383</td>
<td>236.7</td>
<td>55.3</td>
<td>479.0</td>
<td>&#43;193.0</td>
</tr>
<tr class='mpb-player-12144'><td>287</td>
<td class='player-label'><a href='/nfl/players/jace-amaro.php?type=overall&week=draft'>Jace Amaro</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-12144' fp-player-name='Jace Amaro'></a></td>
<td>TE36</td>
<td>11</td>
<td>177</td>
<td>289</td>
<td>226.9</td>
<td>28.8</td>
<td>607.0</td>
<td>&#43;320.0</td>
</tr>
<tr class='mpb-player-15597'><td>288</td>
<td class='player-label'><a href='/nfl/players/braxton-miller.php?type=overall&week=draft'>Braxton Miller</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-15597' fp-player-name='Braxton Miller'></a></td>
<td>WR101</td>
<td>9</td>
<td>172</td>
<td>368</td>
<td>236.0</td>
<td>46.8</td>
<td>274.0</td>
<td>&#45;14.0</td>
</tr>
<tr class='mpb-player-9508'><td>289</td>
<td class='player-label'><a href='/nfl/players/phil-dawson.php?type=overall&week=draft'>Phil Dawson</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-9508' fp-player-name='Phil Dawson'></a></td>
<td>K13</td>
<td>8</td>
<td>169</td>
<td>184</td>
<td>176.5</td>
<td>7.5</td>
<td>351.0</td>
<td>&#43;62.0</td>
</tr>
<tr class='mpb-player-12134'><td>290</td>
<td class='player-label'><a href='/nfl/players/tj-jones.php?type=overall&week=draft'>TJ Jones</a> <small class='grey'>DET</small> <a href='#' class='fp-player-link fp-id-12134' fp-player-name='TJ Jones'></a></td>
<td>WR102</td>
<td>10</td>
<td>153</td>
<td>392</td>
<td>264.8</td>
<td>85.1</td>
<td>277.0</td>
<td>&#45;13.0</td>
</tr>
<tr class='mpb-player-8160'><td>291</td>
<td class='player-label'><a href='/nfl/teams/miami-defense.php'>Miami Dolphins</a> <a href='#' class='fp-player-link fp-id-8160' fp-player-name='Miami Dolphins'></a></td>
<td>DST19</td>
<td>8</td>
<td>161</td>
<td>304</td>
<td>234.4</td>
<td>51.9</td>
<td>240.0</td>
<td>&#45;51.0</td>
</tr>
<tr class='mpb-player-9891'><td>292</td>
<td class='player-label'><a href='/nfl/players/colin-kaepernick.php?type=overall&week=draft'>Colin Kaepernick</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-9891' fp-player-name='Colin Kaepernick'></a></td>
<td>QB34</td>
<td>8</td>
<td>165</td>
<td>314</td>
<td>231.1</td>
<td>37.2</td>
<td>347.0</td>
<td>&#43;55.0</td>
</tr>
<tr class='mpb-player-13105'><td>293</td>
<td class='player-label'><a href='/nfl/players/dontrelle-inman.php?type=overall&week=draft'>Dontrelle Inman</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-13105' fp-player-name='Dontrelle Inman'></a></td>
<td>WR103</td>
<td>11</td>
<td>156</td>
<td>320</td>
<td>238.0</td>
<td>82.0</td>
<td>308.0</td>
<td>&#43;15.0</td>
</tr>
<tr class='mpb-player-13029'><td>294</td>
<td class='player-label'><a href='/nfl/players/chris-boswell.php?type=overall&week=draft'>Chris Boswell</a> <small class='grey'>PIT</small> <a href='#' class='fp-player-link fp-id-13029' fp-player-name='Chris Boswell'></a></td>
<td>K14</td>
<td>8</td>
<td>166</td>
<td>301</td>
<td>228.3</td>
<td>46.1</td>
<td>153.0</td>
<td>&#45;141.0</td>
</tr>
<tr class='mpb-player-14327'><td>295</td>
<td class='player-label'><a href='/nfl/players/josh-lambo.php?type=overall&week=draft'>Josh Lambo</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-14327' fp-player-name='Josh Lambo'></a></td>
<td>K15</td>
<td>11</td>
<td>179</td>
<td>180</td>
<td>179.5</td>
<td>0.5</td>
<td>345.0</td>
<td>&#43;50.0</td>
</tr>
<tr class='mpb-player-11459'><td>296</td>
<td class='player-label'><a href='/nfl/players/cole-beasley.php?type=overall&week=draft'>Cole Beasley</a> <small class='grey'>DAL</small> <a href='#' class='fp-player-link fp-id-11459' fp-player-name='Cole Beasley'></a></td>
<td>WR104</td>
<td>7</td>
<td>181</td>
<td>280</td>
<td>225.6</td>
<td>28.1</td>
<td>320.0</td>
<td>&#43;24.0</td>
</tr>
<tr class='mpb-player-12208'><td>297</td>
<td class='player-label'><a href='/nfl/players/jimmy-garoppolo.php?type=overall&week=draft'>Jimmy Garoppolo</a> <small class='grey'>NE</small> <a href='#' class='fp-player-link fp-id-12208' fp-player-name='Jimmy Garoppolo'></a></td>
<td>QB35</td>
<td>9</td>
<td>170</td>
<td>267</td>
<td>221.6</td>
<td>31.2</td>
<td>270.0</td>
<td>&#45;27.0</td>
</tr>
<tr class='mpb-player-10081'><td>298</td>
<td class='player-label'><a href='/nfl/players/kai-forbath.php?type=overall&week=draft'>Kai Forbath</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-10081' fp-player-name='Kai Forbath'></a></td>
<td>K16</td>
<td>5</td>
<td>163</td>
<td>212</td>
<td>187.5</td>
<td>24.5</td>
<td>334.0</td>
<td>&#43;36.0</td>
</tr>
<tr class='mpb-player-9077'><td>299</td>
<td class='player-label'><a href='/nfl/players/brian-hartline.php?type=overall&week=draft'>Brian Hartline</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-9077' fp-player-name='Brian Hartline'></a></td>
<td>WR105</td>
<td></td>
<td>165</td>
<td>245</td>
<td>222.3</td>
<td>33.3</td>
<td>367.0</td>
<td>&#43;68.0</td>
</tr>
<tr class='mpb-player-9488'><td>300</td>
<td class='player-label'><a href='/nfl/players/nate-washington.php?type=overall&week=draft'>Nate Washington</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-9488' fp-player-name='Nate Washington'></a></td>
<td>WR106</td>
<td></td>
<td>165</td>
<td>245</td>
<td>220.7</td>
<td>21.0</td>
<td>326.0</td>
<td>&#43;26.0</td>
</tr>
<tr class='mpb-player-9474'><td>301</td>
<td class='player-label'><a href='/nfl/players/mike-nugent.php?type=overall&week=draft'>Mike Nugent</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-9474' fp-player-name='Mike Nugent'></a></td>
<td>K17</td>
<td>9</td>
<td>165</td>
<td>223</td>
<td>194.0</td>
<td>29.0</td>
<td>228.0</td>
<td>&#45;73.0</td>
</tr>
<tr class='mpb-player-12106'><td>302</td>
<td class='player-label'><a href='/nfl/players/andre-williams.php?type=overall&week=draft'>Andre Williams</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-12106' fp-player-name='Andre Williams'></a></td>
<td>RB89</td>
<td>8</td>
<td>175</td>
<td>338</td>
<td>244.0</td>
<td>42.9</td>
<td>294.0</td>
<td>&#45;8.0</td>
</tr>
<tr class='mpb-player-11345'><td>303</td>
<td class='player-label'><a href='/nfl/players/greg-zuerlein.php?type=overall&week=draft'>Greg Zuerlein</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-11345' fp-player-name='Greg Zuerlein'></a></td>
<td>K18</td>
<td>8</td>
<td>171</td>
<td>196</td>
<td>183.5</td>
<td>12.5</td>
<td>256.0</td>
<td>&#45;47.0</td>
</tr>
<tr class='mpb-player-12234'><td>304</td>
<td class='player-label'><a href='/nfl/players/crockett-gillmore.php?type=overall&week=draft'>Crockett Gillmore</a> <small class='grey'>BAL</small> <a href='#' class='fp-player-link fp-id-12234' fp-player-name='Crockett Gillmore'></a></td>
<td>TE37</td>
<td>8</td>
<td>177</td>
<td>342</td>
<td>235.0</td>
<td>49.1</td>
<td>619.0</td>
<td>&#43;315.0</td>
</tr>
<tr class='mpb-player-9434'><td>305</td>
<td class='player-label'><a href='/nfl/players/matt-bryant.php?type=overall&week=draft'>Matt Bryant</a> <small class='grey'>ATL</small> <a href='#' class='fp-player-link fp-id-9434' fp-player-name='Matt Bryant'></a></td>
<td>K19</td>
<td>11</td>
<td>168</td>
<td>287</td>
<td>250.3</td>
<td>48.8</td>
<td>350.0</td>
<td>&#43;45.0</td>
</tr>
<tr class='mpb-player-15607'><td>306</td>
<td class='player-label'><a href='/nfl/players/Leonte_Carroo.php?type=overall&week=draft'>Leonte Carroo</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-15607' fp-player-name='Leonte Carroo'></a></td>
<td>WR107</td>
<td>8</td>
<td>186</td>
<td>303</td>
<td>220.8</td>
<td>34.5</td>
<td>263.0</td>
<td>&#45;43.0</td>
</tr>
<tr class='tier-row static'><td>Tier 13</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-13731'><td>307</td>
<td class='player-label'><a href='/nfl/players/cairo-santos.php?type=overall&week=draft'>Cairo Santos</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-13731' fp-player-name='Cairo Santos'></a></td>
<td>K20</td>
<td>5</td>
<td>178</td>
<td>308</td>
<td>233.1</td>
<td>38.8</td>
<td>191.0</td>
<td>&#45;116.0</td>
</tr>
<tr class='mpb-player-9662'><td>308</td>
<td class='player-label'><a href='/nfl/players/nick-novak.php?type=overall&week=draft'>Nick Novak</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-9662' fp-player-name='Nick Novak'></a></td>
<td>K21</td>
<td>9</td>
<td>173</td>
<td>288</td>
<td>254.5</td>
<td>47.7</td>
<td>331.0</td>
<td>&#43;23.0</td>
</tr>
<tr class='mpb-player-13977'><td>309</td>
<td class='player-label'><a href='/nfl/players/ty-montgomery.php?type=overall&week=draft'>Ty Montgomery</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-13977' fp-player-name='Ty Montgomery'></a></td>
<td>WR108</td>
<td>4</td>
<td>174</td>
<td>353</td>
<td>250.1</td>
<td>50.1</td>
<td>278.0</td>
<td>&#45;31.0</td>
</tr>
<tr class='mpb-player-12120'><td>310</td>
<td class='player-label'><a href='/nfl/players/marqise-lee.php?type=overall&week=draft'>Marqise Lee</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-12120' fp-player-name='Marqise Lee'></a></td>
<td>WR109</td>
<td>5</td>
<td>174</td>
<td>294</td>
<td>246.8</td>
<td>44.3</td>
<td>358.0</td>
<td>&#43;48.0</td>
</tr>
<tr class='mpb-player-12282'><td>311</td>
<td class='player-label'><a href='/nfl/players/alfred-blue.php?type=overall&week=draft'>Alfred Blue</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-12282' fp-player-name='Alfred Blue'></a></td>
<td>RB90</td>
<td>9</td>
<td>190</td>
<td>300</td>
<td>237.0</td>
<td>36.6</td>
<td>303.0</td>
<td>&#45;8.0</td>
</tr>
<tr class='mpb-player-11818'><td>312</td>
<td class='player-label'><a href='/nfl/players/dustin-hopkins.php?type=overall&week=draft'>Dustin Hopkins</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-11818' fp-player-name='Dustin Hopkins'></a></td>
<td>K22</td>
<td>9</td>
<td>175</td>
<td>250</td>
<td>212.5</td>
<td>37.5</td>
<td>357.0</td>
<td>&#43;45.0</td>
</tr>
<tr class='mpb-player-9560'><td>313</td>
<td class='player-label'><a href='/nfl/players/sebastian-janikowski.php?type=overall&week=draft'>Sebastian Janikowski</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-9560' fp-player-name='Sebastian Janikowski'></a></td>
<td>K23</td>
<td>10</td>
<td>177</td>
<td>215</td>
<td>196.0</td>
<td>19.0</td>
<td>199.0</td>
<td>&#45;114.0</td>
</tr>
<tr class='mpb-player-13945'><td>314</td>
<td class='player-label'><a href='/nfl/players/david-cobb.php?type=overall&week=draft'>David Cobb</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-13945' fp-player-name='David Cobb'></a></td>
<td>RB91</td>
<td>13</td>
<td>180</td>
<td>282</td>
<td>238.4</td>
<td>24.3</td>
<td>318.0</td>
<td>&#43;4.0</td>
</tr>
<tr class='mpb-player-15493'><td>315</td>
<td class='player-label'><a href='/nfl/players/paxton-lynch.php?type=overall&week=draft'>Paxton Lynch</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-15493' fp-player-name='Paxton Lynch'></a></td>
<td>QB36</td>
<td>11</td>
<td>183</td>
<td>321</td>
<td>227.6</td>
<td>49.3</td>
<td>340.0</td>
<td>&#43;25.0</td>
</tr>
<tr class='mpb-player-11425'><td>316</td>
<td class='player-label'><a href='/nfl/players/case-keenum.php?type=overall&week=draft'>Case Keenum</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-11425' fp-player-name='Case Keenum'></a></td>
<td>QB37</td>
<td>8</td>
<td>182</td>
<td>412</td>
<td>267.0</td>
<td>77.6</td>
<td>498.0</td>
<td>&#43;182.0</td>
</tr>
<tr class='mpb-player-14230'><td>317</td>
<td class='player-label'><a href='/nfl/players/deandre-smelter.php?type=overall&week=draft'>DeAndre Smelter</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-14230' fp-player-name='DeAndre Smelter'></a></td>
<td>WR110</td>
<td>8</td>
<td>182</td>
<td>361</td>
<td>231.5</td>
<td>46.3</td>
<td>296.0</td>
<td>&#45;21.0</td>
</tr>
<tr class='mpb-player-9534'><td>318</td>
<td class='player-label'><a href='/nfl/players/robbie-gould.php?type=overall&week=draft'>Robbie Gould</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9534' fp-player-name='Robbie Gould'></a></td>
<td>K24</td>
<td>9</td>
<td>183</td>
<td>286</td>
<td>241.5</td>
<td>40.9</td>
<td>241.0</td>
<td>&#45;77.0</td>
</tr>
<tr class='mpb-player-15632'><td>319</td>
<td class='player-label'><a href='/nfl/players/roberto-aguayo.php?type=overall&week=draft'>Roberto Aguayo</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-15632' fp-player-name='Roberto Aguayo'></a></td>
<td>K25</td>
<td>6</td>
<td>191</td>
<td>265</td>
<td>223.3</td>
<td>32.1</td>
<td>249.0</td>
<td>&#45;70.0</td>
</tr>
<tr class='mpb-player-11620'><td>320</td>
<td class='player-label'><a href='/nfl/players/quinton-patton.php?type=overall&week=draft'>Quinton Patton</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-11620' fp-player-name='Quinton Patton'></a></td>
<td>WR111</td>
<td>8</td>
<td>185</td>
<td>312</td>
<td>249.6</td>
<td>45.7</td>
<td>245.0</td>
<td>&#45;75.0</td>
</tr>
<tr class='mpb-player-14413'><td>321</td>
<td class='player-label'><a href='/nfl/players/andrew-franks.php?type=overall&week=draft'>Andrew Franks</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-14413' fp-player-name='Andrew Franks'></a></td>
<td>K26</td>
<td>8</td>
<td>186</td>
<td>211</td>
<td>198.5</td>
<td>12.5</td>
<td>837.0</td>
<td>&#43;516.0</td>
</tr>
<tr class='mpb-player-9070'><td>322</td>
<td class='player-label'><a href='/nfl/players/brent-celek.php?type=overall&week=draft'>Brent Celek</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-9070' fp-player-name='Brent Celek'></a></td>
<td>TE38</td>
<td>4</td>
<td>187</td>
<td>329</td>
<td>266.3</td>
<td>56.4</td>
<td>293.0</td>
<td>&#45;29.0</td>
</tr>
<tr class='mpb-player-15561'><td>323</td>
<td class='player-label'><a href='/nfl/players/hunter-henry.php?type=overall&week=draft'>Hunter Henry</a> <small class='grey'>SD</small> <a href='#' class='fp-player-link fp-id-15561' fp-player-name='Hunter Henry'></a></td>
<td>TE39</td>
<td>11</td>
<td>188</td>
<td>319</td>
<td>241.5</td>
<td>40.6</td>
<td>316.0</td>
<td>&#45;7.0</td>
</tr>
<tr class='mpb-player-9323'><td>324</td>
<td class='player-label'><a href='/nfl/players/josh-brown.php?type=overall&week=draft'>Josh Brown</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-9323' fp-player-name='Josh Brown'></a></td>
<td>K27</td>
<td>8</td>
<td>188</td>
<td>257</td>
<td>235.8</td>
<td>28.1</td>
<td>244.0</td>
<td>&#45;80.0</td>
</tr>
<tr class='mpb-player-12338'><td>325</td>
<td class='player-label'><a href='/nfl/players/albert-wilson.php?type=overall&week=draft'>Albert Wilson</a> <small class='grey'>KC</small> <a href='#' class='fp-player-link fp-id-12338' fp-player-name='Albert Wilson'></a></td>
<td>WR112</td>
<td>5</td>
<td>189</td>
<td>275</td>
<td>232.5</td>
<td>30.4</td>
<td>285.0</td>
<td>&#45;40.0</td>
</tr>
<tr class='mpb-player-11830'><td>326</td>
<td class='player-label'><a href='/nfl/players/ryan-griffin.php?type=overall&week=draft'>Ryan Griffin</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-11830' fp-player-name='Ryan Griffin'></a></td>
<td>TE40</td>
<td>9</td>
<td>191</td>
<td>316</td>
<td>254.4</td>
<td>48.1</td>
<td>558.0</td>
<td>&#43;232.0</td>
</tr>
<tr class='mpb-player-11815'><td>327</td>
<td class='player-label'><a href='/nfl/players/caleb-sturgis.php?type=overall&week=draft'>Caleb Sturgis</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-11815' fp-player-name='Caleb Sturgis'></a></td>
<td>K28</td>
<td>4</td>
<td>191</td>
<td>216</td>
<td>203.5</td>
<td>12.5</td>
<td>304.0</td>
<td>&#45;23.0</td>
</tr>
<tr class='mpb-player-9491'><td>328</td>
<td class='player-label'><a href='/nfl/players/nick-folk.php?type=overall&week=draft'>Nick Folk</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-9491' fp-player-name='Nick Folk'></a></td>
<td>K29</td>
<td>11</td>
<td>192</td>
<td>232</td>
<td>212.0</td>
<td>20.0</td>
<td>218.0</td>
<td>&#45;110.0</td>
</tr>
<tr class='mpb-player-9425'><td>329</td>
<td class='player-label'><a href='/nfl/players/mark-sanchez.php?type=overall&week=draft'>Mark Sanchez</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-9425' fp-player-name='Mark Sanchez'></a></td>
<td>QB38</td>
<td>11</td>
<td>193</td>
<td>393</td>
<td>241.2</td>
<td>51.7</td>
<td>338.0</td>
<td>&#43;9.0</td>
</tr>
<tr class='mpb-player-13974'><td>330</td>
<td class='player-label'><a href='/nfl/players/devin-smith-wr.php?type=overall&week=draft'>Devin Smith</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-13974' fp-player-name='Devin Smith'></a></td>
<td>WR113</td>
<td>11</td>
<td>193</td>
<td>378</td>
<td>285.3</td>
<td>65.8</td>
<td>731.0</td>
<td>&#43;401.0</td>
</tr>
<tr class='mpb-player-11687'><td>331</td>
<td class='player-label'><a href='/nfl/players/geno-smith.php?type=overall&week=draft'>Geno Smith</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-11687' fp-player-name='Geno Smith'></a></td>
<td>QB39</td>
<td>11</td>
<td>194</td>
<td>401</td>
<td>263.3</td>
<td>80.9</td>
<td>548.0</td>
<td>&#43;217.0</td>
</tr>
<tr class='mpb-player-14003'><td>332</td>
<td class='player-label'><a href='/nfl/players/jason-myers.php?type=overall&week=draft'>Jason Myers</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-14003' fp-player-name='Jason Myers'></a></td>
<td>K30</td>
<td>5</td>
<td>194</td>
<td>219</td>
<td>206.5</td>
<td>12.5</td>
<td>329.0</td>
<td>&#45;3.0</td>
</tr>
<tr class='mpb-player-8310'><td>333</td>
<td class='player-label'><a href='/nfl/teams/washington-defense.php'>Washington Redskins</a> <a href='#' class='fp-player-link fp-id-8310' fp-player-name='Washington Redskins'></a></td>
<td>DST20</td>
<td>9</td>
<td>195</td>
<td>252</td>
<td>219.0</td>
<td>24.1</td>
<td>234.0</td>
<td>&#45;99.0</td>
</tr>
<tr class='mpb-player-13636'><td>334</td>
<td class='player-label'><a href='/nfl/players/darren-fells.php?type=overall&week=draft'>Darren Fells</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-13636' fp-player-name='Darren Fells'></a></td>
<td>TE41</td>
<td>9</td>
<td>196</td>
<td>330</td>
<td>276.3</td>
<td>57.9</td>
<td>697.0</td>
<td>&#43;363.0</td>
</tr>
<tr class='mpb-player-13943'><td>335</td>
<td class='player-label'><a href='/nfl/players/mike-davis-rb.php?type=overall&week=draft'>Mike Davis</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-13943' fp-player-name='Mike Davis'></a></td>
<td>RB92</td>
<td>8</td>
<td>197</td>
<td>376</td>
<td>284.0</td>
<td>73.2</td>
<td>719.0</td>
<td>&#43;384.0</td>
</tr>
<tr class='mpb-player-12206'><td>336</td>
<td class='player-label'><a href='/nfl/players/cody-latimer.php?type=overall&week=draft'>Cody Latimer</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-12206' fp-player-name='Cody Latimer'></a></td>
<td>WR114</td>
<td>11</td>
<td>197</td>
<td>341</td>
<td>266.4</td>
<td>48.8</td>
<td>617.0</td>
<td>&#43;281.0</td>
</tr>
<tr class='mpb-player-15546'><td>337</td>
<td class='player-label'><a href='/nfl/players/alex-collins.php?type=overall&week=draft'>Alex Collins</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-15546' fp-player-name='Alex Collins'></a></td>
<td>RB93</td>
<td>5</td>
<td>199</td>
<td>283</td>
<td>235.6</td>
<td>27.7</td>
<td>881.0</td>
<td>&#43;544.0</td>
</tr>
<tr class='tier-row static'><td>Tier 14</td><td colspan='8'>&nbsp;</td><td class='right'><a href='javascript:;'>(EDIT)</a></td></tr><tr class='mpb-player-13511'><td>338</td>
<td class='player-label'><a href='/nfl/players/philly-brown.php?type=overall&week=draft'>Philly Brown</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-13511' fp-player-name='Philly Brown'></a></td>
<td>WR115</td>
<td>7</td>
<td>200</td>
<td>332</td>
<td>260.6</td>
<td>43.7</td>
<td>290.0</td>
<td>&#45;48.0</td>
</tr>
<tr class='mpb-player-12349'><td>339</td>
<td class='player-label'><a href='/nfl/players/antonio-andrews.php?type=overall&week=draft'>Antonio Andrews</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-12349' fp-player-name='Antonio Andrews'></a></td>
<td>RB94</td>
<td>13</td>
<td>202</td>
<td>248</td>
<td>234.7</td>
<td>15.5</td>
<td>313.0</td>
<td>&#45;26.0</td>
</tr>
<tr class='mpb-player-14234'><td>340</td>
<td class='player-label'><a href='/nfl/players/j.j.-nelson.php?type=overall&week=draft'>J.J. Nelson</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-14234' fp-player-name='J.J. Nelson'></a></td>
<td>WR116</td>
<td>9</td>
<td>203</td>
<td>309</td>
<td>231.2</td>
<td>29.3</td>
<td>305.0</td>
<td>&#45;35.0</td>
</tr>
<tr class='mpb-player-12130'><td>341</td>
<td class='player-label'><a href='/nfl/players/jared-abbrederis.php?type=overall&week=draft'>Jared Abbrederis</a> <small class='grey'>GB</small> <a href='#' class='fp-player-link fp-id-12130' fp-player-name='Jared Abbrederis'></a></td>
<td>WR117</td>
<td>4</td>
<td>207</td>
<td>399</td>
<td>278.6</td>
<td>64.6</td>
<td>602.0</td>
<td>&#43;261.0</td>
</tr>
<tr class='mpb-player-9956'><td>342</td>
<td class='player-label'><a href='/nfl/players/cecil-shorts.php?type=overall&week=draft'>Cecil Shorts</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-9956' fp-player-name='Cecil Shorts'></a></td>
<td>WR118</td>
<td>9</td>
<td>207</td>
<td>337</td>
<td>271.0</td>
<td>46.1</td>
<td>448.0</td>
<td>&#43;106.0</td>
</tr>
<tr class='mpb-player-11211'><td>343</td>
<td class='player-label'><a href='/nfl/players/jarius-wright.php?type=overall&week=draft'>Jarius Wright</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-11211' fp-player-name='Jarius Wright'></a></td>
<td>WR119</td>
<td>6</td>
<td>207</td>
<td>331</td>
<td>254.0</td>
<td>54.9</td>
<td>478.0</td>
<td>&#43;135.0</td>
</tr>
<tr class='mpb-player-8100'><td>344</td>
<td class='player-label'><a href='/nfl/teams/detroit-defense.php'>Detroit Lions</a> <a href='#' class='fp-player-link fp-id-8100' fp-player-name='Detroit Lions'></a></td>
<td>DST21</td>
<td>10</td>
<td>207</td>
<td>300</td>
<td>259.5</td>
<td>34.2</td>
<td>226.0</td>
<td>&#45;118.0</td>
</tr>
<tr class='mpb-player-9427'><td>345</td>
<td class='player-label'><a href='/nfl/players/marques-colston.php?type=overall&week=draft'>Marques Colston</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-9427' fp-player-name='Marques Colston'></a></td>
<td>WR120</td>
<td></td>
<td>207</td>
<td>228</td>
<td>217.5</td>
<td>10.5</td>
<td></td>
<td></td>
</tr>
<tr class='mpb-player-12298'><td>346</td>
<td class='player-label'><a href='/nfl/players/quincy-enunwa.php?type=overall&week=draft'>Quincy Enunwa</a> <small class='grey'>NYJ</small> <a href='#' class='fp-player-link fp-id-12298' fp-player-name='Quincy Enunwa'></a></td>
<td>WR121</td>
<td>11</td>
<td>208</td>
<td>242</td>
<td>222.3</td>
<td>14.4</td>
<td>627.0</td>
<td>&#43;281.0</td>
</tr>
<tr class='mpb-player-8130'><td>347</td>
<td class='player-label'><a href='/nfl/teams/indianapolis-defense.php'>Indianapolis Colts</a> <a href='#' class='fp-player-link fp-id-8130' fp-player-name='Indianapolis Colts'></a></td>
<td>DST22</td>
<td>10</td>
<td>209</td>
<td>281</td>
<td>253.3</td>
<td>27.4</td>
<td>252.0</td>
<td>&#45;95.0</td>
</tr>
<tr class='mpb-player-9327'><td>348</td>
<td class='player-label'><a href='/nfl/players/josh-mccown.php?type=overall&week=draft'>Josh McCown</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-9327' fp-player-name='Josh McCown'></a></td>
<td>QB40</td>
<td>13</td>
<td>209</td>
<td>259</td>
<td>235.7</td>
<td>20.5</td>
<td>390.0</td>
<td>&#43;42.0</td>
</tr>
<tr class='mpb-player-8020'><td>349</td>
<td class='player-label'><a href='/nfl/teams/baltimore-defense.php'>Baltimore Ravens</a> <a href='#' class='fp-player-link fp-id-8020' fp-player-name='Baltimore Ravens'></a></td>
<td>DST23</td>
<td>8</td>
<td>211</td>
<td>310</td>
<td>267.4</td>
<td>32.6</td>
<td>224.0</td>
<td>&#45;125.0</td>
</tr>
<tr class='mpb-player-8290'><td>350</td>
<td class='player-label'><a href='/nfl/teams/tampa-bay-defense.php'>Tampa Bay Buccaneers</a> <a href='#' class='fp-player-link fp-id-8290' fp-player-name='Tampa Bay Buccaneers'></a></td>
<td>DST24</td>
<td>6</td>
<td>213</td>
<td>299</td>
<td>272.4</td>
<td>31.5</td>
<td>242.0</td>
<td>&#45;108.0</td>
</tr>
<tr class='mpb-player-9478'><td>351</td>
<td class='player-label'><a href='/nfl/players/mike-tolbert.php?type=overall&week=draft'>Mike Tolbert</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-9478' fp-player-name='Mike Tolbert'></a></td>
<td>RB95</td>
<td>7</td>
<td>214</td>
<td>295</td>
<td>242.5</td>
<td>31.5</td>
<td>300.0</td>
<td>&#45;51.0</td>
</tr>
<tr class='mpb-player-8300'><td>352</td>
<td class='player-label'><a href='/nfl/teams/tennessee-defense.php'>Tennessee Titans</a> <a href='#' class='fp-player-link fp-id-8300' fp-player-name='Tennessee Titans'></a></td>
<td>DST25</td>
<td>13</td>
<td>216</td>
<td>283</td>
<td>260.3</td>
<td>31.4</td>
<td>327.0</td>
<td>&#45;25.0</td>
</tr>
<tr class='mpb-player-12098'><td>353</td>
<td class='player-label'><a href='/nfl/players/tre-mason.php?type=overall&week=draft'>Tre Mason</a> <small class='grey'>LA</small> <a href='#' class='fp-player-link fp-id-12098' fp-player-name='Tre Mason'></a></td>
<td>RB96</td>
<td>8</td>
<td>216</td>
<td>258</td>
<td>237.0</td>
<td>21.0</td>
<td>341.0</td>
<td>&#45;12.0</td>
</tr>
<tr class='mpb-player-8080'><td>354</td>
<td class='player-label'><a href='/nfl/teams/dallas-defense.php'>Dallas Cowboys</a> <a href='#' class='fp-player-link fp-id-8080' fp-player-name='Dallas Cowboys'></a></td>
<td>DST26</td>
<td>7</td>
<td>217</td>
<td>278</td>
<td>257.0</td>
<td>28.3</td>
<td>214.0</td>
<td>&#45;140.0</td>
</tr>
<tr class='mpb-player-9621'><td>355</td>
<td class='player-label'><a href='/nfl/players/vernon-davis.php?type=overall&week=draft'>Vernon Davis</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-9621' fp-player-name='Vernon Davis'></a></td>
<td>TE42</td>
<td>9</td>
<td>218</td>
<td>379</td>
<td>245.6</td>
<td>50.8</td>
<td>311.0</td>
<td>&#45;44.0</td>
</tr>
<tr class='mpb-player-8050'><td>356</td>
<td class='player-label'><a href='/nfl/teams/chicago-defense.php'>Chicago Bears</a> <a href='#' class='fp-player-link fp-id-8050' fp-player-name='Chicago Bears'></a></td>
<td>DST27</td>
<td>9</td>
<td>218</td>
<td>299</td>
<td>266.8</td>
<td>29.9</td>
<td>216.0</td>
<td>&#45;140.0</td>
</tr>
<tr class='mpb-player-11507'><td>357</td>
<td class='player-label'><a href='/nfl/players/garrett-celek.php?type=overall&week=draft'>Garrett Celek</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-11507' fp-player-name='Garrett Celek'></a></td>
<td>TE43</td>
<td>8</td>
<td>219</td>
<td>325</td>
<td>249.3</td>
<td>32.4</td>
<td>512.0</td>
<td>&#43;155.0</td>
</tr>
<tr class='mpb-player-8270'><td>358</td>
<td class='player-label'><a href='/nfl/teams/san-francisco-defense.php'>San Francisco 49ers</a> <a href='#' class='fp-player-link fp-id-8270' fp-player-name='San Francisco 49ers'></a></td>
<td>DST28</td>
<td>8</td>
<td>219</td>
<td>284</td>
<td>261.3</td>
<td>30.0</td>
<td>352.0</td>
<td>&#45;6.0</td>
</tr>
<tr class='mpb-player-11992'><td>359</td>
<td class='player-label'><a href='/nfl/players/larry-donnell.php?type=overall&week=draft'>Larry Donnell</a> <small class='grey'>NYG</small> <a href='#' class='fp-player-link fp-id-11992' fp-player-name='Larry Donnell'></a></td>
<td>TE44</td>
<td>8</td>
<td>220</td>
<td>308</td>
<td>240.8</td>
<td>30.8</td>
<td>579.0</td>
<td>&#43;220.0</td>
</tr>
<tr class='mpb-player-8250'><td>360</td>
<td class='player-label'><a href='/nfl/teams/san-diego-defense.php'>San Diego Chargers</a> <a href='#' class='fp-player-link fp-id-8250' fp-player-name='San Diego Chargers'></a></td>
<td>DST29</td>
<td>11</td>
<td>220</td>
<td>280</td>
<td>259.0</td>
<td>27.6</td>
<td>323.0</td>
<td>&#45;37.0</td>
</tr>
<tr class='mpb-player-11041'><td>361</td>
<td class='player-label'><a href='/nfl/players/andrew-hawkins.php?type=overall&week=draft'>Andrew Hawkins</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-11041' fp-player-name='Andrew Hawkins'></a></td>
<td>WR122</td>
<td>13</td>
<td>221</td>
<td>365</td>
<td>277.3</td>
<td>54.0</td>
<td>463.0</td>
<td>&#43;102.0</td>
</tr>
<tr class='mpb-player-15520'><td>362</td>
<td class='player-label'><a href='/nfl/players/carson-wentz.php?type=overall&week=draft'>Carson Wentz</a> <small class='grey'>PHI</small> <a href='#' class='fp-player-link fp-id-15520' fp-player-name='Carson Wentz'></a></td>
<td>QB41</td>
<td>4</td>
<td>221</td>
<td>274</td>
<td>242.7</td>
<td>22.7</td>
<td>333.0</td>
<td>&#45;29.0</td>
</tr>
<tr class='mpb-player-8070'><td>363</td>
<td class='player-label'><a href='/nfl/teams/cleveland-defense.php'>Cleveland Browns</a> <a href='#' class='fp-player-link fp-id-8070' fp-player-name='Cleveland Browns'></a></td>
<td>DST30</td>
<td>13</td>
<td>222</td>
<td>291</td>
<td>260.0</td>
<td>28.6</td>
<td>289.0</td>
<td>&#45;74.0</td>
</tr>
<tr class='mpb-player-14498'><td>364</td>
<td class='player-label'><a href='/nfl/players/adam-humphries.php?type=overall&week=draft'>Adam Humphries</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-14498' fp-player-name='Adam Humphries'></a></td>
<td>WR123</td>
<td>6</td>
<td>223</td>
<td>339</td>
<td>275.7</td>
<td>48.0</td>
<td>852.0</td>
<td>&#43;488.0</td>
</tr>
<tr class='mpb-player-8010'><td>365</td>
<td class='player-label'><a href='/nfl/teams/atlanta-defense.php'>Atlanta Falcons</a> <a href='#' class='fp-player-link fp-id-8010' fp-player-name='Atlanta Falcons'></a></td>
<td>DST31</td>
<td>11</td>
<td>223</td>
<td>282</td>
<td>260.7</td>
<td>26.7</td>
<td>355.0</td>
<td>&#45;10.0</td>
</tr>
<tr class='mpb-player-8190'><td>366</td>
<td class='player-label'><a href='/nfl/teams/new-orleans-defense.php'>New Orleans Saints</a> <a href='#' class='fp-player-link fp-id-8190' fp-player-name='New Orleans Saints'></a></td>
<td>DST32</td>
<td>5</td>
<td>224</td>
<td>285</td>
<td>249.7</td>
<td>25.8</td>
<td>346.0</td>
<td>&#45;20.0</td>
</tr>
<tr class='mpb-player-9496'><td>367</td>
<td class='player-label'><a href='/nfl/players/owen-daniels.php?type=overall&week=draft'>Owen Daniels</a> <small class='grey'><a href='/nfl/players/free-agents.php'>FA</a></small> <a href='#' class='fp-player-link fp-id-9496' fp-player-name='Owen Daniels'></a></td>
<td>TE45</td>
<td></td>
<td>224</td>
<td>239</td>
<td>232.7</td>
<td>5.3</td>
<td></td>
<td></td>
</tr>
<tr class='mpb-player-9549'><td>368</td>
<td class='player-label'><a href='/nfl/players/ryan-succop.php?type=overall&week=draft'>Ryan Succop</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-9549' fp-player-name='Ryan Succop'></a></td>
<td>K31</td>
<td>13</td>
<td>225</td>
<td>271</td>
<td>248.0</td>
<td>23.0</td>
<td>276.0</td>
<td>&#45;92.0</td>
</tr>
<tr class='mpb-player-9688'><td>369</td>
<td class='player-label'><a href='/nfl/players/dexter-mccluster.php?type=overall&week=draft'>Dexter McCluster</a> <small class='grey'>TEN</small> <a href='#' class='fp-player-link fp-id-9688' fp-player-name='Dexter McCluster'></a></td>
<td>RB97</td>
<td>13</td>
<td>226</td>
<td>356</td>
<td>268.5</td>
<td>51.2</td>
<td>302.0</td>
<td>&#45;67.0</td>
</tr>
<tr class='mpb-player-13972'><td>370</td>
<td class='player-label'><a href='/nfl/players/rashad-greene.php?type=overall&week=draft'>Rashad Greene</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-13972' fp-player-name='Rashad Greene'></a></td>
<td>WR124</td>
<td>5</td>
<td>226</td>
<td>345</td>
<td>274.0</td>
<td>51.2</td>
<td>259.0</td>
<td>&#45;111.0</td>
</tr>
<tr class='mpb-player-12357'><td>371</td>
<td class='player-label'><a href='/nfl/players/travis-coons.php?type=overall&week=draft'>Travis Coons</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-12357' fp-player-name='Travis Coons'></a></td>
<td>K32</td>
<td>13</td>
<td>226</td>
<td>234</td>
<td>230.0</td>
<td>4.0</td>
<td>288.0</td>
<td>&#45;83.0</td>
</tr>
<tr class='mpb-player-9928'><td>372</td>
<td class='player-label'><a href='/nfl/players/stevan-ridley.php?type=overall&week=draft'>Stevan Ridley</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-9928' fp-player-name='Stevan Ridley'></a></td>
<td>RB98</td>
<td>10</td>
<td>227</td>
<td>394</td>
<td>310.5</td>
<td>83.5</td>
<td>319.0</td>
<td>&#45;53.0</td>
</tr>
<tr class='mpb-player-9894'><td>373</td>
<td class='player-label'><a href='/nfl/players/jacquizz-rodgers.php?type=overall&week=draft'>Jacquizz Rodgers</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9894' fp-player-name='Jacquizz Rodgers'></a></td>
<td>RB99</td>
<td>9</td>
<td>228</td>
<td>350</td>
<td>289.0</td>
<td>61.0</td>
<td>267.0</td>
<td>&#45;106.0</td>
</tr>
<tr class='mpb-player-9986'><td>374</td>
<td class='player-label'><a href='/nfl/players/jeremy-kerley.php?type=overall&week=draft'>Jeremy Kerley</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-9986' fp-player-name='Jeremy Kerley'></a></td>
<td>WR125</td>
<td>8</td>
<td>229</td>
<td>423</td>
<td>326.0</td>
<td>97.0</td>
<td>451.0</td>
<td>&#43;77.0</td>
</tr>
<tr class='mpb-player-11599'><td>375</td>
<td class='player-label'><a href='/nfl/players/marquise-goodwin.php?type=overall&week=draft'>Marquise Goodwin</a> <small class='grey'>BUF</small> <a href='#' class='fp-player-link fp-id-11599' fp-player-name='Marquise Goodwin'></a></td>
<td>WR126</td>
<td>10</td>
<td>229</td>
<td>336</td>
<td>282.5</td>
<td>53.5</td>
<td>521.0</td>
<td>&#43;146.0</td>
</tr>
<tr class='mpb-player-13961'><td>376</td>
<td class='player-label'><a href='/nfl/players/jeff-heuerman.php?type=overall&week=draft'>Jeff Heuerman</a> <small class='grey'>DEN</small> <a href='#' class='fp-player-link fp-id-13961' fp-player-name='Jeff Heuerman'></a></td>
<td>TE46</td>
<td>11</td>
<td>232</td>
<td>315</td>
<td>260.7</td>
<td>38.4</td>
<td>260.0</td>
<td>&#45;116.0</td>
</tr>
<tr class='mpb-player-15586'><td>377</td>
<td class='player-label'><a href='/nfl/players/rashard-higgins.php?type=overall&week=draft'>Rashard Higgins</a> <small class='grey'>CLE</small> <a href='#' class='fp-player-link fp-id-15586' fp-player-name='Rashard Higgins'></a></td>
<td>WR127</td>
<td>13</td>
<td>232</td>
<td>251</td>
<td>243.3</td>
<td>7.1</td>
<td>882.0</td>
<td>&#43;505.0</td>
</tr>
<tr class='mpb-player-13964'><td>378</td>
<td class='player-label'><a href='/nfl/players/mycole-pruitt.php?type=overall&week=draft'>MyCole Pruitt</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-13964' fp-player-name='MyCole Pruitt'></a></td>
<td>TE47</td>
<td>6</td>
<td>233</td>
<td>366</td>
<td>305.3</td>
<td>54.9</td>
<td>727.0</td>
<td>&#43;349.0</td>
</tr>
<tr class='mpb-player-13960'><td>379</td>
<td class='player-label'><a href='/nfl/players/tyler-kroft.php?type=overall&week=draft'>Tyler Kroft</a> <small class='grey'>CIN</small> <a href='#' class='fp-player-link fp-id-13960' fp-player-name='Tyler Kroft'></a></td>
<td>TE48</td>
<td>9</td>
<td>233</td>
<td>343</td>
<td>288.0</td>
<td>55.0</td>
<td>724.0</td>
<td>&#43;345.0</td>
</tr>
<tr class='mpb-player-11812'><td>380</td>
<td class='player-label'><a href='/nfl/players/luke-willson.php?type=overall&week=draft'>Luke Willson</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-11812' fp-player-name='Luke Willson'></a></td>
<td>TE49</td>
<td>5</td>
<td>233</td>
<td>316</td>
<td>256.2</td>
<td>31.6</td>
<td>348.0</td>
<td>&#45;32.0</td>
</tr>
<tr class='mpb-player-13565'><td>381</td>
<td class='player-label'><a href='/nfl/players/josh-hill-te.php?type=overall&week=draft'>Josh Hill</a> <small class='grey'>NO</small> <a href='#' class='fp-player-link fp-id-13565' fp-player-name='Josh Hill'></a></td>
<td>TE50</td>
<td>5</td>
<td>235</td>
<td>322</td>
<td>277.7</td>
<td>35.5</td>
<td>692.0</td>
<td>&#43;311.0</td>
</tr>
<tr class='mpb-player-13966'><td>382</td>
<td class='player-label'><a href='/nfl/players/blake-bell.php?type=overall&week=draft'>Blake Bell</a> <small class='grey'>SF</small> <a href='#' class='fp-player-link fp-id-13966' fp-player-name='Blake Bell'></a></td>
<td>TE51</td>
<td>8</td>
<td>239</td>
<td>346</td>
<td>301.0</td>
<td>45.3</td>
<td>729.0</td>
<td>&#43;347.0</td>
</tr>
<tr class='mpb-player-12260'><td>383</td>
<td class='player-label'><a href='/nfl/players/ryan-grant-wr.php?type=overall&week=draft'>Ryan Grant</a> <small class='grey'>WAS</small> <a href='#' class='fp-player-link fp-id-12260' fp-player-name='Ryan Grant'></a></td>
<td>WR128</td>
<td>9</td>
<td>243</td>
<td>391</td>
<td>317.0</td>
<td>74.0</td>
<td>622.0</td>
<td>&#43;239.0</td>
</tr>
<tr class='mpb-player-12146'><td>384</td>
<td class='player-label'><a href='/nfl/players/cj-fiedorowicz.php?type=overall&week=draft'>C.J. Fiedorowicz</a> <small class='grey'>HOU</small> <a href='#' class='fp-player-link fp-id-12146' fp-player-name='C.J. Fiedorowicz'></a></td>
<td>TE52</td>
<td>9</td>
<td>243</td>
<td>371</td>
<td>307.0</td>
<td>64.0</td>
<td>608.0</td>
<td>&#43;224.0</td>
</tr>
<tr class='mpb-player-11498'><td>385</td>
<td class='player-label'><a href='/nfl/players/matt-asiata.php?type=overall&week=draft'>Matt Asiata</a> <small class='grey'>MIN</small> <a href='#' class='fp-player-link fp-id-11498' fp-player-name='Matt Asiata'></a></td>
<td>RB100</td>
<td>6</td>
<td>246</td>
<td>363</td>
<td>304.5</td>
<td>58.5</td>
<td>508.0</td>
<td>&#43;123.0</td>
</tr>
<tr class='mpb-player-9078'><td>386</td>
<td class='player-label'><a href='/nfl/players/brian-hoyer.php?type=overall&week=draft'>Brian Hoyer</a> <small class='grey'>CHI</small> <a href='#' class='fp-player-link fp-id-9078' fp-player-name='Brian Hoyer'></a></td>
<td>QB42</td>
<td>9</td>
<td>266</td>
<td>415</td>
<td>340.5</td>
<td>74.5</td>
<td>368.0</td>
<td>&#45;18.0</td>
</tr>
<tr class='mpb-player-11628'><td>387</td>
<td class='player-label'><a href='/nfl/players/denard-robinson.php?type=overall&week=draft'>Denard Robinson</a> <small class='grey'>JAC</small> <a href='#' class='fp-player-link fp-id-11628' fp-player-name='Denard Robinson'></a></td>
<td>RB101</td>
<td>5</td>
<td>268</td>
<td>388</td>
<td>328.0</td>
<td>60.0</td>
<td>532.0</td>
<td>&#43;145.0</td>
</tr>
<tr class='mpb-player-12129'><td>388</td>
<td class='player-label'><a href='/nfl/players/paul-richardson.php?type=overall&week=draft'>Paul Richardson</a> <small class='grey'>SEA</small> <a href='#' class='fp-player-link fp-id-12129' fp-player-name='Paul Richardson'></a></td>
<td>WR129</td>
<td>5</td>
<td>269</td>
<td>386</td>
<td>327.5</td>
<td>58.5</td>
<td>601.0</td>
<td>&#43;213.0</td>
</tr>
<tr class='mpb-player-11688'><td>389</td>
<td class='player-label'><a href='/nfl/players/fozzy-whittaker.php?type=overall&week=draft'>Fozzy Whittaker</a> <small class='grey'>CAR</small> <a href='#' class='fp-player-link fp-id-11688' fp-player-name='Fozzy Whittaker'></a></td>
<td>RB102</td>
<td>7</td>
<td>278</td>
<td>380</td>
<td>329.0</td>
<td>51.0</td>
<td>549.0</td>
<td>&#43;160.0</td>
</tr>
<tr class='mpb-player-13986'><td>390</td>
<td class='player-label'><a href='/nfl/players/kenny-bell.php?type=overall&week=draft'>Kenny Bell</a> <small class='grey'>TB</small> <a href='#' class='fp-player-link fp-id-13986' fp-player-name='Kenny Bell'></a></td>
<td>WR130</td>
<td>6</td>
<td>280</td>
<td>299</td>
<td>289.5</td>
<td>9.5</td>
<td>737.0</td>
<td>&#43;347.0</td>
</tr>
<tr class='mpb-player-11691'><td>391</td>
<td class='player-label'><a href='/nfl/players/dion-sims.php?type=overall&week=draft'>Dion Sims</a> <small class='grey'>MIA</small> <a href='#' class='fp-player-link fp-id-11691' fp-player-name='Dion Sims'></a></td>
<td>TE53</td>
<td>8</td>
<td>295</td>
<td>344</td>
<td>319.5</td>
<td>24.5</td>
<td>550.0</td>
<td>&#43;159.0</td>
</tr>
<tr class='mpb-player-9685'><td>392</td>
<td class='player-label'><a href='/nfl/players/jermaine-gresham.php?type=overall&week=draft'>Jermaine Gresham</a> <small class='grey'>ARI</small> <a href='#' class='fp-player-link fp-id-9685' fp-player-name='Jermaine Gresham'></a></td>
<td>TE54</td>
<td>9</td>
<td>305</td>
<td>359</td>
<td>332.0</td>
<td>27.0</td>
<td>409.0</td>
<td>&#43;17.0</td>
</tr>
<tr class='mpb-player-11700'><td>393</td>
<td class='player-label'><a href='/nfl/players/mychal-rivera.php?type=overall&week=draft'>Mychal Rivera</a> <small class='grey'>OAK</small> <a href='#' class='fp-player-link fp-id-11700' fp-player-name='Mychal Rivera'></a></td>
<td>TE55</td>
<td>10</td>
<td>319</td>
<td>333</td>
<td>326.0</td>
<td>7.0</td>
<td>555.0</td>
<td>&#43;162.0</td>
</tr>
<tr class='mpb-player-11987'><td>394</td>
<td class='player-label'><a href='/nfl/players/jack-doyle.php?type=overall&week=draft'>Jack Doyle</a> <small class='grey'>IND</small> <a href='#' class='fp-player-link fp-id-11987' fp-player-name='Jack Doyle'></a></td>
<td>TE56</td>
<td>10</td>
<td>322</td>
<td>352</td>
<td>337.0</td>
<td>15.0</td>
<td>578.0</td>
<td>&#43;184.0</td>
</tr>
                          </tbody>
                      </table>
                  </div>

                  <a name='latest-update'></a>
                  <p>
                      'Latest Update' refers to when we last checked for revised rankings.
                      Please note that we have no control over how frequently the experts update their rankings.
                      The publish date is provided for each expert to give you an idea of how fresh their rankings are.
                  </p>
                 <p>
                      Injury Alerts: Q = Questionable, O = Out, IR = Injured Reserve, S = Suspension
                  </p>
                              </div>
        </div> <!-- /.main-content -->

        <div class='side-nav'>
    <div class='ad-320'>
        <!-- fantasypros_nfl_content_content_320x50 -->
<div id='div-gpt-ad-1404326895972-0' style='width:320px; height:50px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1404326895972-0'); });
</script>
</div>
    </div>
    <nav><div class='heading'><a href='/nfl/rankings/consensus-cheatsheets.php''>NFL Rankings</a></div><ul><li class='active'><a href='/nfl/rankings/consensus-cheatsheets.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-expert-rankings'></i><span class='item-title'>Draft Rankings</span><span class='item-subtitle'>Combine rankings from 60+ fantasy experts.</span></a><ul><li class='active'><a href='/nfl/rankings/consensus-cheatsheets.php'>Standard</a></li><li><a href='/nfl/rankings/ppr-cheatsheets.php'>PPR</a></li><li><a href='/nfl/rankings/half-point-ppr-cheatsheets.php'>Half-PPR</a></li><li><a href='/nfl/adp/overall.php'>ADP</a></li></ul></li><li class=''><a href='/nfl/rankings/ros-qb.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-ros-rankings'></i><span class='item-title'>Rest of Season Rankings</span><span class='item-subtitle'>View go-forward advice from multiple experts.</span></a><ul><li><a href='/nfl/rankings/ros-qb.php'>Standard</a></li><li><a href='/nfl/rankings/ros-qb.php'>PPR</a></li><li><a href='/nfl/rankings/ros-qb.php'>Half-PPR</a></li></ul></li><li class=''><a href='/nfl/rankings/dynasty-overall.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-adp-rankings'></i><span class='item-title'>Dynasty Rankings</span><span class='item-subtitle'>Create a consensus dynasty cheat sheet.</span></a><ul><li><a href='/nfl/rankings/dynasty-overall.php'>PPR</a></li></ul></li></ul></nav><div class='ad-728 ad-tablet'><!-- fantasypros_nfl_content_leaderboard_728x90_2 -->
<div id='div-gpt-ad-1470375448721-0' style='width:728px; height:90px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1470375448721-0'); });
</script>
</div>
</div><nav><div class='heading'><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros''>Draft Tools</a></div><ul><li class=''><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros' class='clearfix'>
                    <i class='fa fa-dw fa-dw-draft-simulator'></i><span class='item-title'>Draft Simulator</span><span class='item-subtitle'>Practice fast mocks to prepare for your draft.</span></a></li><li class=''><a href='http://draftwizard.fantasypros.com/assistant/?partner=fpros&sport=nfl' class='clearfix'>
                    <i class='fa fa-dw fa-dw-draft-assistant'></i><span class='item-title'>Draft Assistant</span><span class='item-subtitle'>Get pick by pick expert advice during your draft.</span></a></li><li class=''><a href='http://draftwizard.fantasypros.com/editor/?partner=fpros&sport=nfl' class='clearfix'>
                    <i class='fa fa-dw fa-dw-cheat-sheets'></i><span class='item-title'>Cheat Sheet Creator</span><span class='item-subtitle'>Build a custom cheat sheet in seconds.</span></a></li><li class=''><a href='http://draftwizard.fantasypros.com/simulator/?auction=Y&sport=nfl' class='clearfix'>
                    <i class='fa fa-dw fa-dw-auction-simulator'></i><span class='item-title'>Auction Simulator</span><span class='item-subtitle'>Prepare for your draft with a realistic mock draft.</span></a></li><li class=''><a href='/nfl/draft/' class='clearfix'>
                    <i class='fa fa-fp fa-fp-start-sit-assistant'></i><span class='item-title'>Who Should I Draft?</span><span class='item-subtitle'>Compare players to see who should be drafted first.</span></a></li><li class=''><a href='/nfl/auction-values/calculator.php' class='clearfix'>
                    <i class='fa fa-dw fa-dw-auction-calculator'></i><span class='item-title'>Auction Calculator</span><span class='item-subtitle'>Create custom dollar values from consensus projections.</span></a></li></ul></nav><div class='ad-728 ad-tablet'><!-- fantasypros_nfl_content_leaderboard_728x90_3 -->
<div id='div-gpt-ad-1470375518515-0' style='width:728px; height:90px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1470375518515-0'); });
</script>
</div>
</div><nav><div class='heading'><a href='/nfl/rankings/consensus-cheatsheets.php''>Draft Research</a></div><ul><li class='active'><a href='/nfl/rankings/consensus-cheatsheets.php' class='clearfix'>
                    <i class='fa fa-list-ol'></i><span class='item-title'>Expert Rankings</span><span class='item-subtitle'>Rankings from 100+ experts.</span></a></li><li class=''><a href='/nfl/adp/overall.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-ros-rankings'></i><span class='item-title'>ADP Consensus</span><span class='item-subtitle'>Get the Average Draft Position across multiple sites.</span></a></li><li class=''><a href='/nfl/projections/qb.php?week=draft' class='clearfix'>
                    <i class='fa fa-fp fa-fp-projections'></i><span class='item-title'>Projections</span><span class='item-subtitle'>See projections for top fantasy football players.</span></a></li><li class=''><a href='/nfl/bye-week-cheatsheet.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-cheat-sheets'></i><span class='item-title'>Bye Week Cheat Sheet</span><span class='item-subtitle'>Avoid rostering too many players with the same Bye Week.</span></a></li><li class=''><a href='/nfl/strength-of-schedule.php' class='clearfix'>
                    <i class='fa fa-fp fa-fp-strength-of-schedule'></i><span class='item-title'>Strength of Schedule</span><span class='item-subtitle'>Fantasy Football Strength of Schedule (SOS) for 2016</span></a></li><li class=''><a href='/fantasy-football-draft-kit/' class='clearfix'>
                    <i class='fa fa-fp fa-fp-draft-kit'></i><span class='item-title'>2016 Draft Kit</span><span class='item-subtitle'>Get all the tools needed for your draft in one place.</span></a></li></ul></nav>    <div class='ad-160'>
        <!-- fantasypros_nfl__skyscraper_160x600_2 -->
<div id='div-gpt-ad-1349066428961-7' style='width:160px; height:600px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1349066428961-7'); });
</script>
</div>
    </div>
    
    
    <div class='ad-300 ad-mobile'>
        <!-- fantasypros_nfl_content_content_300x250 -->
<div id='div-gpt-ad-1404326955317-0' style='width:300px; height:250px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1404326955317-0'); });
</script>
</div>
    </div>
</div> <!-- /.side-nav -->
        
<div class='side-content'>
    <div class='inner'>
        
        <div class='ad-300'>
            <!-- fantasypros_nfl_content_sidebar_300x250_1 -->
<div id='div-gpt-ad-1349068144086-9' style='width:300px; height:250px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1349068144086-9'); });
</script>
</div>
        </div>
        <section class='section-wrap clearfix'>
        <div class='heading'>Fantasy Games</div><div class='photo-box dfs-item'><table><tr><td class='photo'><a href='http://partners.fanduel.com/processing/clickthrgh.asp?btag=a_770b_953' target='_blank'><img src='//images.fantasypros.com/images/icons/fanduel-icon-new.png' title='FanDuel photo' onError='this.src='';'></a></td><td class='text'><div class='title'><a href='http://partners.fanduel.com/processing/clickthrgh.asp?btag=a_770b_953' target='_blank'>FanDuel</a></div><div class='subtitle'>Get 5 free NFL entries<br>with your first deposit</div></td></table></div><div class='photo-box dfs-item'><table><tr><td class='photo'><a href='http://www.anrdoezrs.net/5b106cy63y5LRRNVRPMLNOSQRRRQLNQSVMPQRMQMMM' target='_blank'><img src='//images.fantasypros.com/images/logos/yahoo_dfs_100x100.png' title='Yahoo! Sports photo' onError='this.src='';'></a></td><td class='text'><div class='title'><a href='http://www.anrdoezrs.net/5b106cy63y5LRRNVRPMLNOSQRRRQLNQSVMPQRMQMMM' target='_blank'>Yahoo! Sports</a></div><div class='subtitle'>Join a League for Free</div></td></table></div><div class='photo-box dfs-item'><table><tr><td class='photo'><a href='http://www.cbssports.com/fantasy/football/games/commissioner?ttag=FFBC16_ps_fp_hp' target='_blank'><img src='//images.fantasypros.com/images/icons/cbs-icon-140x140.png' title='CBS Sports photo' onError='this.src='';'></a></td><td class='text'><div class='title'><a href='http://www.cbssports.com/fantasy/football/games/commissioner?ttag=FFBC16_ps_fp_hp' target='_blank'>CBS Sports</a></div><div class='subtitle'>Serious Fantasy Football</div></td></table></div></section><section id='news_content' class='tab-wrap section-wrap'>
        <div class='heading'><a href='/nfl/player-news.php'>Player News</a></div>
        <div class='no-xl top-read-more'><a href='/nfl/player-news.php'>View All News</a></div><ul class='side-menu side-menu-pills'><li><a href='#player-news-nfl'>NFL</a></li><li><a href='#player-news-mlb'>MLB</a></li><li><a href='#player-news-nba'>NBA</a></li></ul><div class='clearfix'></div><div class='news-pane clearfix' id='player-news-nfl'><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86208/bruce-ellington-placed-on-ir.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/12137.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86208/bruce-ellington-placed-on-ir.php'><b>Bruce Ellington</b> placed on IR</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86199/teddy-bridgewater-injured-practice.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/12088.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86199/teddy-bridgewater-injured-practice.php'><b>Teddy Bridgewater</b> injured in practice</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86222/emmanuel-sanders-misses-practice.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/9707.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86222/emmanuel-sanders-misses-practice.php'><b>Emmanuel Sanders</b> misses practice</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86205/ben-roethlisberger-.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/9039.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86205/ben-roethlisberger-.php'><b>Ben Roethlisberger</b> won't play Thursday against the Panthers</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86109/joey-bosa-finally-signs-with-chargers.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/15488.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86109/joey-bosa-finally-signs-with-chargers.php'><b>Joey Bosa</b> finally signs with Chargers</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86085/trevor-siemian-will-start-week-one.php'><img src='//images.fantasypros.com/images/photo_missing_square.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86085/trevor-siemian-will-start-week-one.php'><b>Trevor Siemian</b> will start week one</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86110/ezekiel-elliott-speaks-on-bad-decision.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/15498.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86110/ezekiel-elliott-speaks-on-bad-decision.php'><b>Ezekiel Elliott</b> speaks on 'bad decision'</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86106/dez-bryant-feels-unstoppable.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/9681.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86106/dez-bryant-feels-unstoppable.php'><b>Dez Bryant</b> feels 'unstoppable'</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86096/philip-rivers-survives-preseason.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/9509.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86096/philip-rivers-survives-preseason.php'><b>Philip Rivers</b> survives the preseason</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86076/sammy-watkins-wont-play-thursday.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/12118.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86076/sammy-watkins-wont-play-thursday.php'><b>Sammy Watkins</b> won't play Thursday</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86056/tj-yeldon-effective-sunday-night.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/13941.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86056/tj-yeldon-effective-sunday-night.php'><b>T.J. Yeldon</b> effective Sunday night.</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86051/chris-ivory-shutdown-third-preseason-game.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/9749.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86051/chris-ivory-shutdown-third-preseason-game.php'><b>Chris Ivory</b> shutdown in third preseason game</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86050/giovani-bernard-totals-52-yards-touchdown-third-preseason-game.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/11644.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86050/giovani-bernard-totals-52-yards-touchdown-third-preseason-game.php'><b>Giovani Bernard</b> totals 52 yards and a touchdown in third preseason game</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nfl/news/86049/jeremy-hill-totals-49-yards-scores-touchdown-third-preseason-game.php'><img src='//images.fantasypros.com/images/nfl/players/210x210/12102.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nfl/news/86049/jeremy-hill-totals-49-yards-scores-touchdown-third-preseason-game.php'><b>Jeremy Hill</b> totals 49 yards, scores a touchdown in third preseason game</a></div></td></table></div><div class='photo-box p-news-item read-more'><table><tr><td class='photo'>&nbsp;</td><td class='text'><div class='title'><a href='/nfl/player-news.php'>View All News</a></div></td></table></div></div><div class='news-pane clearfix' id='player-news-mlb'><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86226/clayton-kershaw-threw-two-inning-sim-game.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3215.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86226/clayton-kershaw-threw-two-inning-sim-game.php'><b>Clayton Kershaw</b> threw a two-inning sim game</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86224/dexter-fowler-not-starting-tuesday.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3297.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86224/dexter-fowler-not-starting-tuesday.php'><b>Dexter Fowler</b> not starting Tuesday</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86223/ben-zobrist-not-starting-tuesday.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3081.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86223/ben-zobrist-not-starting-tuesday.php'><b>Ben Zobrist</b> not starting Tuesday</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86218/nelson-cruz-out-tuesdays-lineup-with-sore-hand.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3796.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86218/nelson-cruz-out-tuesdays-lineup-with-sore-hand.php'><b>Nelson Cruz</b> out of Tuesday's lineup with sore hand</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86194/dee-gordon-hapless-plate.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3287.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86194/dee-gordon-hapless-plate.php'><b>Dee Gordon</b> hapless at the plate</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86193/evan-longoria-drives-two.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3342.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86193/evan-longoria-drives-two.php'><b>Evan Longoria</b> drives in two</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86192/daniel-murphy-with-multi-hit-game.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3256.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86192/daniel-murphy-with-multi-hit-game.php'><b>Daniel Murphy</b> with a multi-hit game</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86191/albert-pujols-with-big-game.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3027.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86191/albert-pujols-with-big-game.php'><b>Albert Pujols</b> with a big game</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86190/ian-desmond-productive-against-mariners.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3408.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86190/ian-desmond-productive-against-mariners.php'><b>Ian Desmond</b> productive against the Mariners</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86189/adrian-beltre-with-double-run-scored-.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3025.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86189/adrian-beltre-with-double-run-scored-.php'><b>Adrian Beltre</b> with a double and run scored </a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86188/kyle-seager-scores-run-against-texas.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/4213.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86188/kyle-seager-scores-run-against-texas.php'><b>Kyle Seager</b> scores a run against Texas</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86187/rougned-odor-with-rbi-on-monday.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/4776.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86187/rougned-odor-with-rbi-on-monday.php'><b>Rougned Odor</b> with an RBI on Monday</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86186/todd-frazier-hitless-two-consecutive-games.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3957.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86186/todd-frazier-hitless-two-consecutive-games.php'><b>Todd Frazier</b> hitless in two consecutive games</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86185/joey-votto-with-home-run-reds-9-2-loss-to-angels.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/3535.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86185/joey-votto-with-home-run-reds-9-2-loss-to-angels.php'><b>Joey Votto</b> with a home run in Reds 9-2 loss to the Angels</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/mlb/news/86184/bryce-harper-with-run-scored-on-monday.php'><img src='//images.fantasypros.com/images/mlb/players/210x210/4293.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/mlb/news/86184/bryce-harper-with-run-scored-on-monday.php'><b>Bryce Harper</b> with a run scored on Monday</a></div></td></table></div><div class='photo-box p-news-item read-more'><table><tr><td class='photo'>&nbsp;</td><td class='text'><div class='title'><a href='/mlb/player-news.php'>View All News</a></div></td></table></div></div><div class='news-pane clearfix' id='player-news-nba'><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/86206/joffrey-lauvergne-traded-to-thunder.php'><img src='//images.fantasypros.com/images/nba/players/210x210/3002.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/86206/joffrey-lauvergne-traded-to-thunder.php'><b>Joffrey Lauvergne</b> traded to the Thunder</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/86088/joel-embiid-feels-100-healthy.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2905.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/86088/joel-embiid-feels-100-healthy.php'><b>Joel Embiid</b> feels 100% healthy</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/86027/ty-lawson-agrees-to-deal-with-sacramento-.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2107.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/86027/ty-lawson-agrees-to-deal-with-sacramento-.php'><b>Ty Lawson</b> agrees to a deal with Sacramento </a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/86026/ty-lawson-signs-1-year-deal-with-kings.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2107.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/86026/ty-lawson-signs-1-year-deal-with-kings.php'><b>Ty Lawson</b> signs 1-year deal with Kings</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85658/jeff-withey-now-third-center-on-jazz-roster.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2820.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85658/jeff-withey-now-third-center-on-jazz-roster.php'><b>Jeff Withey</b> now the third center on the Jazz roster</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85654/andre-drummond-needs-to-improve-mentally.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2718.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85654/andre-drummond-needs-to-improve-mentally.php'><b>Andre Drummond</b> needs to improve mentally</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85653/marc-gasol-recovery-going-expected.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2219.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85653/marc-gasol-recovery-going-expected.php'><b>Marc Gasol</b> recovery going as expected</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85545/demarcus-cousins-win-olympic-gold.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2408.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85545/demarcus-cousins-win-olympic-gold.php'><b>DeMarcus Cousins</b> wins Olympic Gold</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85379/kwame-brown-eyeing-comeback-.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2034.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85379/kwame-brown-eyeing-comeback-.php'><b>Kwame Brown</b> eyeing a comeback </a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85372/brandon-ingram-signs-with-los-angeles-lakers.php'><img src='//images.fantasypros.com/images/photo_missing_square.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85372/brandon-ingram-signs-with-los-angeles-lakers.php'><b>Brandon Ingram</b> signs with the Los Angeles Lakers</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85371/brandon-ingram-signs-with-los-angeles-ingram.php'><img src='//images.fantasypros.com/images/photo_missing_square.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85371/brandon-ingram-signs-with-los-angeles-ingram.php'><b>Brandon Ingram</b> signs with the Los Angeles Lakers</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85275/hassan-whiteside-could-see-more-minutes-2016-17.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2423.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85275/hassan-whiteside-could-see-more-minutes-2016-17.php'><b>Hassan Whiteside</b> could see more minutes in 2016-17</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85274/john-wall-hoping-to-return-season-opener.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2489.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85274/john-wall-hoping-to-return-season-opener.php'><b>John Wall</b> hoping to return for season opener</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/85271/joel-embiid.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2905.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/85271/joel-embiid.php'><b>Joel Embiid</b> on track to play this preseason</a></div></td></table></div><div class='photo-box p-news-item'><table><tr><td class='photo'><a href='/nba/news/84739/ricky-rubio-has-sparked-interest-kings.php'><img src='//images.fantasypros.com/images/nba/players/210x210/2273.jpg' title=' photo' onError='this.src='//images.fantasypros.com/images/photo_missing_square.jpg';'></a></td><td class='text'><div class='extra'><a href='/nba/news/84739/ricky-rubio-has-sparked-interest-kings.php'><b>Ricky Rubio</b> has sparked the interest of the Kings</a></div></td></table></div><div class='photo-box p-news-item read-more'><table><tr><td class='photo'>&nbsp;</td><td class='text'><div class='title'><a href='/nba/player-news.php'>View All News</a></div></td></table></div></div></section><div class='ad-300'><!-- fantasypros_nfl_content_sidebar_300x250_2 -->
<div id='div-gpt-ad-1349068144086-10' style='width:300px; height:250px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1349068144086-10'); });
</script>
</div>
</div><section id='side_rankings' class='tab-wrap section-wrap'>
        <div class='heading'><a href='/nfl/rankings/consensus-cheatsheets.php'>Consensus Rankings</a></div>
        <div class='no-xl top-read-more'><a href='/nfl/rankings/consensus-cheatsheets.php'>View All Rankings</a></div><ul class='side-menu side-menu-pills'><li><a href='#ecr-nfl'>NFL</a></li><li><a href='#ecr-mlb'>MLB</a></li><li><a href='#ecr-nba'>NBA</a></li></ul><div class='clearfix'></div><div class='ecr-pane clearfix' id='ecr-nfl'><table class='table table-full rank-table'><tr><td><span class='rank-icon'>1</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/antonio-brown.php?week=draft'>Antonio Brown</a> <small>(PIT)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>2</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/odell-beckham.php?week=draft'>Odell Beckham Jr.</a> <small>(NYG)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>3</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/julio-jones.php?week=draft'>Julio Jones</a> <small>(ATL)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>4</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/todd-gurley.php?week=draft'>Todd Gurley</a> <small>(LA)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>5</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/david-johnson-rb.php?week=draft'>David Johnson</a> <small>(ARI)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>6</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/adrian-peterson-min.php?week=draft'>Adrian Peterson</a> <small>(MIN)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>7</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/aj-green.php?week=draft'>A.J. Green</a> <small>(CIN)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>8</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/deandre-hopkins.php?week=draft'>DeAndre Hopkins</a> <small>(HOU)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>9</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/ezekiel-elliott.php?week=draft'>Ezekiel Elliott</a> <small>(DAL)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>10</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/lamar-miller.php?week=draft'>Lamar Miller</a> <small>(HOU)</small></td><td class='pos'>RB</td></tr><tr class='read-more'><td>&nbsp;</td><td class='read-more'><a href='/nfl/rankings/consensus-cheatsheets.php'>View All Rankings</a></td><td>&nbsp;</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>11</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/rob-gronkowski.php?week=draft'>Rob Gronkowski</a> <small>(NE)</small></td><td class='pos'>TE</td></tr><tr><td><span class='rank-icon'>12</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/allen-robinson.php?week=draft'>Allen Robinson</a> <small>(JAC)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>13</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/dez-bryant.php?week=draft'>Dez Bryant</a> <small>(DAL)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>14</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/leveon-bell.php?week=draft'>Le'Veon Bell</a> <small>(PIT)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>15</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/jamaal-charles.php?week=draft'>Jamaal Charles</a> <small>(KC)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>16</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/mike-evans.php?week=draft'>Mike Evans</a> <small>(TB)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>17</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/brandon-marshall.php?week=draft'>Brandon Marshall</a> <small>(NYJ)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>18</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/jordy-nelson.php?week=draft'>Jordy Nelson</a> <small>(GB)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>19</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/mark-ingram.php?week=draft'>Mark Ingram</a> <small>(NO)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>20</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/alshon-jeffery.php?week=draft'>Alshon Jeffery</a> <small>(CHI)</small></td><td class='pos'>WR</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>21</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/devonta-freeman.php?week=draft'>Devonta Freeman</a> <small>(ATL)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>22</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/keenan-allen.php?week=draft'>Keenan Allen</a> <small>(SD)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>23</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/lesean-mccoy.php?week=draft'>LeSean McCoy</a> <small>(BUF)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>24</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/doug-martin.php?week=draft'>Doug Martin</a> <small>(TB)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>25</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/eddie-lacy.php?week=draft'>Eddie Lacy</a> <small>(GB)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>26</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/brandin-cooks.php?week=draft'>Brandin Cooks</a> <small>(NO)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>27</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/amari-cooper.php?week=draft'>Amari Cooper</a> <small>(OAK)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>28</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/ty-hilton.php?week=draft'>T.Y. Hilton</a> <small>(IND)</small></td><td class='pos'>WR</td></tr><tr><td><span class='rank-icon'>29</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/cj-anderson.php?week=draft'>C.J. Anderson</a> <small>(DEN)</small></td><td class='pos'>RB</td></tr><tr><td><span class='rank-icon'>30</span></td><td class='player-name'><a href='https://www.fantasypros.com/nfl/players/sammy-watkins.php?week=draft'>Sammy Watkins</a> <small>(BUF)</small></td><td class='pos'>WR</td></tr></table></div><div class='ecr-pane clearfix' id='ecr-mlb'><table class='table table-full rank-table'><tr><td><span class='rank-icon'>1</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/mike-trout.php'>Mike Trout</a> <small>(LAA)</small></td><td class='pos'>CF,DH</td></tr><tr><td><span class='rank-icon'>2</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/paul-goldschmidt.php'>Paul Goldschmidt</a> <small>(ARI)</small></td><td class='pos'>1B</td></tr><tr><td><span class='rank-icon'>3</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/josh-donaldson.php'>Josh Donaldson</a> <small>(TOR)</small></td><td class='pos'>3B,DH</td></tr><tr><td><span class='rank-icon'>4</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/nolan-arenado.php'>Nolan Arenado</a> <small>(COL)</small></td><td class='pos'>3B</td></tr><tr><td><span class='rank-icon'>5</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/jose-altuve.php'>Jose Altuve</a> <small>(HOU)</small></td><td class='pos'>2B,DH</td></tr><tr><td><span class='rank-icon'>6</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/anthony-rizzo.php'>Anthony Rizzo</a> <small>(CHC)</small></td><td class='pos'>1B</td></tr><tr><td><span class='rank-icon'>7</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/bryce-harper.php'>Bryce Harper</a> <small>(WSH)</small></td><td class='pos'>CF,RF</td></tr><tr><td><span class='rank-icon'>8</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/mookie-betts.php'>Mookie Betts</a> <small>(BOS)</small></td><td class='pos'>CF,RF</td></tr><tr><td><span class='rank-icon'>9</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/manny-machado.php'>Manny Machado</a> <small>(BAL)</small></td><td class='pos'>3B,SS</td></tr><tr><td><span class='rank-icon'>10</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/miguel-cabrera.php'>Miguel Cabrera</a> <small>(DET)</small></td><td class='pos'>1B,DH</td></tr><tr class='read-more'><td>&nbsp;</td><td class='read-more'><a href='/mlb/rankings/ros-overall.php'>View All Rankings</a></td><td>&nbsp;</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>11</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/kris-bryant.php'>Kris Bryant</a> <small>(CHC)</small></td><td class='pos'>3B,LF</td></tr><tr><td><span class='rank-icon'>12</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/max-scherzer.php'>Max Scherzer</a> <small>(WSH)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>13</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/edwin-encarnacion.php'>Edwin Encarnacion</a> <small>(TOR)</small></td><td class='pos'>1B,DH</td></tr><tr><td><span class='rank-icon'>14</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/madison-bumgarner.php'>Madison Bumgarner</a> <small>(SF)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>15</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/jake-arrieta.php'>Jake Arrieta</a> <small>(CHC)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>16</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/carlos-correa.php'>Carlos Correa</a> <small>(HOU)</small></td><td class='pos'>SS</td></tr><tr><td><span class='rank-icon'>17</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/starling-marte.php'>Starling Marte</a> <small>(PIT)</small></td><td class='pos'>LF,CF</td></tr><tr><td><span class='rank-icon'>18</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/chris-sale.php'>Chris Sale</a> <small>(CWS)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>19</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/george-springer.php'>George Springer</a> <small>(HOU)</small></td><td class='pos'>CF,RF</td></tr><tr><td><span class='rank-icon'>20</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/jose-fernandez.php'>Jose Fernandez</a> <small>(MIA)</small></td><td class='pos'>SP</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>21</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/carlos-gonzalez.php'>Carlos Gonzalez</a> <small>(COL)</small></td><td class='pos'>RF</td></tr><tr><td><span class='rank-icon'>22</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/nelson-cruz.php'>Nelson Cruz</a> <small>(SEA)</small></td><td class='pos'>RF,DH</td></tr><tr><td><span class='rank-icon'>23</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/joey-votto.php'>Joey Votto</a> <small>(CIN)</small></td><td class='pos'>1B</td></tr><tr><td><span class='rank-icon'>24</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/charlie-blackmon.php'>Charlie Blackmon</a> <small>(COL)</small></td><td class='pos'>LF,CF</td></tr><tr><td><span class='rank-icon'>25</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/corey-kluber.php'>Corey Kluber</a> <small>(CLE)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>26</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/ryan-braun.php'>Ryan Braun</a> <small>(MIL)</small></td><td class='pos'>LF,RF</td></tr><tr><td><span class='rank-icon'>27</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/andrew-mccutchen.php'>Andrew McCutchen</a> <small>(PIT)</small></td><td class='pos'>CF</td></tr><tr><td><span class='rank-icon'>28</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/stephen-strasburg.php'>Stephen Strasburg</a> <small>(WSH)</small></td><td class='pos'>SP</td></tr><tr><td><span class='rank-icon'>29</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/xander-bogaerts.php'>Xander Bogaerts</a> <small>(BOS)</small></td><td class='pos'>SS</td></tr><tr><td><span class='rank-icon'>30</span></td><td class='player-name'><a href='https://www.fantasypros.com/mlb/players/robinson-cano.php'>Robinson Cano</a> <small>(SEA)</small></td><td class='pos'>2B</td></tr></table></div><div class='ecr-pane clearfix' id='ecr-nba'><table class='table table-full rank-table'><tr><td><span class='rank-icon'>1</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/anthony-davis.php'>Anthony Davis</a> <small>(NOR)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>2</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/stephen-curry.php'>Stephen Curry</a> <small>(GSW)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>3</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/james-harden.php'>James Harden</a> <small>(HOU)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>4</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/russell-westbrook.php'>Russell Westbrook</a> <small>(OKC)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>5</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/chris-paul.php'>Chris Paul</a> <small>(LAC)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>6</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/lebron-james.php'>LeBron James</a> <small>(CLE)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>7</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/kevin-durant.php'>Kevin Durant</a> <small>(GSW)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>8</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/demarcus-cousins.php'>DeMarcus Cousins</a> <small>(SAC)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>9</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/damian-lillard.php'>Damian Lillard</a> <small>(POR)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>10</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/john-wall.php'>John Wall</a> <small>(WAS)</small></td><td class='pos'>G</td></tr><tr class='read-more'><td>&nbsp;</td><td class='read-more'><a href='/nba/rankings/overall.php'>View 2016 Rankings</a></td><td>&nbsp;</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>11</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/kawhi-leonard.php'>Kawhi Leonard</a> <small>(SAS)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>12</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/klay-thompson.php'>Klay Thompson</a> <small>(GSW)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>13</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/jimmy-butler.php'>Jimmy Butler</a> <small>(CHI)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>14</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/paul-millsap.php'>Paul Millsap</a> <small>(ATL)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>15</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/marc-gasol.php'>Marc Gasol</a> <small>(MEM)</small></td><td class='pos'>C</td></tr><tr><td><span class='rank-icon'>16</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/blake-griffin.php'>Blake Griffin</a> <small>(LAC)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>17</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/carmelo-anthony.php'>Carmelo Anthony</a> <small>(NYK)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>18</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/lamarcus-aldridge.php'>LaMarcus Aldridge</a> <small>(SAS)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>19</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/serge-ibaka.php'>Serge Ibaka</a> <small>(ORL)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>20</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/rudy-gobert.php'>Rudy Gobert</a> <small>(UTH)</small></td><td class='pos'>C</td></tr></table><table class='table table-full rank-table'><tr><td><span class='rank-icon'>21</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/eric-bledsoe.php'>Eric Bledsoe</a> <small>(PHO)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>22</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/al-horford.php'>Al Horford</a> <small>(BOS)</small></td><td class='pos'>C</td></tr><tr><td><span class='rank-icon'>23</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/kyle-lowry.php'>Kyle Lowry</a> <small>(TOR)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>24</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/paul-george.php'>Paul George</a> <small>(IND)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>25</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/nikola-vucevic.php'>Nikola Vucevic</a> <small>(ORL)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>26</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/draymond-green.php'>Draymond Green</a> <small>(GSW)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>27</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/kevin-love.php'>Kevin Love</a> <small>(CLE)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>28</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/pau-gasol.php'>Pau Gasol</a> <small>(SAS)</small></td><td class='pos'>F</td></tr><tr><td><span class='rank-icon'>29</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/gordon-hayward.php'>Gordon Hayward</a> <small>(UTH)</small></td><td class='pos'>G</td></tr><tr><td><span class='rank-icon'>30</span></td><td class='player-name'><a href='http://www.fantasypros.com/nba/players/deandre-jordan.php'>DeAndre Jordan</a> <small>(LAC)</small></td><td class='pos'>C</td></tr></table></div><div class='clearfix'></div></section><div class='ad-300'><!-- fantasypros_nfl_content_sidebar_300x250_3 -->
<div id='div-gpt-ad-1349068144086-11' style='width:300px; height:250px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1349068144086-11'); });
</script>
</div>
</div>
        <div class='ad-300 ad-mobile'>
            <!-- fantasypros_nfl_content_content_300x250_m2 -->
<div id='div-gpt-ad-1425357685381-0' style='width:300px; height:250px;'>
<script type='text/javascript'>
googletag.cmd.push(function() { googletag.display('div-gpt-ad-1425357685381-0'); });
</script>
</div>
        </div>

    </div>
</div> <!-- /.side-content -->


    </div> <!-- /.main-content-wrap -->
</div> <!-- /.container -->

<div id='tier-edit' class='modal fade' tabindex='-1' role='dialog'>
    <div class='modal-dialog'>
        <div class='modal-content'>
            <div class='modal-header' style='background-color:#081d3f;'>
                <a type='button' class='close pull-right' data-dismiss='modal' aria-label='Close'><span aria-hidden='true' style='color:white; font-size:16px; font-weight:bold;'>&times;</span></a>
                <h4 style='text-align:center; margin: 3px 0 0 0; color:white; '>Customize your Cheat Sheet</h4>
            </div>
            <div class='modal-body'>
                <div class='clearfix' style='text-align:center; margin:20px 0 20px 0;'>
                    <span style='font-size:16px;'>
                        Edit tiers and adjust ranks with our premium Cheat Sheet Creator.<br>Your new cheat sheet will automatically track taken players at your draft!
                    </span>
                </div>
                <div class='clearfix' style='text-align:center; margin:20px 0;'>
                    <a href='http://draftwizard.fantasypros.com/editor/create.jsp?sport=nfl&partner=tiers' class='btn btn-large btn-primary' style='width: 190px; margin-bottom: 8px;'>Go now</a>
                </div>
            </div>
        </div>
    </div>
</div>

<div id='edit-experts' class='modal fade ' tabindex='-1' role='dialog'>
      <div class='modal-dialog'>
        <div class='modal-content'>
          <div class='modal-header'>
            <a type='button' class='close pull-right' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></a>
            <h4 class='modal-title'>Pick Experts</h4>
          </div>
          <div class='modal-body'>  <form id='filters' action='/nfl/rankings/consensus-cheatsheets.php' method='post'>
  <input type='hidden' name='scoring' value='STD'>
  <input type='hidden' name='week' value='0'>
  <div class=''>
    <div class='pull-left'>
      <h5 class='select-experts'>Select the sources you want to include</h5>
          </div>
    <div class='pull-right'>
          </div>
    <div class='clearfix'></div>
  </div>
  <div class=''>
    <div class='pull-left'>
      <select id='set-experts' style='width:175px; font-size:12px;'>
                          <option value='default'>Default ECR</option>
                                                            <optgroup label='Recency'>
          <option value='week'>Updated Last 7 Days</option>
          <option value='recent'>Updated Last 14 Days</option>
        </optgroup>
                        <optgroup label='2015 In-Season Accuracy'>
                          <option value='top10'>Top 10 Overall</option>
          <option value='top20'>Top 20 Overall</option>
                        </optgroup>
                <optgroup label='2015 Draft Accuracy'>
                  <option value='top10d'>Top 10 Overall</option>
          <option value='top20d'>Top 20 Overall</option>
                        </optgroup>
              </select>
    </div>
    <div class='pull-right'>
          </div>
    <div class='clearfix'></div>
      <div class='pull-left'>
                Default ECR = More accurate experts with recent updates
              </div>
      <div class='clearfix pad-below'></div>
      <table cellpadding='0' cellspacing='0' border='0' id='experts' class='table table-bordered table-condensed table-striped table-hover'>
        <thead>
          <tr>
            <th class='sorter-false' style='width:20px;'>
              <input type='checkbox' id='select-all' name='select-all' value=''  checked='checked'>
            </th>
            <th>Expert</th>
            <th>Site</th>
            <th class='overall accuracy'><a href='javascript:void(0)' rel='tooltip' class='tip' title='Accuracy Rank'>2015 In-Season</a></th>
            <th class='overall accuracy'><a href='javascript:void(0)' rel='tooltip' class='tip' title='Draft Accuracy Rank'>2015 Draft</a></th>            <th style='width:50px;'>Date</th>
          </tr>
        </thead>
        <tbody>
        <tr><td><input type='checkbox' name='expert[]' value='6' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/brandon-funston.php'>Brandon Funston</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#115</td><td class='overall accuracy'>#66</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='7' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/andy-behrens.php'>Andy Behrens</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#85</td><td class='overall accuracy'>#85</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='8' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/brad-evans.php'>Brad Evans</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#101</td><td class='overall accuracy'>#73</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='9' checked='checked' class='expert recent week default recent top50 top50d' />
</td><td><a href='/experts/scott-pianowski.php'>Scott Pianowski</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#25</td><td class='overall accuracy'>#39</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='15' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/scoutfantasy.php'>Staff Rankings</a></td><td><a href='http://www.scoutfantasy.com' target='_blank' onClick='ga('send', 'event', 'Site', 'ScoutFantasy', 'NFL Rankings');'>ScoutFantasy</a></td><td class='overall accuracy'>#23</td><td class='overall accuracy'>#72</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='22' checked='checked' class='expert recent week default recent top10 top20 top50 top50d' />
</td><td><a href='/experts/pat-fitzmaurice.php'>Pat Fitzmaurice</a></td><td><a href='http://thefootballgirl.com/index.html' target='_blank' onClick='ga('send', 'event', 'Site', 'The Football Girl', 'NFL Rankings');'>The Football Girl</a></td><td class='overall accuracy'>#9</td><td class='overall accuracy'>#27</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='23' checked='checked' class='expert recent week default recent top20d top50d' />
</td><td><a href='/experts/scott-engel.php'>Scott Engel</a></td><td><a href='http://rotoexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoExperts', 'NFL Rankings');'>RotoExperts</a></td><td class='overall accuracy'>#77</td><td class='overall accuracy'>#20</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='44' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/dave-richard.php'>Dave Richard</a></td><td><a href='http://www.cbssports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'CBS Sports', 'NFL Rankings');'>CBS Sports</a></td><td class='overall accuracy'>#92</td><td class='overall accuracy'>#94</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='45' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/jamey-eisenberg.php'>Jamey Eisenberg</a></td><td><a href='http://www.cbssports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'CBS Sports', 'NFL Rankings');'>CBS Sports</a></td><td class='overall accuracy'>#70</td><td class='overall accuracy'>#42</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='48' class='expert top10 top20 top50' />
</td><td><a href='/experts/michael-fabiano.php'>Michael Fabiano</a></td><td><a href='http://www.nfl.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'NFL.com', 'NFL Rankings');'>NFL.com</a></td><td class='overall accuracy'>#10</td><td class='overall accuracy'>#97</td><td>8/12</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='58' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/chet-gresham.php'>Chet Gresham</a></td><td><a href='http://walterfootball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'WalterFootball', 'NFL Rankings');'>WalterFootball</a></td><td class='overall accuracy'>#54</td><td class='overall accuracy'>#63</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='65' checked='checked' class='expert recent week default recent top5d top10d top20d top50d' />
</td><td><a href='/experts/kevin-roberts.php'>Kevin Roberts</a></td><td><a href='http://breakingfootball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Breaking Football', 'NFL Rankings');'>Breaking Football</a></td><td class='overall accuracy'>#76</td><td class='overall accuracy'>#4</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='66' checked='checked' class='expert recent week default recent top10d top20d top50d' />
</td><td><a href='/experts/derek-lofland.php'>Derek Lofland</a></td><td><a href='http://fantasyfootballmaniax.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Football Maniax', 'NFL Rankings');'>Fantasy Football Maniax</a></td><td class='overall accuracy'>#105</td><td class='overall accuracy'>#10</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='93' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/jared-smola.php'>Jared Smola</a></td><td><a href='http://draftsharks.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Draft Sharks', 'NFL Rankings');'>Draft Sharks</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#21</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='95' checked='checked' class='expert recent week default recent top50 top5d top10d top20d top50d' />
</td><td><a href='/experts/kevin-hanson.php'>Kevin Hanson</a></td><td><a href='http://www.eatdrinkandsleepfootball.com' target='_blank' onClick='ga('send', 'event', 'Site', 'EDSFootball', 'NFL Rankings');'>EDSFootball</a></td><td class='overall accuracy'>#38</td><td class='overall accuracy'>#2</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='96' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/ken-zalis.php'>Ken Zalis</a></td><td><a href='http://www.pressboxonline.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pressbox', 'NFL Rankings');'>Pressbox</a></td><td class='overall accuracy'>#62</td><td class='overall accuracy'>#93</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='101' checked='checked' class='expert recent week default recent top20 top50' />
</td><td><a href='/experts/matt-de-lima.php'>Matt De Lima</a></td><td><a href='http://www.scoutfantasy.com' target='_blank' onClick='ga('send', 'event', 'Site', 'ScoutFantasy', 'NFL Rankings');'>ScoutFantasy</a></td><td class='overall accuracy'>#17</td><td class='overall accuracy'></td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='115' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/evan-silva.php'>Evan Silva</a></td><td><a href='http://rotoworld.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Rotoworld', 'NFL Rankings');'>Rotoworld</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/25</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='120' checked='checked' class='expert recent week default recent top5 top10 top20 top50' />
</td><td><a href='/experts/sean-koerner.php'>Sean Koerner</a></td><td><a href='http://www.stats.com/insights/' target='_blank' onClick='ga('send', 'event', 'Site', 'STATS', 'NFL Rankings');'>STATS</a></td><td class='overall accuracy'>#1</td><td class='overall accuracy'>#103</td><td>8/25</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='124' class='expert top50 top50d' />
</td><td><a href='/experts/ross-miles.php'>Ross Miles</a></td><td><a href='http://www.profootballfocus.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pro Football Focus', 'NFL Rankings');'>Pro Football Focus</a></td><td class='overall accuracy'>#28</td><td class='overall accuracy'>#23</td><td>7/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='127' checked='checked' class='expert recent week default recent top20 top50 top50d' />
</td><td><a href='/experts/sablich-brothers-ny-times.php'>Sablich Brothers</a></td><td><a href='http://fifthdown.blogs.nytimes.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'The NY Times', 'NFL Rankings');'>The NY Times</a></td><td class='overall accuracy'>#14</td><td class='overall accuracy'>#35</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='140' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/michael-beller.php'>Michael Beller</a></td><td><a href='http://sportsillustrated.cnn.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Sports Illustrated', 'NFL Rankings');'>Sports Illustrated</a></td><td class='overall accuracy'>#90</td><td class='overall accuracy'></td><td>8/27</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='141' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/eric-mack.php'>Eric Mack</a></td><td><a href='https://www.facebook.com/EricMackSports' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Fatcast', 'NFL Rankings');'>Fantasy Fatcast</a></td><td class='overall accuracy'>#80</td><td class='overall accuracy'>#50</td><td>8/23</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='145' class='expert top50' />
</td><td><a href='/experts/jody-smith.php'>Jody Smith</a></td><td><a href='http://gridironexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Gridiron Experts', 'NFL Rankings');'>Gridiron Experts</a></td><td class='overall accuracy'>#21</td><td class='overall accuracy'>#78</td><td>4/21</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='148' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/rosterwatch-staff-rankings.php'>Staff Rankings</a></td><td><a href='http://rosterwatch.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RosterWatch', 'NFL Rankings');'>RosterWatch</a></td><td class='overall accuracy'>#42</td><td class='overall accuracy'>#117</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='150' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/mike-tagliere.php'>Mike Tagliere</a></td><td><a href='https://www.profootballfocus.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pro Football Focus', 'NFL Rankings');'>Pro Football Focus</a></td><td class='overall accuracy'>#60</td><td class='overall accuracy'>#38</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='155' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/fantasy-knuckleheads-staff-rankings.php'>Staff Rankings</a></td><td><a href='http://fantasyknuckleheads.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Knuckleheads', 'NFL Rankings');'>Fantasy Knuckleheads</a></td><td class='overall accuracy'>#111</td><td class='overall accuracy'>#36</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='156' checked='checked' class='expert recent week default recent top50 top20d top50d' />
</td><td><a href='/experts/greg-smith.php'>Greg Smith</a></td><td><a href='http://www.twoqbs.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'TwoQBs', 'NFL Rankings');'>TwoQBs</a></td><td class='overall accuracy'>#45</td><td class='overall accuracy'>#15</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='160' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/espn-rankings.php'>Staff Rankings</a></td><td><a href='http://espn.go.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'ESPN', 'NFL Rankings');'>ESPN</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#56</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='211' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/zach-greubel.php'>Zach Greubel</a></td><td><a href='http://gridironexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Gridiron Experts', 'NFL Rankings');'>Gridiron Experts</a></td><td class='overall accuracy'>#37</td><td class='overall accuracy'>#130</td><td>8/25</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='220' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/jeff-boggis.php'>Jeff Boggis</a></td><td><a href='http://www.fantasyfootballempire.com/ ' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Football Empire', 'NFL Rankings');'>Fantasy Football Empire</a></td><td class='overall accuracy'>#83</td><td class='overall accuracy'>#135</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='256' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/heath-cummings.php'>Heath Cummings</a></td><td><a href='http://www.cbssports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'CBS Sports', 'NFL Rankings');'>CBS Sports</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='260' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/jeff-brubach.php'>Jeff Brubach</a></td><td><a href='http://thefakefootball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'The Fake Football', 'NFL Rankings');'>The Fake Football</a></td><td class='overall accuracy'>#58</td><td class='overall accuracy'>#25</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='261' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/walton-spurlin.php'>Walton Spurlin</a></td><td><a href='http://www.fantasysharks.com/index.php' target='_blank' onClick='ga('send', 'event', 'Site', 'FantasySharks', 'NFL Rankings');'>FantasySharks</a></td><td class='overall accuracy'>#97</td><td class='overall accuracy'>#31</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='262' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/brent-namejko.php'>Brent Namejko</a></td><td><a href='http://www.fantasysmacktalk.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Smack Talk', 'NFL Rankings');'>Fantasy Smack Talk</a></td><td class='overall accuracy'>#75</td><td class='overall accuracy'>#136</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='263' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/raju-byfield.php'>Raju Byfield</a></td><td><a href='http://winmyfantasyleague.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Win My Fantasy League', 'NFL Rankings');'>Win My Fantasy League</a></td><td class='overall accuracy'>#99</td><td class='overall accuracy'>#114</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='285' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/dalton-del-don.php'>Dalton Del Don</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#24</td><td class='overall accuracy'>#75</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='293' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/james-hatfield.php'>James Hatfield</a></td><td><a href='http://www.hattywaiverwireguru.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Hatty Waiver Wire Guru', 'NFL Rankings');'>Hatty Waiver Wire Guru</a></td><td class='overall accuracy'>#55</td><td class='overall accuracy'>#108</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='317' checked='checked' class='expert recent week default recent top10 top20 top50 top10d top20d top50d' />
</td><td><a href='/experts/justin-boone.php'>Justin Boone</a></td><td><a href='http://www.thescore.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'theScore', 'NFL Rankings');'>theScore</a></td><td class='overall accuracy'>#7</td><td class='overall accuracy'>#7</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='323' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/matt-schauf.php'>Matt Schauf</a></td><td><a href='http://draftsharks.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Draft Sharks', 'NFL Rankings');'>Draft Sharks</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#87</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='328' class='expert top50 top20d top50d' />
</td><td><a href='/experts/dawgmatica.php'>Staff Rankings</a></td><td><a href='http://www.pyromaniac.com' target='_blank' onClick='ga('send', 'event', 'Site', 'Pyromaniac', 'NFL Rankings');'>Pyromaniac</a></td><td class='overall accuracy'>#44</td><td class='overall accuracy'>#13</td><td>8/18</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='329' class='expert' />
</td><td><a href='/experts/david-biggs.php'>David Biggs</a></td><td><a href='http://www.drinkfive.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Drink Five', 'NFL Rankings');'>Drink Five</a></td><td class='overall accuracy'>#118</td><td class='overall accuracy'>#134</td><td>8/13</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='339' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/kj.php'>KJ</a></td><td><a href='http://fantasyteamadvice.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Team Advice', 'NFL Rankings');'>Fantasy Team Advice</a></td><td class='overall accuracy'>#121</td><td class='overall accuracy'>#45</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='350' class='expert' />
</td><td><a href='/experts/tony-mauriello.php'>Tony Mauriello</a></td><td><a href='http://projectroto.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'ProjectRoto', 'NFL Rankings');'>ProjectRoto</a></td><td class='overall accuracy'>#87</td><td class='overall accuracy'>#98</td><td>8/12</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='363' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/terrance-bridgett.php'>Terrance Bridgett</a></td><td><a href='http://www.fantasysixpack.net/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Six Pack', 'NFL Rankings');'>Fantasy Six Pack</a></td><td class='overall accuracy'>#117</td><td class='overall accuracy'>#109</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='365' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/dave-mckay.php'>Dave McKay</a></td><td><a href='http://www.thefantasysportsbrain.com' target='_blank' onClick='ga('send', 'event', 'Site', 'The Fantasy Sports Brain', 'NFL Rankings');'>The Fantasy Sports Brain</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#113</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='366' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/ryan-hodge.php'>Ryan Hodge </a></td><td><a href='http://projectroto.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'ProjectRoto', 'NFL Rankings');'>ProjectRoto</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#124</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='377' class='expert' />
</td><td><a href='/experts/nick-vertucci.php'>Nick Vertucci</a></td><td><a href='http://sundaysareforfootball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Sundays Are For Football', 'NFL Rankings');'>Sundays Are For Football</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#137</td><td>7/26</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='380' checked='checked' class='expert recent week default recent top20d top50d' />
</td><td><a href='/experts/dan-clasgens.php'>Dan Clasgens</a></td><td><a href='http://getsportsinfo.com' target='_blank' onClick='ga('send', 'event', 'Site', 'Get Sports Info', 'NFL Rankings');'>Get Sports Info</a></td><td class='overall accuracy'>#56</td><td class='overall accuracy'>#14</td><td>8/25</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='384' checked='checked' class='expert recent week default recent top5 top10 top20 top50' />
</td><td><a href='/experts/sean-morris.php'>Sean Morris</a></td><td><a href='http://www.brunoboys.net' target='_blank' onClick='ga('send', 'event', 'Site', 'Bruno Boys', 'NFL Rankings');'>Bruno Boys</a></td><td class='overall accuracy'>#2</td><td class='overall accuracy'>#116</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='387' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/tozzi-brothers.php'>Tozzi Brothers</a></td><td><a href='http://www.legionreport.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Legion Report', 'NFL Rankings');'>Legion Report</a></td><td class='overall accuracy'>#29</td><td class='overall accuracy'>#64</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='390' checked='checked' class='expert recent week default recent top20 top50' />
</td><td><a href='/experts/marc-caviglia.php'>Marc Caviglia</a></td><td><a href='http://www.brunoboys.net/' target='_blank' onClick='ga('send', 'event', 'Site', 'Bruno Boys', 'NFL Rankings');'>Bruno Boys</a></td><td class='overall accuracy'>#18</td><td class='overall accuracy'>#62</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='395' class='expert' />
</td><td><a href='/experts/wayne-bretsky.php'>Wayne Bretsky</a></td><td><a href='http://bretskyball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'BretskyBall', 'NFL Rankings');'>BretskyBall</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#132</td><td>8/19</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='406' checked='checked' class='expert recent week default recent top5 top10 top20 top50 top20d top50d' />
</td><td><a href='/experts/jake-ciely.php'>Jake Ciely</a></td><td><a href='http://rotoexperts.com' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoExperts', 'NFL Rankings');'>RotoExperts</a></td><td class='overall accuracy'>#3</td><td class='overall accuracy'>#11</td><td>8/26</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='412' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/steve-wyremski.php'>Steve Wyremski</a></td><td><a href='http://dynastyleaguefootball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Dynasty League Football', 'NFL Rankings');'>Dynasty League Football</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='428' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/scott-whitfield.php'>Scott Whitfield</a></td><td><a href='http://www.rotorankings.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Roto Rankings', 'NFL Rankings');'>Roto Rankings</a></td><td class='overall accuracy'>#79</td><td class='overall accuracy'>#69</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='432' checked='checked' class='expert recent week default recent top5d top10d top20d top50d' />
</td><td><a href='/experts/joseph-dolan.php'>Joseph Dolan</a></td><td><a href='http://www.fantasyguru.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Guru', 'NFL Rankings');'>Fantasy Guru</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#1</td><td>8/26</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='435' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/kevin-english.php'>Kevin English</a></td><td><a href='http://draftsharks.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Draft Sharks', 'NFL Rankings');'>Draft Sharks</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#60</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='442' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/sean-beazley.php'>Sean Beazley</a></td><td><a href='http://www.eatdrinkandsleepfootball.com' target='_blank' onClick='ga('send', 'event', 'Site', 'EDSFootball', 'NFL Rankings');'>EDSFootball</a></td><td class='overall accuracy'>#91</td><td class='overall accuracy'>#125</td><td>8/26</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='443' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/jon-collins.php'>Jon Collins</a></td><td><a href='http://www.lockerroomfantasysports.com' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Sports LR', 'NFL Rankings');'>Fantasy Sports LR</a></td><td class='overall accuracy'>#106</td><td class='overall accuracy'>#61</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='453' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/huseyin-aksu.php'>Huseyin Aksu</a></td><td><a href='https://www.fantasycouch.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Couch', 'NFL Rankings');'>Fantasy Couch</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#86</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='454' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/joe-bond.php'>Joe Bond</a></td><td><a href='http://www.fantasysixpack.net/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Six Pack', 'NFL Rankings');'>Fantasy Six Pack</a></td><td class='overall accuracy'>#81</td><td class='overall accuracy'>#41</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='459' checked='checked' class='expert recent week default recent top5d top10d top20d top50d' />
</td><td><a href='/experts/raymond-summerlin.php'>Raymond Summerlin</a></td><td><a href='http://www.rotoworld.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Rotoworld', 'NFL Rankings');'>Rotoworld</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#3</td><td>8/27</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='468' checked='checked' class='expert recent week default recent top50 top50d' />
</td><td><a href='/experts/ben-standig.php'>Ben Standig</a></td><td><a href='http://www.csnmidatlantic.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'CSN Mid-Atlantic', 'NFL Rankings');'>CSN Mid-Atlantic</a></td><td class='overall accuracy'>#47</td><td class='overall accuracy'>#49</td><td>8/24</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='470' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/adam-pfeifer.php'>Adam Pfeifer</a></td><td><a href='http://projectroto.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'ProjectRoto', 'NFL Rankings');'>ProjectRoto</a></td><td class='overall accuracy'>#31</td><td class='overall accuracy'>#65</td><td>8/31</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='487' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/chris-meaney.php'>Chris Meaney</a></td><td><a href='http://fantasysportsnetwork.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'FNTSY Sports Network', 'NFL Rankings');'>FNTSY Sports Network</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#24</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='501' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/kelly-smelser.php'>Kelly Smelser</a></td><td><a href='http://www.punchdrunkwonderland.com' target='_blank' onClick='ga('send', 'event', 'Site', 'Punch Drunk Wonderland', 'NFL Rankings');'>Punch Drunk Wonderland</a></td><td class='overall accuracy'>#74</td><td class='overall accuracy'>#30</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='526' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/dennis-esser.php'>Dennis Esser</a></td><td><a href='http://www.coachesser.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Coach Esser', 'NFL Rankings');'>Coach Esser</a></td><td class='overall accuracy'>#64</td><td class='overall accuracy'>#26</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='527' class='expert' />
</td><td><a href='/experts/chris-heil.php'>Chris Heil</a></td><td><a href='http://fantasysportsrants.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Sports Rants', 'NFL Rankings');'>Fantasy Sports Rants</a></td><td class='overall accuracy'>#94</td><td class='overall accuracy'>#139</td><td>3/08</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='532' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/jason-longfellow.php'>Jason Longfellow</a></td><td><a href='http://football.razzball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Razzball', 'NFL Rankings');'>Razzball</a></td><td class='overall accuracy'>#22</td><td class='overall accuracy'>#70</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='534' checked='checked' class='expert recent week default recent top10 top20 top50 top20d top50d' />
</td><td><a href='/experts/patrick-thorman.php'>Patrick Thorman</a></td><td><a href='http://www.profootballfocus.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pro Football Focus', 'NFL Rankings');'>Pro Football Focus</a></td><td class='overall accuracy'>#6</td><td class='overall accuracy'>#19</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='540' class='expert top50 top50d' />
</td><td><a href='/experts/nathan-jahnke.php'>Nathan Jahnke</a></td><td><a href='http://www.profootballfocus.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pro Football Focus', 'NFL Rankings');'>Pro Football Focus</a></td><td class='overall accuracy'>#35</td><td class='overall accuracy'>#28</td><td>8/16</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='542' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/russell-clay.php'>Russell Clay</a></td><td><a href='https://www.dailyfantasycafe.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Daily Fantasy Cafe', 'NFL Rankings');'>Daily Fantasy Cafe</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#74</td><td>8/25</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='549' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/ryan-noonan.php'>Ryan Noonan</a></td><td><a href='http://www.thefantasyfix.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'The Fantasy Fix', 'NFL Rankings');'>The Fantasy Fix</a></td><td class='overall accuracy'>#36</td><td class='overall accuracy'>#95</td><td>8/26</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='552' checked='checked' class='expert recent week default recent top50 top10d top20d top50d' />
</td><td><a href='/experts/matthew-hill.php'>Matthew Hill</a></td><td><a href='https://www.dataforceff.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'DataForce Fantasy Football', 'NFL Rankings');'>DataForce Fantasy Football</a></td><td class='overall accuracy'>#43</td><td class='overall accuracy'>#6</td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='553' checked='checked' class='expert recent week default recent top10d top20d top50d' />
</td><td><a href='/experts/addison-witt.php'>Addison Witt</a></td><td><a href='http://fantasyteamadvice.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Team Advice', 'NFL Rankings');'>Fantasy Team Advice</a></td><td class='overall accuracy'>#86</td><td class='overall accuracy'>#8</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='561' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/gene-wang.php'>Gene Wang</a></td><td><a href='http://www.washingtonpost.com/sports/' target='_blank' onClick='ga('send', 'event', 'Site', 'The Washington Post', 'NFL Rankings');'>The Washington Post</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#120</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='562' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/des-bieler.php'>Des Bieler</a></td><td><a href='http://www.washingtonpost.com/sports/' target='_blank' onClick='ga('send', 'event', 'Site', 'The Washington Post', 'NFL Rankings');'>The Washington Post</a></td><td class='overall accuracy'>#51</td><td class='overall accuracy'>#37</td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='565' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/smitty.php'>Smitty</a></td><td><a href='http://sleeperu.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'SleeperU', 'NFL Rankings');'>SleeperU</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#126</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='590' checked='checked' class='expert recent week default recent top50' />
</td><td><a href='/experts/emil-kadlec.php'>Emil Kadlec</a></td><td><a href='http://www.footballdiehards.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Football Diehards', 'NFL Rankings');'>Football Diehards</a></td><td class='overall accuracy'>#41</td><td class='overall accuracy'></td><td>8/24</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='603' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/george-kurtz.php'>George Kurtz</a></td><td><a href='http://rotoexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoExperts', 'NFL Rankings');'>RotoExperts</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='620' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/so-called-fantasy-experts.php'>David Gonos</a></td><td><a href='http://socalledfantasyexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'SoCalledFanEx', 'NFL Rankings');'>SoCalledFanEx</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#100</td><td>8/27</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='638' checked='checked' class='expert recent week default recent top20d top50d' />
</td><td><a href='/experts/adam-ronis.php'>Adam Ronis</a></td><td><a href='http://rotoexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoExperts', 'NFL Rankings');'>RotoExperts</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#12</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='644' class='expert' />
</td><td><a href='/experts/brad-pinkerton.php'>Brad Pinkerton</a></td><td><a href='http://www.sportingnews.com/fantasy' target='_blank' onClick='ga('send', 'event', 'Site', 'Sporting News', 'NFL Rankings');'>Sporting News</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>6/14</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='649' class='expert' />
</td><td><a href='/experts/chris-meyers.php'>Chris Meyers</a></td><td><a href='http://athlonsports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Athlon Sports', 'NFL Rankings');'>Athlon Sports</a></td><td class='overall accuracy'>#120</td><td class='overall accuracy'>#101</td><td>8/19</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='678' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/donald-gibson.php'>Donald Gibson</a></td><td><a href='http://www.fantasyfusionsports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Fusion', 'NFL Rankings');'>Fantasy Fusion</a></td><td class='overall accuracy'>#88</td><td class='overall accuracy'>#77</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='684' class='expert' />
</td><td><a href='/experts/edward-gorelik.php'>Edward Gorelik</a></td><td><a href='http://www.rotoballer.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoBaller', 'NFL Rankings');'>RotoBaller</a></td><td class='overall accuracy'>#89</td><td class='overall accuracy'>#90</td><td>4/03</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='685' checked='checked' class='expert recent week default recent top50d' />
</td><td><a href='/experts/adam-sutton.php'>Adam Sutton</a></td><td><a href='http://www.draftstars.net/' target='_blank' onClick='ga('send', 'event', 'Site', 'DraftStars', 'NFL Rankings');'>DraftStars</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#29</td><td>8/27</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='687' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/tehol-beddict.php'>Tehol Beddict</a></td><td><a href='http://razzball.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Razzball', 'NFL Rankings');'>Razzball</a></td><td class='overall accuracy'>#93</td><td class='overall accuracy'>#89</td><td>8/24</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='688' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/adam-inman.php'>Adam Inman</a></td><td><a href='http://fflockerroom.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'FFLockerRoom', 'NFL Rankings');'>FFLockerRoom</a></td><td class='overall accuracy'>#98</td><td class='overall accuracy'>#51</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='689' class='expert' />
</td><td><a href='/experts/mark-ross.php'>Mark Ross</a></td><td><a href='http://athlonsports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Athlon Sports', 'NFL Rankings');'>Athlon Sports</a></td><td class='overall accuracy'></td><td class='overall accuracy'>#82</td><td>8/13</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='690' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/kevin-steele.php'>Kevin Steele</a></td><td><a href='http://www.thefantasyauthority.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'The Fantasy Authority', 'NFL Rankings');'>The Fantasy Authority</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/31</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='699' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/liz-loza.php'>Liz Loza</a></td><td><a href='http://www.anrdoezrs.net/click-5519530-12299838-1441750611000' target='_blank' onClick='ga('send', 'event', 'Site', 'Yahoo! Sports', 'NFL Rankings');'>Yahoo! Sports</a></td><td class='overall accuracy'>#67</td><td class='overall accuracy'>#59</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='700' class='expert' />
</td><td><a href='/experts/george-banko.php'>George Banko</a></td><td><a href='http://fantasyfootballhelpers.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Football Helpers', 'NFL Rankings');'>Fantasy Football Helpers</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/19</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='701' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/taylor-christianson.php'>Taylor Christianson</a></td><td><a href='http://fflockerroom.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'FFLockerRoom', 'NFL Rankings');'>FFLockerRoom</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='702' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/matt-camp.php'>Matt Camp</a></td><td><a href='http://bleacherreport.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Bleacher Report', 'NFL Rankings');'>Bleacher Report</a></td><td class='overall accuracy'>#103</td><td class='overall accuracy'>#55</td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='710' class='expert' />
</td><td><a href='/experts/matt-franciscovich.php'>Matt Franciscovich</a></td><td><a href='http://www.nfl.com' target='_blank' onClick='ga('send', 'event', 'Site', 'NFL.com', 'NFL Rankings');'>NFL.com</a></td><td class='overall accuracy'>#114</td><td class='overall accuracy'>#118</td><td>7/08</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='714' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/michael-tomlin.php'>Michael Tomlin</a></td><td><a href='http://socalledfantasyexperts.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'SoCalledFanEx', 'NFL Rankings');'>SoCalledFanEx</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='741' class='expert' />
</td><td><a href='/experts/dorian-colbert.php'>Dorian Colbert</a></td><td><a href='http://rosterwatch.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RosterWatch', 'NFL Rankings');'>RosterWatch</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/09</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='765' class='expert' />
</td><td><a href='/experts/bill-dubiel.php'>Bill Dubiel</a></td><td><a href='http://www.rotoballer.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoBaller', 'NFL Rankings');'>RotoBaller</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>4/28</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='766' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/nick-mariano.php'>Nick Mariano</a></td><td><a href='http://www.rotoballer.com/author/trailrunner' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoBaller', 'NFL Rankings');'>RotoBaller</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='771' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/bob-lung.php'>Bob Lung</a></td><td><a href='http://www.bigguyfantasysports.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Big Guy Fantasy Sports', 'NFL Rankings');'>Big Guy Fantasy Sports</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='786' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/scott-smith.php'>Scott Smith</a></td><td><a href='http://www.rotoviz.com' target='_blank' onClick='ga('send', 'event', 'Site', 'RotoViz', 'NFL Rankings');'>RotoViz</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/29</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='823' class='expert' />
</td><td><a href='/experts/anthony-staggs.php'>Anthony Staggs</a></td><td><a href='http://www.pyromaniac.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Pyromaniac', 'NFL Rankings');'>Pyromaniac</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/18</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='836' class='expert' />
</td><td><a href='/experts/bill-latin.php'>Bill Latin</a></td><td><a href='http://dynastyfootballwarehouse.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Dynasty Football Warehouse', 'NFL Rankings');'>Dynasty Football Warehouse</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>7/19</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='858' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/Blake-Fincher.php'>Blake Fincher</a></td><td><a href='https://www.fantasyfootballcafe.com/' target='_blank' onClick='ga('send', 'event', 'Site', 'Fantasy Football Cafe', 'NFL Rankings');'>Fantasy Football Cafe</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/30</td></tr>
<tr><td><input type='checkbox' name='expert[]' value='877' checked='checked' class='expert recent week default recent' />
</td><td><a href='/experts/Nate-Lundy.php'>Nate Lundy</a></td><td><a href='http://www.5280sportsnetwork.com' target='_blank' onClick='ga('send', 'event', 'Site', '5280 Sports Network', 'NFL Rankings');'>5280 Sports Network</a></td><td class='overall accuracy'></td><td class='overall accuracy'></td><td>8/29</td></tr>
        </tbody>
      </table>
    </div>
          </form>
</div>
          <div class='modal-footer'><div class='clearfix' style='padding-top: 10px;'><a href='javascript:;' class='btn pull-left btn-secondary experts-modal-submit' type='submit'>Update</a>
  <a href='javascript:void(0)' class='btn pull-right close-experts' data-dismiss='modal' aria-hidden='true'>Close</a></div></div>
        </div><!-- /.modal-content -->
      </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
<div id='export' class='modal fade' tabindex='-1' role='dialog'>
    <div class='modal-dialog'>
        <div class='modal-content'>
            <div class='modal-header' style='background-color:#081d3f;'>
                <a type='button' class='close pull-right' data-dismiss='modal' aria-label='Close'><span aria-hidden='true' style='color:white; font-size:16px; font-weight:bold;'>&times;</span></a>
                <h4 style='text-align:center; margin: 3px 0 0 0; color:white; '>Free Download</h4>
            </div>
            <div class='modal-body' style='overflow-y:hidden;'>
                <div class='clearfix' style='text-align:center; margin:20px 0 20px 0;'>
                    <span style='font-size:16px;'>
                        Please log in or register for a FREE account to download this file.
                    </span>
                </div>
                <div class='clearfix' style='text-align:center; margin:20px 0;'>
                    <a href='https://secure.fantasypros.com/accounts/login/?next=https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php' class='btn btn-large btn-primary' style='width: 190px; margin-bottom: 8px;'>LOG IN</a>
                    <a href='https://secure.fantasypros.com/accounts/register/?next=https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php' class='btn btn-large' style='width: 190px;'>REGISTER</a>
                </div>
            </div>
        </div>
    </div>
</div>

    <footer>
        <div class='container'>
            <div class='column-row clearfix'>
                                    <div class='footer-column three columns'>
                        <h4><a href='/nfl/'>NFL Preseason</a></h4>
                        <ul>
                            <li><a href='/nfl/rankings/consensus-cheatsheets.php'>Expert Rankings</a></li>
                            <li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft Wizard</a></li>
                            <li><a href='/nfl/myplaybook/'>My Playbook</a></li>
                            <li><a href='/nfl/player-news.php'>Player News</a></li>
                            <li><a href='/nfl/articles/'>Articles</a></li>
                            <li><a href='/nfl/projections/qb.php?week=draft'>Projections</a></li>
                            <li><a href='/nfl/stats/leaders.php'>Statistics</a></li>
                            <li><a href='/nfl/adp/overall.php'>ADP Consensus</a></li>
                            <li><a href='/nfl/strength-of-schedule.php'>Strength of Schedule</a></li>
                            <li><a href='/nfl/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li>
                            <li><a href='/nfl/draft/'>Who Should I Draft?</a></li>
                        </ul>
                    </div>
                    <div class='footer-column three columns'>
                        <h4><a href='/nfl/'>NFL In-Season</a></h4>
                        <ul>
                            <li><a href='/nfl/rankings/qb.php'>Weekly Rankings</a></li>
                            <li><a href='http://draftwizard.fantasypros.com/?sport=nfl&partner=fpros'>Draft Wizard</a></li>
                            <li><a href='/nfl/rankings/ros-qb.php'>ROS Rankings</a></li>
                            <li><a href='/nfl/myplaybook/'>My Playbook</a></li>
                            <li><a href='/nfl/player-news.php'>Player News</a></li>
                            <li><a href='/nfl/articles/'>Articles</a></li>
                            <li><a href='/nfl/projections/qb.php'>Projections</a></li>
                            <li><a href='/nfl/stats/leaders.php'>Statistics</a></li>
                            <li><a href='/nfl/adp/overall.php'>ADP Consensus</a></li>
                            <li><a href='/nfl/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li>
                            <li><a href='/nfl/start/'>Who Should I Start?</a></li>
                        </ul>
                    </div>
                                <div class='footer-column three columns'>
                    <h4><a href='/mlb/'>MLB</a></h4>
                    <ul>
                        <li><a href='/mlb/rankings/ros-overall.php'>Expert Rankings</a></li>
                        <li><a href='https://draftwizard.fantasypros.com/?sport=mlb&partner=fpros'>Draft Wizard</a></li>
                        <li><a href='/mlb/myplaybook/'>My Playbook</a></li>
                        <li><a href='/mlb/player-news.php'>Player News</a></li>
                        <li><a href='/mlb/articles/'>Articles</a></li>
                        <li><a href='/mlb/projections/ros-hitters.php'>Projections</a></li>
                        <li><a href='/mlb/stats/leaders.php'>Statistics</a></li>
                        <li><a href='/mlb/adp/overall.php'>ADP Consensus</a></li>
                        <li><a href='/mlb/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li>
                        <li><a href='/mlb/start/'>Who Should I Start?</a></li>
                        <li><a href='/mlb/draft/'>Who Should I Draft?</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/nba/'>NBA</a></h4>
                    <ul>
                        <li><a href='/nba/rankings/ros-overall.php'>Expert Rankings</a></li>
                        <li><a href='https://draftwizard.fantasypros.com/?sport=nba&partner=fpros'>Draft Wizard</a></li>
                        <li><a href='/nba/myplaybook/'>My Playbook</a></li>
                        <li><a href='/nba/player-news.php'>Player News</a></li>
                        <li><a href='/nba/articles/'>Articles</a></li>
                        <li><a href='/nba/projections/overall.php'>Projections</a></li>
                        <li><a href='/nba/stats/leaders.php'>Statistics</a></li>
                        <li><a href='/nba/adp/overall.php'>ADP Consensus</a></li>
                        <li><a href='/nba/daily-fantasy-lineup-optimizer.php'>DFS Lineup Optimizer</a></li>
                        <li><a href='/nba/start/'>Who Should I Start?</a></li>
                        <li><a href='/nba/draft/'>Who Should I Draft?</a></li>
                    </ul>
                </div>
                            </div>
            <hr>
            <div class='column-row clearfix'>
                <div class='footer-column three columns'>
                    <h4><a href='http://draftwizard.fantasypros.com/?partner=fpros&sport=nfl'>Draft Wizard</a></h4>
                    <ul>
                        <li><a href='http://draftwizard.fantasypros.com/simulator/?partner=fpros&sport=nfl'>Draft Simulator</a></li>
                        <li><a href='http://draftwizard.fantasypros.com/analyzer/?partner=fpros&sport=nfl'>Draft Analyzer</a></li>
                        <li><a href='http://draftwizard.fantasypros.com/assistant/?partner=fpros&sport=nfl'>Draft Assistant</a></li>
                        <li><a href='http://draftwizard.fantasypros.com/editor/?partner=fpros&sport=nfl'>Cheat Sheets</a></li>
                        <li><a href='/nfl/draftwizard/premium-features.php?#auction-simulator'>Auction Simulator</a></li>
                        <li><a href='/nfl/auction-values/calculator.php'>Auction Calculator</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/experts/nfl/'>Experts</a></h4>
                    <ul>
                        <li><a href='/experts/nfl/'>NFL Directory</a></li>
                        <li><a href='/experts/mlb/'>MLB Directory</a></li>
                        <li><a href='/nfl/rankings/'>NFL Rankings Directory</a></li>
                        <li><a href='/mlb/rankings/'>MLB Rankings Directory</a></li>
                        <li><a href='/about/contact/'>Contact Us</a></li>
                        <li><a href='https://ep.fantasypros.com'>Expert Platform</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/nfl/player-news.php'>News Desk</a></h4>
                    <ul>
                        <li><a href='/news/nfl-correspondents.php'>Correspondents</a></li>
                        <li><a href='/news-desk-application-form/'>Application</a></li>
                    </ul>
                    <h4><a href='/advertise/'>Advertisers</a></h4>
                    <ul>
                        <li><a href='/advertise/'>Advertise With Us</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='https://www.facebook.com/FantasyPros' target='_blank'>Join Us</a></h4>
                    <ul>
                        <li><a href='https://secure.fantasypros.com/accounts/register/?next=https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Register</a></li>
                        <li><a href='https://secure.fantasypros.com/accounts/login/?next=https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php'>Login</a></li>
                        <li><a href='https://twitter.com/FantasyPros' target='_blank'>NFL Twitter</a></li>
                        <li><a href='https://twitter.com/FantasyProsMLB' target='_blank'>MLB Twitter</a></li>
                        <li><a href='https://twitter.com/FantasyProsNBA' target='_blank'>NBA Twitter</a></li>
                        <li><a href='https://www.facebook.com/FantasyPros' target='_blank'>Facebook</a></li>
                    </ul>
                </div>
            </div>
            <div class='column-row clearfix'>
                <div class='footer-column three columns'>
                    <h4><a href='/nfl/myplaybook/'>My Playbook</a></h4>
                    <ul>
                        <li><a href='/nfl/myplaybook/start-sit-assistant.php'>Start/Sit Assistant</a></li>
                        <li><a href='/nfl/myplaybook/waiver-wire-assistant.php'>Waiver Assistant</a></li>
                        <li><a href='/nfl/myplaybook/trade-assistant.php'>Trade Assistant</a></li>
                        <li><a href='/nfl/myplaybook/trade-analyzer.php'>Trade Analyzer</a></li>
                        <li><a href='/nfl/myplaybook/research-assistant-setup.php'>Research Assistant</a></li>
                        <li><a href='/nfl/myplaybook/multi-league.php'>Multi-League Assistant</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/nfl/accuracy/'>Accuracy Results</a></h4>
                    <ul>
                        <li><a href='/nfl/accuracy/draft.php'>NFL Preseason</a></li>
                        <li><a href='/nfl/accuracy/weekly.php'>NFL In-Season</a></li>
                        <li><a href='/mlb/accuracy/'>MLB Preseason</a></li>
                        <li><a href='/about/faq/accuracy-methodology/'>Methodology</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/affiliate/'>Affiliates</a></h4>
                    <ul>
                        <li><a href='/affiliate/'>Application</a></li>
                        <li><a href='https://secure.fantasypros.com/accounts/profile/'>Login</a></li>
                    </ul>
                </div>
                <div class='footer-column three columns'>
                    <h4><a href='/about/'>Partners</a></h4>
                    <ul>
                        <li><a href='http://cbssports.com/'>CBS Sports</a></li>
                        <li><a href='http://sports.yahoo.com/'>Yahoo! Sports</a></li>
                        <li><a href='http://sportradar.us/'>Sportradar</a></li>
                        <li><a href='http://www.myfantasyleague.com/'>MyFantasyLeague</a></li>
                        <li><a href='http://www.usatoday.com/sports/'>USA TODAY Sports</a></li>
                        <li><a href='http://nffc.stats.com/'>NFFC</a></li>
                    </ul>
                </div>
            </div>
            <div class='footer-social-icons clearfix'>
                <a href='https://www.facebook.com/FantasyPros' target='_blank'><i class='fa fa-facebook'></i></a>
                <a href='https://twitter.com/FantasyPros' target='_blank'><i class='fa fa-twitter'></i></a>
                <a href='https://www.instagram.com/fantasypros/' target='_blank'><i class='fa fa-instagram'></i></a>
            </div>
            <hr>
            <div class='footer-featured-row'>
                <div class='pull-left'>
                    <ul>
                        <li><a href='/about/'>Company</a></li>
                        <li><a href='/about/press/'>Press Room</a></li>
                        <li><a href='/about/careers/'>Careers</a></li>
                        <li><a href='/about/faq/'>FAQs</a></li>
                    </ul>
                </div>
                <div class='pull-right'>
                    <ul>
                        <li><a href='/about/contact/'>Contact Us</a></li>
                        <li><a href='/about/legal/'>Terms of Use</a></li>
                        <li><a href='/about/privacy/'>Privacy Policy</a></li>
                    </ul>
                </div>
                <div class='footer-logo'>
                    <a href='/'><img src='//images.fantasypros.com/images/logos/300x60_r.png' style='width: 210px;' /></a>
                </div>
            </div>
            <hr>
            <p class='copyright'>&copy; Copyright 2010-2016 FantasyPros.com</p>
        </div>
    </footer>
</div> <!-- /.body-wrap --><!-- Any custom JS to be loaded at the end here -->


<script type='text/javascript'>
$(document).ready(function() {

    $('.tier-row a').click(function(){
        $('#tier-edit').modal();
    });

    $('#data').tablesorter({
        widgets: ['staticRow']
    })
    .bind('sortEnd',function(e) {
        if (e.target.config.sortList[0][0] === 0 && e.target.config.sortList[0][1] === 0) {
            $('.tier-row').each(function(){
                $(this).css('display', 'table-row');
            });
        } else {
            $('.tier-row').each(function(){
                $(this).css('display', 'none');
            });
        }
    });
    $('#data').trigger('sorton', [ [[0,0]] ]);
    
    $('#experts').tablesorter({
        dateFormat: 'mm/dd/yyyy',
                    sortList: [[5,1]]
            });

    
    $('#select-all').click(function () {
        if($(this).prop('checked')) {
          $('.expert').prop('checked', true);
        } else {
          $('.expert').prop('checked', false);
        }
    });

     $('.expert').click(function(){
    if($('.expert').length == $('.expert:checked').length) {
            $('#select-all').prop('checked', true);
    } else {
            $('#select-all').prop('checked', false);
    }
     });

    $('#set-experts').change(function () {
        var set = $(this).val();
        $('input[type='checkbox']').not('#mpb-roster, #mpb-taken, #mpb-available').attr('checked', false);
        $('.'+set).prop('checked', true);
    });
    $('#set-accuracy').change(function () {
        var year = $(this).val();
        $('.accuracy').hide();
        $('.'+year).show();
    });

  $('#save-experts').click(function() {
    $('#save-experts').hide();
    $('.save-experts').show();
    $('.select-experts').hide();
     });
  $('.close-experts').click(function() {
    $('#save-experts').show();
    $('.save-experts').hide();
    $('.select-experts').show();
     });

     $('.experts-modal-submit').click(function(){
         if ($('input[name='expert[]']:checked').length < 2) {
             alert('Sorry, you must select at least two experts');
             return false;
         } else {
             $('#filters').submit();
         }
     });

    $('.tip').tooltip();
   
    $('.tab-wrap').tabs({active: 0});  // NFL active

});

</script>

<script type='text/javascript' src='//cdn.fantasypros.com/js/jquery.tablesorter.min.js?ver=2.3.11'></script>
<script type='text/javascript' src='//cdn.fantasypros.com/js/jquery.tablesorter.staticrow.min.js'></script>
<script type='text/javascript'>window.PLAYERCARDS_CONFIG={hideRankTab:true,affiliateCode:'fpros_cards'};</script>
<script type='text/javascript' src='//cdn.fantasypros.com/playercards/auto_parse_nfl.js'></script>


<script type='text/javascript'>
$(document).ready(function() {
    var $window = $(window);

    if($window.width() >= 1200) {
        setTimeout(function() {
            var main_height = parseFloat($('.main-content-wrap').css('height'));
            var cols = ['side-nav', 'main-content', 'side-content'];
            for (var i = 0; i < cols.length; i++) {
                if (parseFloat($('.'+cols[i]).css('height')) > main_height) {
                    main_height = parseFloat($('.'+cols[i]).css('height'));
                }
            }
            main_height += 10;
            for (var i = 0; i < cols.length; i++) {
                $('.'+cols[i]).css('min-height', main_height);
            }
        }, 10);
    } else if ($window.width() > 900) {
        setTimeout(function() {
            var main_height = parseFloat($('.side-nav').css('height'));
            if ($('.side-content').length == 1 && $('.side-content').is(':visible')) {
                if ((parseFloat($('.side-content').css('height')) + parseFloat($('.main-content').css('height'))) < main_height) {
                    $('.side-content .inner').css('min-height', (main_height - parseFloat($('.main-content').css('height'))));
                }
            } else {
                if (parseFloat($('.main-content').css('height')) < main_height) {
                    $('.main-content .inner').css('min-height', main_height);
                }
            }
        }, 10);
    }
    
    if($window.width() > 1000) {
        $('#nav-top .mega-dropdown').each(function(i) {
            $(this).width($(this).children().length*parseFloat($(this).children().first().css('width'))+'px');
            if ((i + $(this).children().length) > 5) {
                $(this).css('left', (5 - (i + $(this).children().length))*parseFloat($(this).parent().css('width'))+'px');
            }
            $(this).children().each(function(j) {
                if (parseFloat($(this).parent().css('height')) > 70) {
                    $(this).css('height', parseFloat($(this).parent().css('height'))+'px');
                }
            });
        });
    }
    setTimeout(function() {
        $('#nav-sub .mega-dropdown').each(function(i) {
            var new_width = $(this).children().length*parseFloat($(this).children().first().css('width'));
            $(this).width(new_width+'px');
            if ((new_width + $(this).parent().position().left) > $window.width()) {
                $(this).css('left', -1*(4+new_width + $(this).parent().position().left - $window.width())+'px');
            }
            $(this).children().each(function(j) {
                if (parseFloat($(this).parent().css('height')) > 70) {
                    $(this).css('height', parseFloat($(this).parent().css('height'))+'px');
                }
            });
        });
    }, 10);

    $('.top-link').on('mouseover', function() {
        $('#nav-top').addClass('hovered');
    });
    $('.top-link').on('mouseout', function() {
        $('#nav-top').removeClass('hovered');
    });
    $('.search input').on('focus', function() {
        $(this).parent().addClass('focused');
    });
    $('.search input').on('blur', function() {
        $(this).parent().removeClass('focused');
    });

    $('select.select-links').on('change', function() {
        if ($(this).val() != '') {
            if ($(this).val()[0] == '#' && $($(this).val()).hasClass('modal')) {
                $($(this).val()).modal();
            } else {
                window.location.href = $(this).val();
            }
        }
    });

    function hide_show_mpb_row(row_type) {
        if ($('.mpb-'+row_type+'-control input').prop('checked') == false) {
            $('tr.mpb-'+row_type).css({'display':'none'});
        } else {
            $('tr.mpb-'+row_type).css({'display':'table-row'});
        }
    }

    if ($('.mpb-options-form').length > 0) {
        hide_show_mpb_row('available');
        $('.mpb-available-control').click(function() {hide_show_mpb_row('available');});
        hide_show_mpb_row('taken');
        $('.mpb-taken-control').click(function() {hide_show_mpb_row('taken');});
        hide_show_mpb_row('roster');
        $('.mpb-roster-control').click(function() {hide_show_mpb_row('roster');});
    }
    
    $('#news_content.tab-wrap').tabs();

$('#side_rankings.tab-wrap').tabs();


    
});
</script>

<script type='text/javascript' src='//cdn.fantasypros.com/js/jquery.dlmenu-custom.js'></script>
<script type='text/javascript' src='//cdn.fantasypros.com/js/jquery.mobile-pills.js'></script>
<script type='text/javascript'>
// Handle conflict with WP on jquery
var $jq = jQuery;
$jq(document).ready(function() {
    $jq('#dl-menu').dlmenu({
        animationClasses : { classin : 'dl-animate-in-2', classout : 'dl-animate-out-2', backLabel: 'Back' }
    });
    if ($jq('.desktop-pills').length) {
        $jq('.desktop-pills').mobilePills();
    }
})
</script>

    <script type='text/javascript' src='//cdn.fantasypros.com/js/fast_nfl_20160728.js'></script>


    <style>
    #cboxClose {
        top: 22px;
        right: 12px;
        background: none; 
        width: 60px;
        height: 25px;
        text-indent: 0;
        color: #2881eb;
        font-size: 1.2rem;
        font-weight: bold;
        text-transform: uppercase;
    }
    #cboxMiddleLeft,#cboxMiddleRight,#cboxTopCenter,#cboxBottomCenter,#cboxBottomLeft,#cboxBottomRight,#cboxTopLeft,#cboxTopRight {
        background: none;
    }
    #cboxLoadedContent {
        margin-bottom: 0;
        overflow: hidden!important;
    }
    #cboxTitle {
        display: none;
    }
    </style>
            <script src='//my.hellobar.com/8c07292c04611bdfc2a06f3f9ffac4294f7af3a9.js' type='text/javascript' charset='utf-8' async='async'></script>
    

<!-- Quantcast Tag -->
<script type='text/javascript'>
    var _qevents = _qevents || [];

    (function() {
    var elem = document.createElement('script');
    elem.src = (document.location.protocol == 'https:' ? 'https://secure' : 'http://edge') + '.quantserve.com/quant.js';
    elem.async = true;
    elem.type = 'text/javascript';
    var scpt = document.getElementsByTagName('script')[0];
    scpt.parentNode.insertBefore(elem, scpt);
    })();

    _qevents.push({
    qacct:'p-vaFYf4YVQRz-3'
    });
</script>

<noscript>
<div style='display:none;'>
<img src='//pixel.quantserve.com/pixel/p-vaFYf4YVQRz-3.gif' border='0' height='1' width='1' alt='Quantcast'/>
</div>
</noscript>
<!-- End Quantcast tag -->

<!-- start new sticky unit -->
<script src='//ad.adip.ly/dlvr/adiply_statmarg.min.js?site_id=FantasyProsMobFt_AP&t=250'></script>
<!-- end new sticky unit -->

</body>

</html>
";

        const string FantasyFootballNerd = @"
<!DOCTYPE html>
<html lang='en'><head>
<title>Fantasy Football Rankings - 2016 Fantasy Football Rankings for All Positions </title>
<META name='description' content='Fantasy Football Rankings - 2016 Fantasy Football Draft Rankings. Top All Positions   fantasy football rankings. 2016 fantasy football rankings.'/>
<link rel='canonical' href='http://www.fantasyfootballnerd.com/fantasy-football-draft-rankings'/>
<meta charset='utf-8'>
<meta http-equiv='X-UA-Compatible' content='IE=edge'>
<meta name='viewport' content='width=device-width, initial-scale=1'>
<meta name='verify-v1' content='iSyspzQr8RSG86v0BYN0UE/4mqTvgf8PvHj2Nqpa7qY='/>
<meta name='msvalidate.01' content='8ABB8B1C6AC69308E4FDF44F47C8FCC7'/>
<META name='y_key' content='261e5829b90e566e'/>
<meta name='twitter:site' content='@ffnerd'>
<link rel='alternate' type='application/rss+xml' title='Fantasy Football Nerd Blog' href='http://feeds.feedburner.com/FantasyFootballNerd'/>
 
<script src='//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js'></script>
<script src='//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js'></script>
 
<link rel='stylesheet' href='//ajax.googleapis.com/ajax/libs/jqueryui/1.10.0/themes/base/jquery-ui.css'>
<link rel='stylesheet' href='//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css'>
<link rel='stylesheet' href='//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
<link rel='stylesheet' href='//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap-theme.min.css'>
<link rel='stylesheet' href='/css/sweet-alert.css'>
<link rel='stylesheet' href='/css/fantasyfootballnerd.css?v=20160728'>
<link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
<link href='https://fonts.googleapis.com/css?family=Kanit:400,400italic' rel='stylesheet' type='text/css'>
 
<!--[if lt IE 9]>
  <script src='https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js'></script>
  <script src='https://oss.maxcdn.com/respond/1.4.2/respond.min.js'></script>
<![endif]-->
<script type='text/javascript' src='/js/rankings.js?v=20150205'></script>
</head>
<body role='document'>
<!--[if lt IE 7]>
<p class='chromeframe'>You are using an <strong>outdated</strong> browser. Please <a href='http://browsehappy.com/' rel='nofollow' target='_blank'>upgrade your browser</a> or <a href='http://www.google.com/chromeframe/?redirect=true' rel='nofollow' target='_blank'>activate Google Chrome Frame</a> to improve your experience.</p>
<![endif]--><div class='babyBlue'>
<div class='container'>
<div class='row' style='margin-bottom:15px;'>
<div class='col-md-4 col-xs-12 center'>
<a href='/' title='Fantasy Football Rankings' alt='Fantasy Football Rankings'><img src='/images/layout/logo.gif' alt='Fantasy Football Rankings' title='Fantasy Football Rankings'/></a><br><span class='tagline'>The Industry's <span class='bold italics white'>ONLY</span> Weighted Consensus</span>
</div>
<div id='ad' class='col-md-8 col-xs-12' style='margin-top:15px;'>
<script async src='//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js'></script>
 
<ins class='adsbygoogle' style='display:inline-block;width:728px;height:90px' data-ad-client='ca-pub-8820027357793670' data-ad-slot='2871674500'></ins>
<script>
	(adsbygoogle = window.adsbygoogle || []).push({});
	</script>
</div>
</div>
</div>
 
<div class='container'>
<div class='alert alert-warning alert-dismissible' role='alert'>
<button type='button' class='close' data-dismiss='alert' aria-label='Close' onclick='dismissAlert()'><span aria-hidden='true'>&times;</span></button>
<div><i class='fa fa-exclamation-circle'></i> <strong>FFN Alert:</strong> Cowboys QB Tony Romo has a broken bone in his back and will miss at least half of the 2016 season.</div>
</div>
</div>
<div class='container'>
<nav class='navbar navbar-default'>
<div class='container-fluid'>
 
<div class='navbar-header'>
<button type='button' class='navbar-toggle collapsed' data-toggle='collapse' data-target='#ffnNavbar'>
<span class='sr-only'>Toggle navigation</span>
<span class='icon-bar'></span>
<span class='icon-bar'></span>
<span class='icon-bar'></span>
</button>
</div>
 
<div class='collapse navbar-collapse' id='ffnNavbar'>
<ul class='nav navbar-nav'>
<li role='presentation' class=''><a href='/'>Home</a></li>
<li role='presentation' class='active '><a href='/fantasy-football-draft-rankings'>Draft Rankings</a></li>
<li role='presentation' class=''><a href='/fantasy-football-rankings'>Weekly Rankings</a></li>
<li role='presentation' class=''><a href='/daily-fantasy-football'>Daily</a></li>
<li role='presentation' class=''><a href='/nfl-picks'>NFL Picks</a></li>
<li role='presentation' class=''><a href='/fantasy-football-tools'>Tools</a></li>
<li role='presentation' class=''><a href='/fantasy-football-news'>News</a></li>
<li role='presentation' class='hidden-sm hidden-md'><a href='/players'>Players</a></li>
<li role='presentation' class='hidden-sm hidden-md'><a href='/myaccount'>My Account</a></li>
<li role='presentation' class='hidden-sm hidden-md'><a href='/help'>Help</a></li>
<li role='presentation' class='hidden-sm hidden-md'><a href='https://www.facebook.com/fantasyfootballnerd' target='_blank'><i class='fa fa-facebook-square' aria-hidden='true' style='font-size:20px;'></i></a></li>
<li role='presentation' class='hidden-sm hidden-md'><a href='https://twitter.com/ffnerd' target='_blank'><i class='fa fa-twitter-square' aria-hidden='true' style='font-size:20px;'></i></a></li>
</ul>
</div>
</div> 
</nav>
</div>
</div>
<div class='container'>
<h2>2016 Fantasy Football Rankings</h2>
<h4>Consensus fantasy football draft rankings from 35 top fantasy football websites!</h4>
<p class='text-muted'>Rankings as of Monday, Aug 29, 2016</p>
<div class='panel panel-default'>
<div class='panel-body'>
<div class='row'>
<div class='col-xs-12 col-md-6 pad'>
<div class='col-xs-1 col-md-1 drOn'>
<br><a href='/fantasy-football-draft-rankings'>ALL</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/QB'>QB</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/RB'>RB</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/WR'>WR</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/TE'>TE</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/DEF'>DEF</a>
</div>
<div class='col-xs-1 col-md-1 drOff'>
<br><a href='/fantasy-football-draft-rankings/K'>K</a>
</div>
</div>
<div class='col-xs-12 col-md-6 pad'>
<ul class='nav nav-pills'>
<li class='scoringFormatPillLabel'><strong>Scoring Format:</strong></li>
<li role='presentation'><a href='/fantasy-football-draft-rankings/' class='scoringFormatPill'>Standard</a></li>
<li role='presentation'><a href='/fantasy-football-draft-rankings/ppr'>PPR</a></li>
<li role='presentation'><a href='/fantasy-football-draft-rankings/half'>Half</a></li>
<li role='presentation'><a href='/idp-fantasy-football-draft-rankings'>IDP</a></li>
<li role='presentation'><a href='/fantasy-football-dynasty-rankings'>Dynasty</a></li>
</ul>
</div>
</div>
</div>
</div>
<h3>Fantasy Football Rankings - All Positions</h3>
<p>Filter your results by selecting a position above.</p>
<p>FantasyFootballNerd.com searches and aggregates fantasy football rankings from around the web into one easy to use display. The fantasy football rankings shown below are from the top fantasy football rankings websites. The projections are <a href='/nerdRank'>weighted</a> based on a number of factors including past accuracy. ADP is based upon a 12-team draft.</p>
<p>The <strong>Pts/Gm</strong> is the projected points per game that each player is expected to contribute on a weekly basis. This can be helpful if choosing between two closely-ranked players.</p>
<div style='border-bottom:1px solid #ccc;margin:15px 0px;'></div>
<div class='row'>
<div class='col-xs-12 col-md-8'>
<table class='table table-striped table-hover'>
<thead>
<th>Rank</th>
<th>ADP</th> <th>Pos</th> <th>Player</th>
<th>Team</th>
<th>Bye</th>
<th>Pts/Gm</th>
</thead>
<tbody>
<tr>
<td>1</td>
<td>1</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('1142');'>Antonio Brown</a></td>
<td>PIT</td>
<td>8</td>
<td>14.2</td>
</tr>
<tr>
<td>2</td>
<td>2</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2465');'>Odell Beckham Jr.</a></td>
<td>NYG</td>
<td>8</td>
<td>13.4</td>
</tr>
<tr>
<td>3</td>
<td>6</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('1446');'>Julio Jones</a></td>
<td>ATL</td>
<td>11</td>
<td>13.3</td>
</tr>
<tr>
<td>4</td>
<td>3</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('2771');'>Todd Gurley</a></td>
<td>LA</td>
<td>8</td>
<td>13.9</td>
</tr>
<tr>
<td>5</td>
<td>4</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('2760');'>David Johnson</a></td>
<td>ARI</td>
<td>9</td>
<td>13.4</td>
</tr>
<tr>
<td>6</td>
<td>9</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2338');'>DeAndre Hopkins</a></td>
<td>HOU</td>
<td>9</td>
<td>11.5</td>
</tr>
<tr>
<td>7</td>
<td>5</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('259');'>Adrian Peterson</a></td>
<td>MIN</td>
<td>6</td>
<td>13.0</td>
</tr>
<tr>
<td>8</td>
<td>8</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('1441');'>A.J. Green</a></td>
<td>CIN</td>
<td>9</td>
<td>11.4</td>
</tr>
<tr>
<td>9</td>
<td>7</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('3037');'>Ezekiel Elliott</a></td>
<td>DAL</td>
<td>7</td>
<td>12.6</td>
</tr>
<tr>
<td>10</td>
<td>14</td> <td>TE</td> <td><a href='javascript:playerDraftDetails('1189');'>Rob Gronkowski</a></td>
<td>NE</td>
<td>9</td>
<td>10.9</td>
</tr>
<tr>
<td>11</td>
<td>10</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('1761');'>Lamar Miller</a></td>
<td>HOU</td>
<td>9</td>
<td>12.8</td>
</tr>
<tr>
<td>12</td>
<td>11</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('2289');'>Le'Veon Bell</a></td>
<td>PIT</td>
<td>8</td>
<td>15.0</td>
</tr>
<tr>
<td>13</td>
<td>12</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2635');'>Allen Robinson</a></td>
<td>JAC</td>
<td>5</td>
<td>11.1</td>
</tr>
<tr>
<td>14</td>
<td>13</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('1143');'>Dez Bryant</a></td>
<td>DAL</td>
<td>7</td>
<td>10.3</td>
</tr>
<tr>
<td>15</td>
<td>15</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('145');'>Jamaal Charles</a></td>
<td>KC</td>
<td>5</td>
<td>12.4</td>
</tr>
<tr>
<td>16</td>
<td>17</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('480');'>Brandon Marshall</a></td>
<td>NYJ</td>
<td>11</td>
<td>10.4</td>
</tr>
<tr>
<td>17</td>
<td>20</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('2651');'>Devonta Freeman</a></td>
<td>ATL</td>
<td>11</td>
<td>11.5</td>
</tr>
<tr>
<td>18</td>
<td>18</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('502');'>Jordy Nelson</a></td>
<td>GB</td>
<td>4</td>
<td>10.8</td>
</tr>
<tr>
<td>19</td>
<td>24</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('1415');'>Mark Ingram</a></td>
<td>NO</td>
<td>5</td>
<td>11.4</td>
</tr>
<tr>
<td>20</td>
<td>22</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2215');'>Keenan Allen</a></td>
<td>SD</td>
<td>11</td>
<td>9.6</td>
</tr>
<tr>
<td>21</td>
<td>19</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2677');'>Mike Evans</a></td>
<td>TB</td>
<td>6</td>
<td>10.3</td>
</tr>
<tr>
<td>22</td>
<td>26</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('1895');'>Alshon Jeffery</a></td>
<td>CHI</td>
<td>9</td>
<td>10.6</td>
</tr>
<tr>
<td>23</td>
<td>25</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('1981');'>Doug Martin</a></td>
<td>TB</td>
<td>6</td>
<td>11.6</td>
</tr>
<tr>
<td>24</td>
<td>16</td> <td>RB</td> <td><a href='javascript:playerDraftDetails('2313');'>Eddie Lacy</a></td>
<td>GB</td>
<td>4</td>
<td>11.3</td>
</tr>
<tr>
<td>25</td>
<td>27</td> <td>WR</td> <td><a href='javascript:playerDraftDetails('2669');'>Brandin Cooks</a></td>
<td>NO</td>
<td>5</td>
<td>9.9</td>
</tr>
</tbody>
</table>
<div class='alert alert-info' role='alert'><strong>Go Pro!</strong> The rest of the rankings are available to our <a href='/premium'>Premium</a> Members. Become a Fantasy Football Nerd today!</div> <div class='top'><img class='img-responsive' title='As seen on USA Today, The Sports Network, FOX Sports, The Washington Post, and The New York Times' alt='As seen on USA Today, The Sports Network, The Washington Post, FOX Sports, and The New York Times' src='/images/ffnseen.gif'></div>
</div>
<div class='col-xs-12 col-md-4'>
<h4 style='margin-top:5px;'>Searching fantasy football rankings from...</h4>
<div id='ffnVendors' class='carousel slide' data-ride='carousel'>
<div class='carousel-inner' role='listbox'>
<div class='item active'>
<a href='javascript:displayVendor('10');'><img src='/images/vendors/cbs.gif' title='CBS Sports'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('30');'><img src='/images/vendors/focus.gif' title='Pro Football Focus'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('7');'><img src='/images/vendors/sharks.gif' title='FantasySharks.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('11');'><img src='/images/vendors/mfl.gif' title='MyFantasyLeague.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('34');'><img src='/images/vendors/eds.gif' title='EDS Football'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('24');'><img src='/images/vendors/starters.jpg' title='Fantasy Football Starters'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('16');'><img src='/images/vendors/jyj.gif' title='Junkyard Jake'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('35');'><img src='/images/vendors/draftsharks.gif' title='Draft Sharks'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('28');'><img src='/images/vendors/athlon.gif' title='Athlon Sports'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('12');'><img src='/images/vendors/ffc.gif' title='Fantasy Football Calculator'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('27');'><img src='/images/vendors/fantasypros.gif' title='FantasyPros'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('31');'><img src='/images/vendors/pyro.jpg' title='Pyromaniac.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('15');'><img src='/images/vendors/commish.gif' title='AskTheCommish.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('18');'><img src='/images/vendors/kffl.gif' title='KFFL'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('13');'><img src='/images/vendors/fbguys.gif' title='FootballGuys.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('1');'><img src='/images/vendors/nfl.gif' title='NFL.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('26');'><img src='/images/vendors/mdc.gif' title='Mock Draft Central'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('33');'><img src='/images/vendors/gridiron.gif' title='Gridiron Experts'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('2');'><img src='/images/vendors/fox.gif' title='FOX Sports'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('23');'><img src='/images/vendors/fleaflicker.jpg' title='Fleaflicker'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('4');'><img src='/images/vendors/brunoboys.gif' title='Bruno Boys'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('36');'><img src='/images/vendors/tfg.gif' title='The Football Girl'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('25');'><img src='/images/vendors/rtfs.gif' title='RealTime Fantasy Sports'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('9');'><img src='/images/vendors/fftoolbox.gif' title='FFToolbox.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('38');'><img src='/images/vendors/rosterwatch.gif' title='RosterWatch'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('6');'><img src='/images/vendors/yahoo.png' title='Yahoo'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('3');'><img src='/images/vendors/espn.gif' title='ESPN.com'/></a>
</div>
<div class='item'>
<a href='javascript:displayVendor('37');'><img src='/images/vendors/walter.gif' title='Walter Football'/></a>
</div>
<div class='item'>
<img src='/images/vendors/more.gif' title='Plus more!' alt='Plus More!'/>
</div>
</div>
</div>
<h4>Additional Options</h4>
<ul>
<li><a href='/fantasy-football-projections' title='Fantasy Football Projections'>Fantasy Football Projections</a></li>
<li><a href='/fantasy-football-tools/auction' title='Fantasy Football Auction Values'>Fantasy Football Auction Values</a></li>
<li><a href='/fantasy-football-cheat-sheet' title='Printable Fantasy Football Cheat Sheet'>Printable Fantasy Football Cheat Sheet</a></li>
<li><a href='/fantasy-football-dynasty-ranking' title='2016 Fantasy Football Dynasty Rankings'>Fantasy Football Dynasty Rankings</a></li>
<li><a href='/idp-fantasy-football-draft-rankings' title='2016 Fantasy Football IDP Rankings'>Fantasy Football IDP Rankings</a></li>
<li><img src='/images/excel2.gif' alt='Export' title='Export'/> <a href='javascript:alert('Please sign in to see partial list. Premium members can download all the rankings.');' title='Download our Fantasy Football Rankings'>Download our Fantasy Football Rankings</a></li>
</ul>
<iframe src='http://www.facebook.com/plugins/like.php?href=http%3A%2F%2Fwww.facebook.com%2Ffantasyfootballnerd&amp;layout=standard&amp;show_faces=false&amp;width=350&amp;action=like&amp;colorscheme=light&amp;height=35' scrolling='no' frameborder='0' style='border:none; overflow:hidden; width:350px; height:35px;margin-top:10px;' allowTransparency='true'></iframe>
<h4>Custom Scoring Options</h4>
<p>Does your league have custom scoring like passing TD's worth 6 points or TD-only leagues? Create a <a href='/custom'>Custom Scoring Option</a> tailored to your league settings.</p>
<div style='margin-top:20px;'>
<h4>Follow @ffnerd!</h4>
<a class='twitter-timeline' data-dnt='true' href='https://twitter.com/ffnerd' data-widget-id='343185458462859265'>Tweets by @ffnerd</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+'://platform.twitter.com/widgets.js';fjs.parentNode.insertBefore(js,fjs);}}(document,'script','twitter-wjs');</script>
</div>
</div>
</div>
<div class='well'>
<div class='row'>
<div class='col-md-5 col-xs-12'>
<a href='/premium'><img src='/images/premium.png' alt='Become a Premium Member' title='Become a Premium Member' class='top pad img-responsive img-center'/></a>
</div>
<div class='col-md-7 col-xs-12'>
<h4>Isn't it time you went Pro?</h4>
<p>Become a Premium Member of FFN and view the full results as well as unlock all of our tools.</p>
<p><strong>ONLY <span class='label label-primary' style='font-size:120%;'>$11.95</span> for the whole season!</strong></p>
</div>
</div>
</div>
</div>
<div id='playerContainer' class='modal fade' tabindex='-1' role='dialog' aria-labelledby='myLargeModalLabel' aria-hidden='true'>
<div class='modal-dialog modal-lg'>
<div class='modal-content'>
<div class='modal-header'>
<button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>
<h4 class='modal-title'><img id='pcTeamImg' src='/images/teams/GB.gif'/> <span id='pcPlayerName'></span> - <span id='pcPlayerPos'></span>, <span id='pcPlayerTeam'></span></h4>
</div>
<div class='modal-body'>
<div class='row'>
<div class='col-md-6 col-xs-12'>
<div class='row'>
<div class='col-md-6 col-xs-6 bold center'>Overall Ranking</div>
<div class='col-md-6 col-xs-6 bold center'>Ranking Among <span id='pcPlayerPosB'></span>'s</div>
</div>
<div class='row'>
<div class='col-md-6 col-xs-6'><h3 class='center'><span id='pcOverall' class='label label-primary'></span></h3></div>
<div class='col-md-6 col-xs-6'><h3 class='center'><span id='pcPos' class='label label-primary'></span></h3></div>
</div>
</div>
<div class='col-md-6 col-xs-12'>
<div class='center'><img id='conChart' src='/images/ajax-loading.gif' alt='Consensus' title='Fantasy Football Nerd Consensus'/></div>
</div>
</div>
<h4>Strength of Schedule</h4>
<div class='alert alert-info'>
<button id='sosValue' type='button' class='btn btn-primary pull-left' style='margin-right:10px;'></button>
<span id='sosValueTxt' class='bold'></span><br><span id='sosExp'></span>
</div>
<table class='table'>
<thead>
<tr>
<th>Week</th>
<th>Opponent</th>
<th>Ease of Matchup</th>
</tr>
</thead>
<tbody id='oppBody'>
</tbody>
</table>
</div>
<div class='modal-footer'>
<button type='button' class='btn btn-default' data-dismiss='modal'>Close</button>
</div>
</div>
</div>
</div>
<div id='vendorModal' class='modal fade' tabindex='-1' role='dialog' aria-labelledby='vendorModalLabel' aria-hidden='true'>
<div class='modal-dialog modal-sm'>
<div class='modal-content'>
<div class='modal-header'>
<button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>
<h4 id='vendorModalVendorName' class='modal-title'></h4>
</div>
<div class='modal-body'>
<p class='text-center'><img id='vendorModalImg'/></p>
<p id='vendorModalDesc'></p>
</div>
<div class='modal-footer'>
<button type='button' class='btn btn-default' data-dismiss='modal'>Close</button>
<button id='vendorModalLink' type='button' class='btn btn-primary'>Visit <span id='vendorModalLinkName'></span></button>
</div>
</div>
</div>
</div>
<div id='footer' class='babyBlue'>
<div class='container'>
<div class='row'>
<div class='col-xs-12 col-md-4'>
<h3 class='white'>Connect with Us</h3>
<ul class='social'>
<li class='facebook'><a href='http://www.facebook.com/fantasyfootballnerd' target='_blank' rel='nofollow'>Facebook</a></li>
<li class='twitter'><a href='https://twitter.com/ffnerd' target='_blank' rel='nofollow'>Twitter</a></li>
<li class='google'><a href='https://plus.google.com/+Fantasyfootballnerdrankings' target='_blank' rel='nofollow'>Google+</a></li>
<li class='blog'><a href='http://feeds.feedburner.com/FantasyFootballNerd' target='_blank' rel='nofollow'>FFN Blog</a></li>
</ul>
</div>
<div class='col-xs-12 col-md-4'>
<h3 class='white'>Fantasy Football Nerd Features</h3>
<ul class='footerlinks'>
<li><a href='/players'>NFL Players</a></li>
<li><a href='/blog'>FFN Fantasy Blog</a></li>
<li><a href='/daily-fantasy-football'>Daily Fantasy Football Line-up Assistant</a></li>
<li><a href='/fantasy-football-api'>Fantasy Football API</a></li>
<li><a href='/wordpress'>Fantasy Football WordPress Plugin</a></li>
<li><a href='/draft-buddy'>Draft Buddy</a></li>
<li><a href='/analyzer'>Weekly Lineup Analyzer</a></li>
<li><a href='/nfl-news'>NFL News</a></li>
<li><a href='/injuries'>NFL Injury Report</a></li>
<li><a href='/fantasy-football-resources'>Fantasy Football Resources</a></li>
<li><a href='/fantasy-football-affiliate-program'>Fantasy Football Affiliate Program</a></li>
<li><a href='/adp'>Fantasy Football ADP</a></li>
<li><a href='/labs'>FFN Labs</a></li>
<li><a href='/nfl-tickets'>NFL Tickets</a></li>
</ul>
</div>
<div class='col-xs-12 col-md-4'>
<h3 class='white'>About Fantasy Football Nerd</h3>
<ul class='footerlinks'>
<li><a href='/myaccount'>My Account</a></li>
<li><a href='/help'>Help/Customer Support</a></li>
<li><a href='/fantasy-football-gift-certificate'>Fantasy Football Gift Certificate</a></li>
<li><a href='/shop'>Fantasy Football Nerd Store</a></li>
<li><a href='/about'>About the Nerd</a></li>
<li><a href='/nerdRank'>NerdRank</a></li>
<li><a href='/terms'>Terms and Conditions</a></li>
<li><a href='/privacy'>Privacy Policy</a></li>
<li><a href='/contact'>Contact Us</a></li>
<li><a href='/media'>Media Inquiries</a></li>
<li><a href='/green'>FFN is Green!</a></li>
<li><a href='/promos/charity'>Fantasy Football for Charity</a></li>
<li><a href='/fantasy-football-commercials'>Fantasy Football Commercials</a></li>
</ul>
</div>
</div>
<div class='top' style='border-bottom:1px solid #fff;'></div>
<p class='white small center top' id='copyright'>Copyright 2016 TayTech, LLC. All rights reserved. Fantasy Football Nerd is not affiliated with the NFL or the NFL Players Association</p>
<div class='pad'>
<ul class='taytech center toptop'>
<li class='topicli small'>Other TayTech Websites:</li>
<li><a href='https://celebritybucks.com' target='_blank'>Celebrity Game</a></li>
<li><a href='http://www.fantasybaseballnerd.com' target='_blank'>Fantasy Baseball Rankings</a></li>
<li><a href='http://www.fantasybasketballnerd.com' target='_blank'>Fantasy Basketball Rankings</a></li>
<li><a href='http://www.strangerdare.com' class='white' target='_blank'>Stranger Dare</a></li>
</ul>
</div>
</div>
</div>
<script src='/js/common.js?v=20151014'></script>
<script src='//ajax.googleapis.com/ajax/libs/jqueryui/1.10.2/jquery-ui.min.js'></script>
<script src='/js/ie10-viewport-bug-workaround.js'></script>
<script src='/js/sweet-alert.min.js'></script>
<script type='text/javascript'>

  var _gaq = _gaq || [];
  _gaq.push(['_setAccount', 'UA-4904826-1']);
  _gaq.push(['_trackPageview']);

  (function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
  })();

</script>
</body>
</html>
";

        const string FantasyNfl = @" < !doctype html>
<!--[if lt IE 7]>  <html class='ie ie6 lte9 lte8 lte7 skinId-1'  lang='en' id='template' > <![endif]-->
<!--[if IE 7]>     <html class='ie ie7 lte9 lte8 lte7 gt6 skinId-1' lang='en' id='template'> <![endif]-->
<!--[if IE 8]>     <html class='ie ie8 lte9 lte8 gt6 gt7 skinId-1' lang='en' id='template'> <![endif]-->
<!--[if IE 9]>     <html class='ie ie9 lte9 gt6 gt7 gt8 skinId-1' lang='en' id='template'> <![endif]-->
<!--[if (gt IE 9)|!(IE)]><!-->
<html itemscope itemtype='http://schema.org/Organization' lang='en' class='not-ie skinId-1' id='template'>
<!--<![endif]-->
<head>
    
<!-- app dynamics random number = 8 -->
    <!-- yui video groups from NDC -->
    <script src='http://combine.nflcdn.com/yui/min2/index.php?g=video'></script><script src='https://p.nfltags.com/omniture/VisitorAPI.js'></script>
    <script src='/static/js/e0c04f87c142e7639c35758e10cee78b.js' charset='utf-8'></script>
    <script src='/min/index1?a=230443d8-649d-11e6-8b77-86f30ca893d3&g=ff-base'></script><script type='text/javascript'>
    var googletag = googletag || {};
    googletag.cmd = googletag.cmd || [];
    (function() {
        var gads = document.createElement('script');
        gads.async = true;
        gads.type = 'text/javascript';
        var useSSL = 'https:' == document.location.protocol;
        gads.src = (useSSL ? 'https:' : 'http:') + '//www.googletagservices.com/tag/js/gpt.js';
        var node =document.getElementsByTagName('script')[0];
        node.parentNode.insertBefore(gads, node);
    })();
</script>    <script>
    (function (w) {

        var FF = w.FF = w.FF || {};
        FF.constants = {
            AD_ORD:         1472512810,
            ENV:            'production',
            RENDER_START:   new Date(),
            TIME:           1472516410000,
            MODAL_LOGIN_ENABLED: false,
            PLAYER_CARD_FEATURE: '',
            USERNAME: 'false'
        };

    }(window));
    </script>
    <!-- Loads the NFL constants -->
    <script src='/static/js/89de298df8bb044a6d5204edebbe93a1.js'></script>
    <script>
      // Overwrite nfl constants with system defaults.
      window.nfl.constants.ID_MANAGER = 'https://sso.nfl.com/login';
    </script>
    <title>Fantasy Football Player Rankings | 2016 Fantasy – NFL.com</title>
    <meta name='msvalidate.01' content='EDD46A4B9FD14F0A47471FDE9821BA49'/>    <!-- print css -->
        <!-- shared css -->
        <link rel='stylesheet' type='text/css' href='/static/css/1471633275/cHVyZS1taW4uY3NzO3lyZXNldC5jc3M7Zm9udHMuY3NzO3NpdGUuY3NzO2ZvbnRmYWNlLmNzcztvdmVybGF5LmNzczt0YWJsZS5jc3M7cGFnaW5hdGlvbi5jc3M7Y2x1YkltYWdlcy5jc3M7bmZsTmF2LmNzcztmb3Jtc05vTGVzcy5jc3M7Zm9vdGVyLmNzcztwbGF5ZXJDYXJkLmNzcztkeW5hbWljRXJyb3IuY3NzO2Vycm9ycy5jc3M7dmlkZW8uY3NzO21pc2NQdHMuY3NzO25hdkJhci5jc3M7cG9zaXRpb24tbmF2LmNzcztuYXYtYmFyLmNzczt0YWJCYXIuY3NzO3RhYi1iYXIuY3NzO2xlYXJuTW9yZS5jc3M7ZmVlZGJhY2suY3NzO3BhcnRuZXJzLWxvZ2luLmNzcztwb3B1cC5jc3M7bW9kYWwtbG9naW4uY3NzO2ZhbnRhc3ktaGVhZGVyLmNzcztmZi1zYXAtbW9kYWwuY3Nz.css' />
        <!-- page css  -->
        <!-- main css file -->
    <link rel='stylesheet' type='text/css' href='/static/css/1471281359/d2Vla05hdi5jc3M7cGxheWVycy1maWx0ZXIuY3NzO3BsYXllcnNIb21lLmNzcztsZWFybk1vcmUuY3NzO3Jlc2VhcmNoUmFua2luZ3MuY3Nz.css' />
    

    </head>

<body id='researchRankingsPage' class='noJs yui-skin-sam yui3-skin-sam g-a'>


<div id='doc'>
        <div id='hd-wrap'>
        <div id='hd'>
            <div class='fantasy-header'>

    <div class='fantasy-header-inner'>

        <!--
        <ul class='fantasy-header-mast pure-g'>
            <a class='fantasy-header-logo' href='http://www.nfl.com' target='_blank'></a>
            <li class='fantasy-header-title pure-u-7-12'>
                <a href='/'>Fantasy</a>

                
            </li>
            <li class='fantasy-header-signin'>
                <ul><li class='sso first'><a href='https://sso.nfl.com/login?s=fantasy&returnTo=http%3A%2F%2Ffantasy.nfl.com%2Fresearch%2Frankings%3FleagueId%3D0%26statType%3DdraftStats' >Sign In</a></li><li class='sso last'><a href='https://sso.nfl.com/register?s=fantasy&returnTo=http%3A%2F%2Ffantasy.nfl.com%2Fresearch%2Frankings%3FleagueId%3D0%26statType%3DdraftStats' >Register</a></li></ul>            </li>
        </ul>
        -->

        <div class='fantasy-header-mast pure-g'>

            <div class='fantasy-header-title pure-u-7-12'>
                                    <a class='fantasy-header-logo red-white-blue' href='http://www.nfl.com' target='_blank'></a>
                                <a class='fantasy-header-title-text' title='The official free fantasy football game of the NFL' href='http://fantasy.nfl.com'>Fantasy</a>
                            </div>
            <div class='fantasy-header-signin pure-u-5-12'>
                                <ul><li class='sso first'><a href='https://sso.nfl.com/login?s=fantasy&returnTo=http%3A%2F%2Ffantasy.nfl.com%2Fresearch%2Frankings%3FleagueId%3D0%26statType%3DdraftStats' >Sign In</a></li><li class='sso last'><a href='https://sso.nfl.com/register?s=fantasy&returnTo=http%3A%2F%2Ffantasy.nfl.com%2Fresearch%2Frankings%3FleagueId%3D0%26statType%3DdraftStats' >Register</a></li></ul>            </div>

        </div>

        
    </div>
</div>
<div id='fantasy-nav' class='mod dynamicModule'>
    <div class='content'>
        <div class='hd'>
            <ul><li class='navItem first'><a href='/'  class='navHome' title='Fantasy Football 2016'><span class='effect'></span><span class='text'>Fantasy '16</span></a></li><li class='navItem'><a href='/draftcenter'  class='navDraft'><span class='effect'></span><span class='text'>Draft Center</span></a></li><li class='navItem selected last'><a href='/research'  class='navResearch'><span class='effect'></span><span class='text'>Research</span></a></li></ul>        </div>
        <div class='bd'>

        </div>
        <div class='ft'>

            
                    </div>
    </div>
</div>

<div id='subNav' class='mod'>
    <div class='content'>
        <div class='bd'>
            <ul><li class='selected first'><a href='/research/rankings' >Rankings</a></li><li><a href='/research/pointsagainst' >Fantasy Points Against</a></li><li><a href='/research/projections' >Projections</a></li><li><a href='/research/scoringleaders' >Scoring Leaders</a></li><li><a href='/sapcompare?groupingType=positions'  class='playerComparisonTool sap'>Player Comparison Tool</a></li><li><a href='/research/trends' >Player Trends</a></li><li><a href='/research/statcorrections' >Stat Corrections</a></li><li class='last'><a href='/research/players' >Players</a></li></ul>        </div>
    </div>
</div><noscript>
    <div id='noJsMessage'>
        <p>Free Fantasy Football | 2015 Fantasy Football - NFL.com relies heavily on Javascript.</p>
        <p class='last'>For the ultimate experience please enable Javascript in your browser.</p>
    </div>
</noscript>
        </div>
    </div>
            <div id='subHd'>
        <div id='googleadtag-BANNER1408417989' class='ad ad-BANNER' style='width: 728px; height: 90px;' >
    <script >
    if (window.googletag) {
        googletag.cmd.push(function() {
            var path = '/4595/nfl.freefantasy/research/researchrankings',
                size = [728, 90],
                id = 'googleadtag-BANNER1408417989',
                pubService = googletag.pubads();

            pubService.collapseEmptyDivs();
            pubService.enableAsyncRendering();

            googletag.defineSlot(path, size, id).
                addService(pubService).
                setTargeting('s1', 'research').setTargeting('s2', 'researchrankings').
                setTargeting('slot', 'top').
                setTargeting('test', '').
                setTargeting('class', 'subHeaderBANNER').
                setTargeting('url', 'research_researchrankings');
            googletag.enableServices();
            googletag.display(id);
        });
    }
    </script>
</div><style>
    .g-a #bd, .g-b #bd, .g-c #bd { padding-top: 20px; }
    #bd h1.title { display: none; }
</style>
<div class='subHeaderTOPPERcontainer'>
    <h1>Player Rankings</h1>
    <span class='halfBg'></span>
    <div id='googleadtag-TOPPER685763419' class='ad ad-TOPPER' style='width: 500px; height: 70px;' >
    <script >
    if (window.googletag) {
        googletag.cmd.push(function() {
            var path = '/4595/nfl.freefantasy/research/researchrankings',
                size = [500, 70],
                id = 'googleadtag-TOPPER685763419',
                pubService = googletag.pubads();

            pubService.collapseEmptyDivs();
            pubService.enableAsyncRendering();

            googletag.defineSlot(path, size, id).
                addService(pubService).
                setTargeting('s1', 'research').setTargeting('s2', 'researchrankings').
                setTargeting('slot', 'spon').
                setTargeting('test', '').
                setTargeting('class', 'subHeaderTOPPER').
                setTargeting('url', 'research_researchrankings');
            googletag.enableServices();
            googletag.display(id);
        });
    }
    </script>
</div>
</div>    </div>
            <div id='bd-wrap'>
    <div id='bd'>

        
        
        <h1 class='title'>Player Rankings</h1>

        
                            <div id='primary'><div id='primaryContent'>
                <div id='researchRankings' class='mod dynamicModule history-researchRankings cache-* moduleName-researchRankings'>
    <div class='content'>
        <div class='hd'>

            <div id='players-filter' class='mod'>
                <div class='content'>
                    <div class='hd'>
                        <div class='wrap'>

                            <div class='position-nav nav-bar'>
                                <ul><li class='posLabel first'><span>Position:</span></li><li id='posO' class='selected last'><a href='/research/rankings?leagueId=0&position=O&statSeason=2016&statType=draftStats&week=1'  class='dynamic'><span>Top 200</span></a></li></ul>                            </div>

                        </div>
                    </div>
                    <div class='bd'>
                        <ul class='weekNav weekNav-full nav-bar'><li class='wl label first'><span>Weeks:</span></li><li class='ww ww-1'><a href='/research/rankings?leagueId=0&statType=weekStats&week=1'  class='ww ww-1'><span>1</span></a></li><li class='ww-season'><a href='/research/rankings?leagueId=0&statType=seasonStats'  class='ww-season'><span>2016 Season</span></a></li><li class='ww-draft selected last'><a href='/research/rankings?leagueId=0&statType=draftStats'  class='ww-draft'><span>Draft Rankings</span></a></li></ul>                        <div class='paginationWrap'>
                            <div class='pagination search'><span class='paginationTitle'> 1 - 100 of 200 </span><ul><li class='pageNav-pageNav-0 first'><span class='dynamic'>1</span></li><li class='pageNav-pageNav-1'><a href='?offset=101&position=O&sort=average&statType=draftStats'  class='dynamic'>2</a></li><li class='next last'><a href='?offset=101&position=O&sort=average&statType=draftStats'  class='dynamic'>></a></li></ul></div>                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class='bd'>
            <div class='tableWrap'><table cellpadding='0' cellspacing='0' class='tableType-player noGroups'><thead><tr class='last'><th class='editorDraftRankRank first' scope='col'><span>Rank</span></th><th class='playerNameAndInfo' scope='col'><span>Player</span></th><th class='playerBye' scope='col'><span>Bye</span></th><th class='editorDraftRankStock' scope='col'><span>Stock</span></th><th class='editorDraftRankAuction last' scope='col'><span>Auction Value ($)</span></th></tr></thead><tbody><tr class='player-2508061 odd first'><td class='editorDraftRankRank first'>1</td><td class='playerNameAndInfo'><div class='c c-pit'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2508061' class='playerCard playerName playerNameFull playerNameId-2508061 what-playerCard'>Antonio Brown</a> <em>WR - PIT</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>62</td></tr><tr class='player-2543496 even'><td class='editorDraftRankRank first'>2</td><td class='playerNameAndInfo'><div class='c c-nyg'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543496' class='playerCard playerName playerNameFull playerNameId-2543496 what-playerCard'>Odell Beckham</a> <em>WR - NYG</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>61</td></tr><tr class='player-2495454 odd'><td class='editorDraftRankRank first'>3</td><td class='playerNameAndInfo'><div class='c c-atl'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495454' class='playerCard playerName playerNameFull playerNameId-2495454 what-playerCard'>Julio Jones</a> <em>WR - ATL</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2495454'>View News</a>  </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>59</td></tr><tr class='player-2553435 even'><td class='editorDraftRankRank first'>4</td><td class='playerNameAndInfo'><div class='c c-ari'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2553435' class='playerCard playerName playerNameFull playerNameId-2553435 what-playerCard'>David Johnson</a> <em>RB - ARI</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=david johnson'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>51</td></tr><tr class='player-2552475 odd'><td class='editorDraftRankRank first'>5</td><td class='playerNameAndInfo'><div class='c c-la'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552475' class='playerCard playerName playerNameFull playerNameId-2552475 what-playerCard'>Todd Gurley</a> <em>RB - LA</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>50</td></tr><tr class='player-2495450 even'><td class='editorDraftRankRank first'>6</td><td class='playerNameAndInfo'><div class='c c-cin'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495450' class='playerCard playerName playerNameFull playerNameId-2495450 what-playerCard'>A.J. Green</a> <em>WR - CIN</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2495450'>View News</a>  <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=a.j. green'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>49</td></tr><tr class='player-2507164 odd'><td class='editorDraftRankRank first'>7</td><td class='playerNameAndInfo'><div class='c c-min'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2507164' class='playerCard playerName playerNameFull playerNameId-2507164 what-playerCard'>Adrian Peterson</a> <em>RB - MIN</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=adrian peterson'>View Video</a></div></td><td class='playerBye'>6</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>48</td></tr><tr class='player-2555224 even'><td class='editorDraftRankRank first'>8</td><td class='playerNameAndInfo'><div class='c c-dal'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2555224' class='playerCard playerName playerNameFull playerNameId-2555224 what-playerCard'>Ezekiel Elliott</a> <em>RB - DAL</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=ezekiel elliott'>View Video</a></div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>47</td></tr><tr class='player-497240 odd'><td class='editorDraftRankRank first'>9</td><td class='playerNameAndInfo'><div class='c c-ne'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497240' class='playerCard playerName playerNameFull playerNameId-497240 what-playerCard'>Rob Gronkowski</a> <em>TE - NE</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>46</td></tr><tr class='player-497278 even'><td class='editorDraftRankRank first'>10</td><td class='playerNameAndInfo'><div class='c c-dal'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497278' class='playerCard playerName playerNameFull playerNameId-497278 what-playerCard'>Dez Bryant</a> <em>WR - DAL</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=dez bryant'>View Video</a></div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>46</td></tr><tr class='player-2540165 odd'><td class='editorDraftRankRank first'>11</td><td class='playerNameAndInfo'><div class='c c-hou'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540165' class='playerCard playerName playerNameFull playerNameId-2540165 what-playerCard'>DeAndre Hopkins</a> <em>WR - HOU</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=deandre hopkins'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>45</td></tr><tr class='player-2533034 even'><td class='editorDraftRankRank first'>12</td><td class='playerNameAndInfo'><div class='c c-hou'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2533034' class='playerCard playerName playerNameFull playerNameId-2533034 what-playerCard'>Lamar Miller</a> <em>RB - HOU</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=lamar miller'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>45</td></tr><tr class='player-2543583 odd'><td class='editorDraftRankRank first'>13</td><td class='playerNameAndInfo'><div class='c c-atl'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543583' class='playerCard playerName playerNameFull playerNameId-2543583 what-playerCard'>Devonta Freeman</a> <em>RB - ATL</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=devonta freeman'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>42</td></tr><tr class='player-2543509 even'><td class='editorDraftRankRank first'>14</td><td class='playerNameAndInfo'><div class='c c-jax'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543509' class='playerCard playerName playerNameFull playerNameId-2543509 what-playerCard'>Allen Robinson</a> <em>WR - JAX</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=allen robinson'>View Video</a></div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>42</td></tr><tr class='player-1032 odd'><td class='editorDraftRankRank first'>15</td><td class='playerNameAndInfo'><div class='c c-gb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=1032' class='playerCard playerName playerNameFull playerNameId-1032 what-playerCard'>Jordy Nelson</a> <em>WR - GB</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=1032'>View News</a>  <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=jordy nelson'>View Video</a></div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>39</td></tr><tr class='player-2540168 even'><td class='editorDraftRankRank first'>16</td><td class='playerNameAndInfo'><div class='c c-gb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540168' class='playerCard playerName playerNameFull playerNameId-2540168 what-playerCard'>Eddie Lacy</a> <em>RB - GB</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=eddie lacy'>View Video</a></div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>38</td></tr><tr class='player-925 odd'><td class='editorDraftRankRank first'>17</td><td class='playerNameAndInfo'><div class='c c-kc'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=925' class='playerCard playerName playerNameFull playerNameId-925 what-playerCard'>Jamaal Charles</a> <em>RB - KC</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>35</td></tr><tr class='player-2540154 even'><td class='editorDraftRankRank first'>18</td><td class='playerNameAndInfo'><div class='c c-sd'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540154' class='playerCard playerName playerNameFull playerNameId-2540154 what-playerCard'>Keenan Allen</a> <em>WR - SD</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=keenan allen'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>34</td></tr><tr class='player-2495466 odd'><td class='editorDraftRankRank first'>19</td><td class='playerNameAndInfo'><div class='c c-no'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495466' class='playerCard playerName playerNameFull playerNameId-2495466 what-playerCard'>Mark Ingram</a> <em>RB - NO</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=mark ingram'>View Video</a></div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>33</td></tr><tr class='player-2532899 even'><td class='editorDraftRankRank first'>20</td><td class='playerNameAndInfo'><div class='c c-tb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2532899' class='playerCard playerName playerNameFull playerNameId-2532899 what-playerCard'>Doug Martin</a> <em>RB - TB</em>    </div></td><td class='playerBye'>6</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>33</td></tr><tr class='player-2533039 odd'><td class='editorDraftRankRank first'>21</td><td class='playerNameAndInfo'><div class='c c-chi'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2533039' class='playerCard playerName playerNameFull playerNameId-2533039 what-playerCard'>Alshon Jeffery</a> <em>WR - CHI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>32</td></tr><tr class='player-2495893 even'><td class='editorDraftRankRank first'>22</td><td class='playerNameAndInfo'><div class='c c-nyj'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495893' class='playerCard playerName playerNameFull playerNameId-2495893 what-playerCard'>Brandon Marshall</a> <em>WR - NYJ</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2495893'>View News</a>  <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=brandon marshall'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>32</td></tr><tr class='player-2543468 odd'><td class='editorDraftRankRank first'>23</td><td class='playerNameAndInfo'><div class='c c-tb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543468' class='playerCard playerName playerNameFull playerNameId-2543468 what-playerCard'>Mike Evans</a> <em>WR - TB</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=mike evans'>View Video</a></div></td><td class='playerBye'>6</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>32</td></tr><tr class='player-79607 even'><td class='editorDraftRankRank first'>24</td><td class='playerNameAndInfo'><div class='c c-buf'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=79607' class='playerCard playerName playerNameFull playerNameId-79607 what-playerCard'>LeSean McCoy</a> <em>RB - BUF</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=lesean mccoy'>View Video</a></div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>31</td></tr><tr class='player-2506363 odd'><td class='editorDraftRankRank first'>25</td><td class='playerNameAndInfo'><div class='c c-gb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2506363' class='playerCard playerName playerNameFull playerNameId-2506363 what-playerCard'>Aaron Rodgers</a> <em>QB - GB</em>    </div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>31</td></tr><tr class='player-2495455 even'><td class='editorDraftRankRank first'>26</td><td class='playerNameAndInfo'><div class='c c-car'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495455' class='playerCard playerName playerNameFull playerNameId-2495455 what-playerCard'>Cam Newton</a> <em>QB - CAR</em>    </div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>31</td></tr><tr class='player-2552487 odd'><td class='editorDraftRankRank first'>27</td><td class='playerNameAndInfo'><div class='c c-oak'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552487' class='playerCard playerName playerNameFull playerNameId-2552487 what-playerCard'>Amari Cooper</a> <em>WR - OAK</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>28</td></tr><tr class='player-497328 even'><td class='editorDraftRankRank first'>28</td><td class='playerNameAndInfo'><div class='c c-den'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497328' class='playerCard playerName playerNameFull playerNameId-497328 what-playerCard'>Demaryius Thomas</a> <em>WR - DEN</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=demaryius thomas'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>28</td></tr><tr class='player-2540175 odd'><td class='editorDraftRankRank first'>29</td><td class='playerNameAndInfo'><div class='c c-pit'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540175' class='playerCard playerName playerNameFull playerNameId-2540175 what-playerCard'>Le'Veon Bell</a> <em>RB - PIT</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=le'veon bell'>View Video</a></div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>27</td></tr><tr class='player-2540269 even'><td class='editorDraftRankRank first'>30</td><td class='playerNameAndInfo'><div class='c c-den'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540269' class='playerCard playerName playerNameFull playerNameId-2540269 what-playerCard'>C.J. Anderson</a> <em>RB - DEN</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=c.j. anderson'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>27</td></tr><tr class='player-2543743 odd'><td class='editorDraftRankRank first'>31</td><td class='playerNameAndInfo'><div class='c c-sf'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543743' class='playerCard playerName playerNameFull playerNameId-2543743 what-playerCard'>Carlos Hyde</a> <em>RB - SF</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=carlos hyde'>View Video</a></div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>26</td></tr><tr class='player-234 even'><td class='editorDraftRankRank first'>32</td><td class='playerNameAndInfo'><div class='c c-nyj'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=234' class='playerCard playerName playerNameFull playerNameId-234 what-playerCard'>Matt Forte</a> <em>RB - NYJ</em>    </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>25</td></tr><tr class='player-2543457 odd'><td class='editorDraftRankRank first'>33</td><td class='playerNameAndInfo'><div class='c c-buf'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543457' class='playerCard playerName playerNameFull playerNameId-2543457 what-playerCard'>Sammy Watkins</a> <em>WR - BUF</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2543457'>View News</a>  <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=sammy watkins'>View Video</a></div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>25</td></tr><tr class='player-2543488 even'><td class='editorDraftRankRank first'>34</td><td class='playerNameAndInfo'><div class='c c-mia'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543488' class='playerCard playerName playerNameFull playerNameId-2543488 what-playerCard'>Jarvis Landry</a> <em>WR - MIA</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=jarvis landry'>View Video</a></div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>25</td></tr><tr class='player-2543498 odd'><td class='editorDraftRankRank first'>35</td><td class='playerNameAndInfo'><div class='c c-no'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543498' class='playerCard playerName playerNameFull playerNameId-2543498 what-playerCard'>Brandin Cooks</a> <em>WR - NO</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=brandin cooks'>View Video</a></div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>24</td></tr><tr class='player-497188 even'><td class='editorDraftRankRank first'>36</td><td class='playerNameAndInfo'><div class='c c-phi'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497188' class='playerCard playerName playerNameFull playerNameId-497188 what-playerCard'>Ryan Mathews</a> <em>RB - PHI</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=ryan mathews'>View Video</a></div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>24</td></tr><tr class='player-949 odd'><td class='editorDraftRankRank first'>37</td><td class='playerNameAndInfo'><div class='c c-car'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=949' class='playerCard playerName playerNameFull playerNameId-949 what-playerCard'>Jonathan Stewart</a> <em>RB - CAR</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=jonathan stewart'>View Video</a></div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>24</td></tr><tr class='player-80429 even'><td class='editorDraftRankRank first'>38</td><td class='playerNameAndInfo'><div class='c c-kc'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=80429' class='playerCard playerName playerNameFull playerNameId-80429 what-playerCard'>Jeremy Maclin</a> <em>WR - KC</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>24</td></tr><tr class='player-238498 odd'><td class='editorDraftRankRank first'>39</td><td class='playerNameAndInfo'><div class='c c-ne'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=238498' class='playerCard playerName playerNameFull playerNameId-238498 what-playerCard'>Julian Edelman</a> <em>WR - NE</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=julian edelman'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>23</td></tr><tr class='player-2532975 even'><td class='editorDraftRankRank first'>40</td><td class='playerNameAndInfo'><div class='c c-sea'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2532975' class='playerCard playerName playerNameFull playerNameId-2532975 what-playerCard'>Russell Wilson</a> <em>QB - SEA</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>23</td></tr><tr class='player-2540160 odd'><td class='editorDraftRankRank first'>41</td><td class='playerNameAndInfo'><div class='c c-was'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540160' class='playerCard playerName playerNameFull playerNameId-2540160 what-playerCard'>Jordan Reed</a> <em>TE - WAS</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>23</td></tr><tr class='player-2495448 even'><td class='editorDraftRankRank first'>42</td><td class='playerNameAndInfo'><div class='c c-gb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495448' class='playerCard playerName playerNameFull playerNameId-2495448 what-playerCard'>Randall Cobb</a> <em>WR - GB</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=randall cobb'>View Video</a></div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>22</td></tr><tr class='player-2532865 odd'><td class='editorDraftRankRank first'>43</td><td class='playerNameAndInfo'><div class='c c-ind'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2532865' class='playerCard playerName playerNameFull playerNameId-2532865 what-playerCard'>T.Y. Hilton</a> <em>WR - IND</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=t.y. hilton'>View Video</a></div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>22</td></tr><tr class='player-497284 even'><td class='editorDraftRankRank first'>44</td><td class='playerNameAndInfo'><div class='c c-nyj'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497284' class='playerCard playerName playerNameFull playerNameId-497284 what-playerCard'>Eric Decker</a> <em>WR - NYJ</em>    </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>22</td></tr><tr class='player-2530747 odd'><td class='editorDraftRankRank first'>45</td><td class='playerNameAndInfo'><div class='c c-sea'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2530747' class='playerCard playerName playerNameFull playerNameId-2530747 what-playerCard'>Doug Baldwin</a> <em>WR - SEA</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>22</td></tr><tr class='player-2532841 even'><td class='editorDraftRankRank first'>46</td><td class='playerNameAndInfo'><div class='c c-ari'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2532841' class='playerCard playerName playerNameFull playerNameId-2532841 what-playerCard'>Michael Floyd</a> <em>WR - ARI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>21</td></tr><tr class='player-2543847 odd'><td class='editorDraftRankRank first'>47</td><td class='playerNameAndInfo'><div class='c c-ari'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543847' class='playerCard playerName playerNameFull playerNameId-2543847 what-playerCard'>John Brown</a> <em>WR - ARI</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2543847'>View News</a>  </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>21</td></tr><tr class='player-2495700 even'><td class='editorDraftRankRank first'>48</td><td class='playerNameAndInfo'><div class='c c-car'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495700' class='playerCard playerName playerNameFull playerNameId-2495700 what-playerCard'>Greg Olsen</a> <em>TE - CAR</em>    </div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>21</td></tr><tr class='player-2543614 odd'><td class='editorDraftRankRank first'>49</td><td class='playerNameAndInfo'><div class='c c-ind'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543614' class='playerCard playerName playerNameFull playerNameId-2543614 what-playerCard'>Donte Moncrief</a> <em>WR - IND</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>20</td></tr><tr class='player-497326 even'><td class='editorDraftRankRank first'>50</td><td class='playerNameAndInfo'><div class='c c-det'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497326' class='playerCard playerName playerNameFull playerNameId-497326 what-playerCard'>Golden Tate</a> <em>WR - DET</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>19</td></tr><tr class='player-2541161 odd'><td class='editorDraftRankRank first'>51</td><td class='playerNameAndInfo'><div class='c c-oak'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2541161' class='playerCard playerName playerNameFull playerNameId-2541161 what-playerCard'>Latavius Murray</a> <em>RB - OAK</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2541161'>View News</a>  </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>19</td></tr><tr class='player-2543603 even'><td class='editorDraftRankRank first'>52</td><td class='playerNameAndInfo'><div class='c c-cin'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543603' class='playerCard playerName playerNameFull playerNameId-2543603 what-playerCard'>Jeremy Hill</a> <em>RB - CIN</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2543603'>View News</a>  </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>19</td></tr><tr class='player-2540156 odd'><td class='editorDraftRankRank first'>53</td><td class='playerNameAndInfo'><div class='c c-cin'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540156' class='playerCard playerName playerNameFull playerNameId-2540156 what-playerCard'>Giovani Bernard</a> <em>RB - CIN</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2540156'>View News</a>  </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>19</td></tr><tr class='player-1581 even'><td class='editorDraftRankRank first'>54</td><td class='playerNameAndInfo'><div class='c c-was'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=1581' class='playerCard playerName playerNameFull playerNameId-1581 what-playerCard'>DeSean Jackson</a> <em>WR - WAS</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>17</td></tr><tr class='player-2543500 odd'><td class='editorDraftRankRank first'>55</td><td class='playerNameAndInfo'><div class='c c-phi'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543500' class='playerCard playerName playerNameFull playerNameId-2543500 what-playerCard'>Jordan Matthews</a> <em>WR - PHI</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2543500'>View News</a>  </div></td><td class='playerBye'>4</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>17</td></tr><tr class='player-2553733 even'><td class='editorDraftRankRank first'>56</td><td class='playerNameAndInfo'><div class='c c-sea'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2553733' class='playerCard playerName playerNameFull playerNameId-2553733 what-playerCard'>Thomas Rawls</a> <em>RB - SEA</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>17</td></tr><tr class='player-4327 odd'><td class='editorDraftRankRank first'>57</td><td class='playerNameAndInfo'><div class='c c-sd'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=4327' class='playerCard playerName playerNameFull playerNameId-4327 what-playerCard'>Danny Woodhead</a> <em>RB - SD</em>    </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>16</td></tr><tr class='player-2543471 even'><td class='editorDraftRankRank first'>58</td><td class='playerNameAndInfo'><div class='c c-car'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543471' class='playerCard playerName playerNameFull playerNameId-2543471 what-playerCard'>Kelvin Benjamin</a> <em>WR - CAR</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=kelvin benjamin'>View Video</a></div></td><td class='playerBye'>7</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>16</td></tr><tr class='player-497322 odd'><td class='editorDraftRankRank first'>59</td><td class='playerNameAndInfo'><div class='c c-den'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=497322' class='playerCard playerName playerNameFull playerNameId-497322 what-playerCard'>Emmanuel Sanders</a> <em>WR - DEN</em>    </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>16</td></tr><tr class='player-79555 even'><td class='editorDraftRankRank first'>60</td><td class='playerNameAndInfo'><div class='c c-mia'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=79555' class='playerCard playerName playerNameFull playerNameId-79555 what-playerCard'>Arian Foster</a> <em>RB - MIA</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>16</td></tr><tr class='player-2552635 odd'><td class='editorDraftRankRank first'>61</td><td class='playerNameAndInfo'><div class='c c-was'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552635' class='playerCard playerName playerNameFull playerNameId-2552635 what-playerCard'>Matt Jones</a> <em>RB - WAS</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2552635'>View News</a>  </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>15</td></tr><tr class='player-2552461 even'><td class='editorDraftRankRank first'>62</td><td class='playerNameAndInfo'><div class='c c-cle'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552461' class='playerCard playerName playerNameFull playerNameId-2552461 what-playerCard'>Duke Johnson</a> <em>RB - CLE</em>    </div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>15</td></tr><tr class='player-2495207 odd'><td class='editorDraftRankRank first'>63</td><td class='playerNameAndInfo'><div class='c c-ten'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495207' class='playerCard playerName playerNameFull playerNameId-2495207 what-playerCard'>DeMarco Murray</a> <em>RB - TEN</em>    </div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-2540148 even'><td class='editorDraftRankRank first'>64</td><td class='playerNameAndInfo'><div class='c c-cin'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540148' class='playerCard playerName playerNameFull playerNameId-2540148 what-playerCard'>Tyler Eifert</a> <em>TE - CIN</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=tyler eifert'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-2504775 odd'><td class='editorDraftRankRank first'>65</td><td class='playerNameAndInfo'><div class='c c-no'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2504775' class='playerCard playerName playerNameFull playerNameId-2504775 what-playerCard'>Drew Brees</a> <em>QB - NO</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-2506106 even'><td class='editorDraftRankRank first'>66</td><td class='playerNameAndInfo'><div class='c c-ari'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2506106' class='playerCard playerName playerNameFull playerNameId-2506106 what-playerCard'>Larry Fitzgerald</a> <em>WR - ARI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-71269 odd'><td class='editorDraftRankRank first'>67</td><td class='playerNameAndInfo'><div class='c c-oak'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=71269' class='playerCard playerName playerNameFull playerNameId-71269 what-playerCard'>Michael Crabtree</a> <em>WR - OAK</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-2552582 even'><td class='editorDraftRankRank first'>68</td><td class='playerNameAndInfo'><div class='c c-mia'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552582' class='playerCard playerName playerNameFull playerNameId-2552582 what-playerCard'>Jay Ajayi</a> <em>RB - MIA</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>14</td></tr><tr class='player-2505245 odd'><td class='editorDraftRankRank first'>69</td><td class='playerNameAndInfo'><div class='c c-ari'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2505245' class='playerCard playerName playerNameFull playerNameId-2505245 what-playerCard'>Carson Palmer</a> <em>QB - ARI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>13</td></tr><tr class='player-2507999 even'><td class='editorDraftRankRank first'>70</td><td class='playerNameAndInfo'><div class='c c-jax'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2507999' class='playerCard playerName playerNameFull playerNameId-2507999 what-playerCard'>Chris Ivory</a> <em>RB - JAX</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2507999'>View News</a>  </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>13</td></tr><tr class='player-2552379 odd'><td class='editorDraftRankRank first'>71</td><td class='playerNameAndInfo'><div class='c c-chi'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552379' class='playerCard playerName playerNameFull playerNameId-2552379 what-playerCard'>Jeremy Langford</a> <em>RB - CHI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>13</td></tr><tr class='player-2533031 even'><td class='editorDraftRankRank first'>72</td><td class='playerNameAndInfo'><div class='c c-ind'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2533031' class='playerCard playerName playerNameFull playerNameId-2533031 what-playerCard'>Andrew Luck</a> <em>QB - IND</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>13</td></tr><tr class='player-2555333 odd'><td class='editorDraftRankRank first'>73</td><td class='playerNameAndInfo'><div class='c c-cle'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2555333' class='playerCard playerName playerNameFull playerNameId-2555333 what-playerCard'>Corey Coleman</a> <em>WR - CLE</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=corey coleman'>View Video</a></div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>12</td></tr><tr class='player-2552469 even'><td class='editorDraftRankRank first'>74</td><td class='playerNameAndInfo'><div class='c c-sd'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552469' class='playerCard playerName playerNameFull playerNameId-2552469 what-playerCard'>Melvin Gordon</a> <em>RB - SD</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=melvin gordon'>View Video</a></div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>12</td></tr><tr class='player-2555295 odd'><td class='editorDraftRankRank first'>75</td><td class='playerNameAndInfo'><div class='c c-nyg'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2555295' class='playerCard playerName playerNameFull playerNameId-2555295 what-playerCard'>Sterling Shepard</a> <em>WR - NYG</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=sterling shepard'>View Video</a></div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>12</td></tr><tr class='player-2495459 even'><td class='editorDraftRankRank first'>76</td><td class='playerNameAndInfo'><div class='c c-sf'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495459' class='playerCard playerName playerNameFull playerNameId-2495459 what-playerCard'>Torrey Smith</a> <em>WR - SF</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>12</td></tr><tr class='player-2506404 odd'><td class='editorDraftRankRank first'>77</td><td class='playerNameAndInfo'><div class='c c-ind'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2506404' class='playerCard playerName playerNameFull playerNameId-2506404 what-playerCard'>Frank Gore</a> <em>RB - IND</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>12</td></tr><tr class='player-2552374 even'><td class='editorDraftRankRank first'>78</td><td class='playerNameAndInfo'><div class='c c-det'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552374' class='playerCard playerName playerNameFull playerNameId-2552374 what-playerCard'>Ameer Abdullah</a> <em>RB - DET</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>11</td></tr><tr class='player-2540258 odd'><td class='editorDraftRankRank first'>79</td><td class='playerNameAndInfo'><div class='c c-kc'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540258' class='playerCard playerName playerNameFull playerNameId-2540258 what-playerCard'>Travis Kelce</a> <em>TE - KC</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>11</td></tr><tr class='player-2550353 even'><td class='editorDraftRankRank first'>80</td><td class='playerNameAndInfo'><div class='c c-jax'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2550353' class='playerCard playerName playerNameFull playerNameId-2550353 what-playerCard'>Allen Hurns</a> <em>WR - JAX</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2550353'>View News</a>  </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>11</td></tr><tr class='player-2552430 odd'><td class='editorDraftRankRank first'>81</td><td class='playerNameAndInfo'><div class='c c-sea'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552430' class='playerCard playerName playerNameFull playerNameId-2552430 what-playerCard'>Tyler Lockett</a> <em>WR - SEA</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>10</td></tr><tr class='player-2552471 even'><td class='editorDraftRankRank first'>82</td><td class='playerNameAndInfo'><div class='c c-jax'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552471' class='playerCard playerName playerNameFull playerNameId-2552471 what-playerCard'>T.J. Yeldon</a> <em>RB - JAX</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2552471'>View News</a>  </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>10</td></tr><tr class='player-1060 odd'><td class='editorDraftRankRank first'>83</td><td class='playerNameAndInfo'><div class='c c-cle'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=1060' class='playerCard playerName playerNameFull playerNameId-1060 what-playerCard'>Gary Barnidge</a> <em>TE - CLE</em>    </div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>10</td></tr><tr class='player-71345 even'><td class='editorDraftRankRank first'>84</td><td class='playerNameAndInfo'><div class='c c-nyg'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=71345' class='playerCard playerName playerNameFull playerNameId-71345 what-playerCard'>Rashad Jennings</a> <em>RB - NYG</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>9</td></tr><tr class='player-2504211 odd'><td class='editorDraftRankRank first'>85</td><td class='playerNameAndInfo'><div class='c c-ne'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2504211' class='playerCard playerName playerNameFull playerNameId-2504211 what-playerCard'>Tom Brady</a> <em>QB - NE</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=tom brady'>View Video</a></div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>9</td></tr><tr class='player-2543770 even'><td class='editorDraftRankRank first'>86</td><td class='playerNameAndInfo'><div class='c c-tb'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2543770' class='playerCard playerName playerNameFull playerNameId-2543770 what-playerCard'>Charles Sims</a> <em>RB - TB</em>    </div></td><td class='playerBye'>6</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>9</td></tr><tr class='player-2553432 odd'><td class='editorDraftRankRank first'>87</td><td class='playerNameAndInfo'><div class='c c-chi'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2553432' class='playerCard playerName playerNameFull playerNameId-2553432 what-playerCard'>Kevin White</a> <em>WR - CHI</em>    </div></td><td class='playerBye'>9</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2540020 even'><td class='editorDraftRankRank first'>88</td><td class='playerNameAndInfo'><div class='c c-det'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2540020' class='playerCard playerName playerNameFull playerNameId-2540020 what-playerCard'>Theo Riddick</a> <em>RB - DET</em>    </div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2495966 odd'><td class='editorDraftRankRank first'>89</td><td class='playerNameAndInfo'><div class='c c-ten'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495966' class='playerCard playerName playerNameFull playerNameId-2495966 what-playerCard'>Delanie Walker</a> <em>TE - TEN</em>    </div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2530660 even'><td class='editorDraftRankRank first'>90</td><td class='playerNameAndInfo'><div class='c c-bal'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2530660' class='playerCard playerName playerNameFull playerNameId-2530660 what-playerCard'>Kamar Aiken</a> <em>WR - BAL</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=kamar aiken'>View Video</a></div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2556075 odd'><td class='editorDraftRankRank first'>91</td><td class='playerNameAndInfo'><div class='c c-ten'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2556075' class='playerCard playerName playerNameFull playerNameId-2556075 what-playerCard'>Derrick Henry</a> <em>RB - TEN</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=derrick henry'>View Video</a></div></td><td class='playerBye'>13</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2532884 even'><td class='editorDraftRankRank first'>92</td><td class='playerNameAndInfo'><div class='c c-det'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2532884' class='playerCard playerName playerNameFull playerNameId-2532884 what-playerCard'>Marvin Jones</a> <em>WR - DET</em>    <a class='playerNote playerNote-fantasyLive' title='New Fantasy Live Video' target='_blank'
                     href='http://www.nfl.com/fantasyfootball/live?icampaign=fantasy_flicon_fantasylive_watch#searchQuery=marvin jones'>View Video</a></div></td><td class='playerBye'>10</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2552409 odd'><td class='editorDraftRankRank first'>93</td><td class='playerNameAndInfo'><div class='c c-mia'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2552409' class='playerCard playerName playerNameFull playerNameId-2552409 what-playerCard'>DeVante Parker</a> <em>WR - MIA</em>  <a class='playerNote playerCard what-playerCard playerNote-breaking' title='View Breaking Player News' onclick='return false' href='/players/card?leagueId=0&playerId=2552409'>View News</a>  </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2506121 even'><td class='editorDraftRankRank first'>94</td><td class='playerNameAndInfo'><div class='c c-sd'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2506121' class='playerCard playerName playerNameFull playerNameId-2506121 what-playerCard'>Philip Rivers</a> <em>QB - SD</em>    </div></td><td class='playerBye'>11</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>8</td></tr><tr class='player-2539322 odd'><td class='editorDraftRankRank first'>95</td><td class='playerNameAndInfo'><div class='c c-sea'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2539322' class='playerCard playerName playerNameFull playerNameId-2539322 what-playerCard'>Christine Michael</a> <em>RB - SEA</em>    </div></td><td class='playerBye'>5</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>7</td></tr><tr class='player-2505996 even'><td class='editorDraftRankRank first'>96</td><td class='playerNameAndInfo'><div class='c c-nyg'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2505996' class='playerCard playerName playerNameFull playerNameId-2505996 what-playerCard'>Eli Manning</a> <em>QB - NYG</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>7</td></tr><tr class='player-2506109 odd'><td class='editorDraftRankRank first'>97</td><td class='playerNameAndInfo'><div class='c c-pit'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2506109' class='playerCard playerName playerNameFull playerNameId-2506109 what-playerCard'>Ben Roethlisberger</a> <em>QB - PIT</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>7</td></tr><tr class='player-2539336 even'><td class='editorDraftRankRank first'>98</td><td class='playerNameAndInfo'><div class='c c-la'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2539336' class='playerCard playerName playerNameFull playerNameId-2539336 what-playerCard'>Tavon Austin</a> <em>WR - LA</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>7</td></tr><tr class='player-927 odd'><td class='editorDraftRankRank first'>99</td><td class='playerNameAndInfo'><div class='c c-bal'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=927' class='playerCard playerName playerNameFull playerNameId-927 what-playerCard'>Justin Forsett</a> <em>RB - BAL</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>6</td></tr><tr class='player-2495979 even last'><td class='editorDraftRankRank first'>100</td><td class='playerNameAndInfo'><div class='c c-pit'><b></b><a onclick='return false' href='/players/card?leagueId=0&playerId=2495979' class='playerCard playerName playerNameFull playerNameId-2495979 what-playerCard'>DeAngelo Williams</a> <em>RB - PIT</em>    </div></td><td class='playerBye'>8</td><td class='editorDraftRankStock'>even</td><td class='editorDraftRankAuction last'>6</td></tr></tbody></table></div>        </div>

        <div class='ft paginationWrap'>
            <div class='paginationWrap'>
                <div class='pagination search'><span class='paginationTitle'> 1 - 100 of 200 </span><ul><li class='pageNav-pageNav-0 first'><span class='dynamic'>1</span></li><li class='pageNav-pageNav-1'><a href='?offset=101&position=O&sort=average&statType=draftStats'  class='dynamic'>2</a></li><li class='next last'><a href='?offset=101&position=O&sort=average&statType=draftStats'  class='dynamic'>></a></li></ul></div>            </div>
        </div>

    </div>
</div><meta data-temp='' name='viewport' content='width=1030' />            </div></div>            
                        <div class='sh s'></div>
        <div class='sh t'></div>
        </div>

    </div>
            <div id='ft-wrap'>
        <div id='ft'>
            

<div id='footer' class='mod'> 
    <div class='content'> 
        <div class='hd nflprograms'> 
            <h4><a href='http://www.nfl.com' target='_blank'>NFL</a></h4> 
            <ul><li class='first'><ul><li class='first'><a href='http://nflrush.com/?campaign=NFL_footer'  target='_blank'>NFLRush.com</a></li><li><a href='http://www.nfl.com/play60'  target='_blank'>NFL PLAY 60</a></li><li><a href='http://nflplayers.com/'  target='_blank'>NFLPlayers.com</a></li><li><a href='http://www.nflyouthpd.com/'  target='_blank'>NFL Youth Tackle</a></li><li><a href='http://profootballhof.com/'  target='_blank'>Profootballhof.com</a></li><li class='last'><a href='http://www.usafootball.com/'  target='_blank'>USA Football</a></li></ul></li><li class='last'><ul><li class='first'><a href='http://www.nflshop.com/entry.point?target=z&source=NFL_SHOP_TAB_BOTTOM_BANNER'  target='_blank'>NFL Shop</a></li><li><a href='http://www.nflauction.nfl.com/'  target='_blank'>NFL Auction</a></li><li><a href='http://www.nfl.com/nflnetwork'  target='_blank'>NFL Network</a></li><li><a href='http://www.nflonlocation.net'  target='_blank'>NFL On Location</a></li><li class='last'><a href='http://www.jointheteam.com/'  target='_blank'>In The Community</a></li></ul></li></ul>        </div> 
        <div class='bd afc'> 
            <h4>AFC</h4> 
            <ul><li class='first'><ul><li class='first'><a href='http://www.buffalobills.com/'  target='_blank'>Bills</a></li><li><a href='http://www.miamidolphins.com/'  target='_blank'>Dolphins</a></li><li><a href='http://www.patriots.com/'  target='_blank'>Patriots</a></li><li class='last'><a href='http://www.newyorkjets.com/'  target='_blank'>Jets</a></li></ul></li><li><ul><li class='first'><a href='http://www.baltimoreravens.com/'  target='_blank'>Ravens</a></li><li><a href='http://www.bengals.com/'  target='_blank'>Bengals</a></li><li><a href='http://www.clevelandbrowns.com/'  target='_blank'>Browns</a></li><li class='last'><a href='http://www.steelers.com/'  target='_blank'>Steelers</a></li></ul></li><li><ul><li class='first'><a href='http://www.titansonline.com/'  target='_blank'>Titans</a></li><li><a href='http://www.houstontexans.com/'  target='_blank'>Texans</a></li><li><a href='http://www.colts.com/'  target='_blank'>Colts</a></li><li class='last'><a href='http://www.jaguars.com/'  target='_blank'>Jaguars</a></li></ul></li><li class='last'><ul><li class='first'><a href='http://www.denverbroncos.com/'  target='_blank'>Broncos</a></li><li><a href='http://www.kcchiefs.com/'  target='_blank'>Chiefs</a></li><li><a href='http://www.raiders.com/'  target='_blank'>Raiders</a></li><li class='last'><a href='http://www.chargers.com/'  target='_blank'>Chargers</a></li></ul></li></ul>        </div> 
        <div class='ft nfc'> 
            <h4>NFC</h4> 
            <ul><li class='first'><ul><li class='first'><a href='http://www.dallascowboys.com/'  target='_blank'>Cowboys</a></li>
                        <li><a href='http://www.giants.com/'  target='_blank'>Giants</a></li>
                        <li><a href='http://www.philadelphiaeagles.com/'  target='_blank'>Eagles</a></li>
                        <li class='last'><a href='http://www.redskins.com/'  target='_blank'>Redskins</a></li></ul></li><li><ul><li class='first'><a href='http://www.chicagobears.com/'  target='_blank'>Bears</a></li><li><a href='http://www.detroitlions.com/'  target='_blank'>Lions</a></li><li><a href='http://www.packers.com/'  target='_blank'>Packers</a></li><li class='last'><a href='http://www.vikings.com/'  target='_blank'>Vikings</a></li></ul></li><li><ul><li class='first'><a href='http://www.atlantafalcons.com/'  target='_blank'>Falcons</a></li><li><a href='http://www.panthers.com/'  target='_blank'>Panthers</a></li><li><a href='http://www.neworleanssaints.com/'  target='_blank'>Saints</a></li><li class='last'><a href='http://www.buccaneers.com/'  target='_blank'>Buccaneers</a></li></ul></li><li class='last'><ul><li class='first'><a href='http://www.therams.com/'  target='_blank'>Rams</a></li><li><a href='http://www.azcardinals.com/'  target='_blank'>Cardinals</a></li><li><a href='http://www.sf49ers.com/'  target='_blank'>49ers</a></li><li class='last'><a href='http://www.seahawks.com/'  target='_blank'>Seahawks</a></li></ul></li></ul>        </div>
    </div> 
</div> 



<script type='text/javascript'>
/** Set Report Suite Environment Variable **/
var s_account='cbsnfl,nflglobal';

/* Adobe Tag Container Loader version: 1.0.7
Copyright 1996-2012 Adobe, Inc. All Rights Reserved
More info available at http://www.omniture.com */
var s_analytics=new TagContainerLoader()
s_analytics.tagContainerDC='d1'
s_analytics.tagContainerNamespace='nfl'
s_analytics.tagContainerName='prodscode'
s_analytics.loadTagContainer()

var s=new TagContainerLoader()
s.tagContainerDC='d1'
s.tagContainerNamespace='nfl'
s.tagContainerName='fantasyconversion'
s.loadTagContainer()

/************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
function TagContainerLoader(){var t=this,w=t.w=window;t.d=w.document;t._c='s_l';if(!w.s_c_il){w.s_c_il=[];w.s_c_in=0}t._il=w.s_c_il;t._in=w.s_c_in;t._il[t._in]=t;w.s_c_in++;t.timeout=5000;t.to=
new Function('var t=s_c_il['+t._in+'];if(t.mt)t.mt(0)');t.loadTagContainer=function(){var t=this,l,p=t.d.body,n,a=t.tagContainerServer?t.tagContainerServer:'www.adobetag.com',b=
t.tagContainerServerSecure?t.tagContainerServerSecure:a,c=t.d.cookie,d=t.tagContainerEnv?t.tagContainerEnv:(c?(c.indexOf('s_tagEnv=dev')>=0?'dev':(c.indexOf('s_tagEnv=stage')>=0?'stage':'live')):
'live'),u=(t.w.location.protocol.toLowerCase().indexOf('https')>=0?'https://'+b:'http://'+a)+'/'+(t.tagContainerDC?t.tagContainerDC+'/':'')+t.tagContainerNamespace+'/'+d+'/'+t.tagContainerName+'.js'
if(t.tagContainerURL)u=t.tagContainerURL;if(t.timeout)t.ti=setTimeout(t.to,t.timeout);if(t.d.getElementsByTagName){l=t.d.getElementsByTagName('HEAD');if(l&&l[0])p=l[0]}else p=0;if(
p&&!t.tagContainerSynchronous){n=t.d.createElement('SCRIPT');if(n){n.type='text/javascript';n.setAttribute('async','async');n.src=u;if(p.firstChild)p.insertBefore(n,p.firstChild);else p.appendChild(n)
}}else t.d.write('<sc'+'ript language='JavaScript' type='text/javascript' sr'+'c=''+u+''></sc'+'ript>')};t.fs=function(x,y){if(x&&y){var a=x.split(','),b=y.split(','),i,j;for(i=0;i<a.length;i++){
for(j=0;j<b.length;j++)if(a[i]==b[j])return 1}}return 0};t.aa=function(a){var b=0,i;if(a){b=[];for(i=0;i<a.length;i++)b[i]=a[i]}return b};t.wl=[];t.wq=[];t.createAsynchronousCustomTagHandler=function(
o,f){var t=this,x,i;if(!f){f=o;o=0;x=t.w}else{if(!t.w[o])t.w[o]={};x=t.wl[o]=t.w[o]}if(typeof(f)!='object')f=[f];for(i=0;i<f.length;i++)if(!x[f[i]])x[f[i]]=new Function('var t=s_c_il['+t._in+
'];t.wq[t.wq.length]={'+(o?'o:''+o+'',':'')+'f:''+f[i]+'',a:t.aa(arguments)}')};t.as=function(x){var y=[],i;for(i=1;i<x.length;i++)y[y.length]=x[i];return y};t.s=0;t.contextData={}
t.retrieveLightData={};if(!w.s_giq)w.s_giq=[];t._gi=w.s_gi;w.s_gi=new Function('u','var t=s_c_il['+t._in+
'],w=t.w,l=t._il,i,j,x,s;u=u.toLowerCase();if(l)for(j=0;j<2;j++)for(i=0;i<l.length;i++){s=l[i];x=s._c;if((!x||x=='s_c'||(j>0&&x=='s_l'))&&s.oun&&(s.oun==u||(s.fs&&s.sa&&s.fs(s.oun,u)))){'+
'if(s.sa)s.sa(u);return s}}if(!t.oun){t.sa(u);return t}if(t._gi)return t._gi(u);s=new TagContainerLoader();s.tagContainerName='s_tca_'+w.s_giq.length;s.sa(u);w.s_giq[w.s_giq.length]=s;return s');t.sa=
function(u){var t=this;if(t.s)t.s.sa(u);t.un=u;if(!t.oun)t.oun=u;else if(!t.fs(t.oun,u))t.oun+=','+u};t.tq=[];t.track=t.t=function(vo){var t=this,m;if(t.s)return t.s.t(vo);if(!vo)vo={};for(m in t){if(
m!='un'||t.u!=t.un)vo[m]=t[m]}t.tq[t.tq.length]=vo;t.lnk=t.linkName=t.linkType='';return '';};t.trackLink=t.tl=function(o,u,n,vo){var t=this;if(t.s)return t.s.tl(o,u,v,vo);t.lnk=o;t.linkType=u
t.linkName=n;return t.t(vo)};t.trackLight=function(p,ss,i,vo){var t=this;if(t.s)return t.s.trackLight(p,ss,i,vo);t.lightProfileID=p;t.lightStoreForSeconds=ss;t.lightIncrementBy=i;return t.t(vo)}
t.lmq=[];t.loadModule=function(n,u,d){var t=this;if(t.s)return t.s.loadModule(n,u,d);t.lmq[t.lmq.length]={n:n,u:u,d:d};return 0};t.ml=[];t.mmq=[];t.mo=function(m,f){var t=this,i;t.ml[m]=t[m]={};if(f)
for(i=0;i<f.length;i++)t[m][f[i]]=new Function('var t=s_c_il['+t._in+'];t.mmq[t.mmq.length]={m:''+m+'',f:''+f[i]+'',a:t.aa(arguments)}')};t.mo('Media',['open','play','stop','close','track']);t.mo(
'Survey',['launch']);t.mci=[];t.mn=[];t.mc=function(n,m,p,k){var t=this,b,l=0;if(typeof(mboxFactoryDefault)=='undefined'||t.d.getElementById(m)==null)return;if(!mboxFactoryDefault.isEnabled()){
clearInterval(t.mci[k]);t.mt(true);return}if(typeof(mboxFactoryDefault.get(t.mn[0],0))!='undefined')l=mboxFactoryDefault.get(t.mn[0],0).isShown();if(k==0||l){clearInterval(t.mci[k]);b=
mboxFactoryDefault.create(n,p.split('&'));if(b)b.load()}};if(!w.mboxCreate&&!w.mboxDefine&&!w.mboxUpdate){w.mboxVersion='mini';if(!t.d.getElementById('mboxScriptContainer'))t.d.write(
'<div id='mboxScriptContainer' style='display:none;visibility:hidden;'></div><style>.mboxDefault{visibility:hidden;}</style>');t.mt=function(f){var t=this,i,j,d;if(typeof(mboxFactoryDefault)==
'undefined'||f){for(i in t.mci)clearInterval(t.mci[i]);d=(t.d.getElementsByClassName)?t.d.getElementsByClassName('mboxDefault'):t.d.getElementsByTagName('div');for(j in d)if(d[j].className==
'mboxDefault')d[j].style.visibility='visible'}};t.mpi={};t.mp=function(x,m){var t=this;t.mpi[x]=setInterval(function(){if(typeof(mboxFactoryDefault)==='undefined')return;m();clearInterval(t.mpi[x])},
13)};w.mboxCreate=function(n){var j=0,i,m,p,k;for(i in t.mn)if(t.mn[i]==n)j++;t.mn[t.mn.length]=n;m='mboxMarker-default-'+n+'-'+j;t.d.write('<div id=''+m+
'' style='visibility:hidden;display:none'>&nbsp;</div>');p=t.as(arguments).join('&');k=t.mci.length;t.mci[k]=setInterval(function(){t.mc(n,m,p,k);},5)};w.mboxDefine=function(d,n){var a=t.as(arguments)
t.mp('define_'+n,function(){mboxFactoryDefault.create(n,a,d);})};w.mboxUpdate=function(n){var a=t.as(arguments),x;x='update_'+n;t.mpi[x]=setInterval(function(){if(typeof(mboxFactoryDefault)===
'undefined'||typeof(mboxFactoryDefault.get(n))==='undefined')return;mboxFactoryDefault.update(n,a);clearInterval(t.mpi[x]);},13)};w.mboxLoadSCPlugin=function(s){(function(){if(typeof(
mboxFactoryDefault)==='undefined'||typeof(mboxExternalLoadSCPlugin)==='undefined'||(s._c=='s_l'&&!s.s)){setTimeout(arguments.callee,19);return}if(s._c=='s_l')s=s.s;mboxExternalLoadSCPlugin(s)})()};}}

<!-- /* Copyright 1997-2004 Omniture, Inc. */
s_analytics.pageName='nfl:fantasy football:research:research rankings'
s_analytics.channel='fantasy'
s_analytics.eVar14='nfl:fantasy football:research'
s_analytics.prop2='nfl:fantasy football:research'
s_analytics.prop3='nfl-managed'
s_analytics.hier1='nfl|fantasy football|research|research rankings'
s_analytics.eVar4='nfl|fantasy football|research|research rankings'
s_analytics.prop5='nfl|fantasy football|research|research rankings'
s_analytics.prop22='fantasy'
s_analytics.prop23='nfl:fantasy'
s_analytics.server='nfl.com'
/************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
var s_code= s_analytics.t();if(s_code)document.write(s_code)
//-->
</script>
        </div>
    </div>
    </div>
<script type='text/javascript'>
FF.constants.RENDER_END = new Date();
YEXT = null;
var SYSTEMENVIRONMENT = 'production';
var ADPATH = 'nfl.freefantasy';
var VIDEOPLAYERFILENAME = 'http://s.nflcdn.com/static/site/' + nfl.constants.ASSET_VERSION + '/flash/video/inline-video-player.swf';
var LEAGUEID = '0';
var TEAMID = '';
</script>
<script>
(function(){
    // allow groups in scripts to propagate
    var yConfigGroups = ( window.YUI_config ) ? window.YUI_config.groups : {};

    window.YUI_config = {
        comboBase : '/min/index1?a=230443d8-649d-11e6-8b77-86f30ca893d3&b=static/js/yui/3.15.0/build&f=',        combine : true,
        comboSep : ',',
        root : '',
        timeout: 10000,
                // filter: 'debug',
        // gallery: 'gallery-2012.08.01-13-16',
        modules:  {

            siteSpecific: {
               fullpath: '/static/js/804704bc17718c44c976113439fc2ea8.js',
               requires: ['plugin']
            }
    ,            pageSpecific: {
               fullpath: '/static/js/6ee32315a86f793ef8ccda15099c02d7.js',
               requires: ['plugin']
            }
,            teamManagerAssistCss : {
                fullpath:'/static/css/1414017725/dGVhbU1hbmFnZXJBc3Npc3QuY3Nz.css',
                type:'css'
            }
        }
    };
    window.YUI_config.groups = yConfigGroups;

if (window.nfl) {
    NFL_config = window.NFL_config || {},
    YUI_config = window.YUI_config || {};

    // YUI_config.comboBase = 'http://yui.yahooapis.com/combo?';
    YUI_config.comboBase = '/min/index1?a=230443d8-649d-11e6-8b77-86f30ca893d3&b=static/js/yui/3.15.0/build&f='
    YUI_config.combine = true;
    YUI_config.comboSep = ',';
    YUI_config.root = '';
    YUI_config.modules = YUI_config.modules || {};

    var Constants = nfl.constants;
    // console.log(Constants);
    YUI_config.groups.nfl = {
        base: Constants.SCRIPT_PATH + '/scripts/modules/',
        combine: true,
        comboBase: [
            Constants.NFL_COMBO_URL,
            '?',
            encodeURIComponent(Constants.ASSET_VERSION + Constants.ASSET_BUILD),
            '&b=',
            encodeURIComponent('yui3/static/' + Constants.ASSET_VERSION + '/scripts/modules'),
            '&ss=anyraw&f='
        ].join(''),
        comboSep: ',',
        root: '',
        filter: {
            searchExp: '([^\\/]+)\\/\\1-min\\.(js|css)',
            replaceStr: '$1.$2'
        },
        modules: {
            'nfl-carousel': { requires: ['plugin', 'base-build', 'nfl-lang', 'array-extras'], optional: 'anim' },
            'nfl-centerpiece': { requires: ['node', 'anim', 'widget', 'base-build', 'nfl-lang', 'nfl-carousel', 'nfl-subnav' ], optional: ['nfl-video'] },
            'nfl-lang': { requires: ['querystring'] },
            'nfl-pagination': { requires: ['plugin', 'base-build', 'nfl-lang'] },
            'nfl-subnav': { requires: [ 'node', 'plugin', 'base-build', 'classnamemanager', 'array-extras' ], optional: ['nfl-history-manager'] },
            'widget-node-builder': { requires: [ 'node-base' ] },
            'modal-mask': { requires: [ 'base-build', 'base', 'widget', 'widget-stack', 'node' ] },
            'modal-login': { requires: ['base-build', 'base', 'widget', 'widget-position', 'widget-position-align', 'widget-stack', 'modal-mask', 'widget-node-builder', 'event-touch', 'json-parse', 'transition' ], skinnable : true },
        }
    }
    console.log(YUI_config);
}
})();
YUI( YUI_config ).use('pageSpecific',
'siteSpecific',
'ads',
'anim',
'async-queue',
'autocomplete',
'base',
'cache',
'dataschema',
'datasource',
'dump',
'dynamic-modules',
'event',
'event-custom',
'event-valuechange',
'ff-feedback',
'ff-modal-login',
'ff-player-compare-modal',
'history',
'io',
'json-parse',
'loader',
'node',
'node-event-simulate',
'overlay',
'overlay-modal',
'page-tracking',
'player',
'playerCard',
'plugin',
'slynode',
'util',
'video',
'widget',
'widget-position',
'widget-position-align', function (Y) {
    FF.constants.YUI_START = new Date();
    Y.one('#researchRankingsPage').removeClass('noJs');

        (function () {
        try { Y.Util.init(document.body) }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());
    (function () {
        try { Y.PageTracking.init({'pageName':'nfl:fantasy football:research:research rankings','channel':'fantasy','eVar14':'nfl:fantasy football:research','prop2':'nfl:fantasy football:research','prop3':'nfl-managed','hier1':'nfl|fantasy football|research|research rankings','eVar4':'nfl|fantasy football|research|research rankings','prop5':'nfl|fantasy football|research|research rankings','prop22':'fantasy','prop23':'nfl:fantasy','server':'nfl.com'}) }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());
    (function () {
        try { new Y.FF.playerCompareModal({sourceNode: 'body'}).render(); }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());
    (function () {
        try { Y.Video.init(); }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());
    (function () {
        try { Y.Player.init(); }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());
    (function () {
        try { Y.FF.ModalLogin.init(); }
        catch (err) { Y.log('initErrorCatch:' + err.message); return false; }
    }());

    window.Y = Y;

    // debug info used in full.php
    FF.constants.YUI_END = new Date();
    Y.on('domready', function () {
        // console.log('YUI domready event fired');
        FF.constants.DOM_READY = new Date();
    });
    Y.on('contentready', function () { FF.constants.CONTENT_READY = new Date(); });
    Y.on('available', function () { FF.constants.AVAILABLE = new Date(); });

});
</script>

</body>
</html>
<!-- www101 -->
";

    }
}
