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
                    return FantasyNfl;
                case "http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300":
                    return Espn;
                case "http://www.fantasyfootballnerd.com/fantasy-football-draft-rankings":
                    return FantasyFootballNerd;
            }
            return string.Empty;
        }

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
        const string Espn = @" < !DOCTYPE html>
    <html class='no-icon-fonts'>
	<head>
		<meta http-equiv='content-type' content='text/html; charset=UTF-8' /><meta http-equiv='x-ua-compatible' content='IE=edge,chrome=1' /><meta name='viewport' content='initial-scale=1.0, maximum-scale=1.0, user-scalable=no'><link rel='canonical' href='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' />
<title>2016 Fantasy football rankings top 300</title>
<meta name='description' content='ESPN's fantasy staff reveals the top-300 rankings for the 2016 football season.' />
<meta name='news_keywords' content='Fantasy football, rankings, 2016, ESPN, NFL, ranks, top 300, quarterbacks, running backs, wide receivers, rookies, Fantasy, News - Fantasy Football, Fantasy NFL' />
<meta name='keywords' content='Fantasy football, rankings, 2016, ESPN, NFL, ranks, top 300, quarterbacks, running backs, wide receivers, rookies, Fantasy, News - Fantasy Football, Fantasy NFL' />
<meta name='DC.date.issued' content='2016-08-29T18:15:39Z'>
<meta property='fb:app_id' content='116656161708917' />
<meta property='og:site_name' content='ESPN.com' />
<meta property='og:url' content='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' />
<meta property='og:title' content='Fantasy football rankings: Top 300 for 2016'/>
<meta property='og:description' content='ESPN's fantasy staff reveals the top-300 rankings for the 2016 football season.' />
<meta property='og:image' content='http://a4.espncdn.com/combiner/i?img=%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16%2D9.jpg'/>
<meta property='og:type' content='article' />
<meta name='twitter:site' content='espn' />
<meta name='twitter:url' content='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' />
<meta name='twitter:title' content='Fantasy football rankings: Top 300 for 2016'/>
<meta name='twitter:description' content='ESPN's fantasy staff reveals the top-300 rankings for the 2016 football season.' />
<meta name='twitter:image' content='http://a4.espncdn.com/combiner/i?img=%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16%2D9.jpg'/>
<meta name='twitter:card' content='summary_large_image'>
<meta name='twitter:app:name:iphone' content='ESPN'/>
<meta name='twitter:app:id:iphone' content='317469184'/>
<meta name='twitter:app:url:iphone' content='sportscenter://x-callback-url/showStory?uid=16287927'/>
<meta name='twitter:app:name:googleplay' content='ESPN'/>
<meta name='twitter:app:id:googleplay' content='com.espn.score_center'/>
<meta name='twitter:app:url:googleplay' content='sportscenter://x-callback-url/showStory?uid=16287927'/>
<meta name='title' content='2016 Fantasy football rankings top 300'/>
<meta name='medium' content='article' />
<meta name='apple-itunes-app' content='app-id=317469184, app-argument=sportscenter://x-callback-url/showStory?uid=16287927'>
<!-- Indicate preferred brand name for Google to display -->
<script type='application/ld+json'>
	{
		'@context': 'http://schema.org',
		'@type':    'WebSite',
		'name':     'ESPN',
		'url':      'http://www.espn.com/'
	}
</script>
<!--
<PageMap>
	<DataObject type='document'>
		<Attribute name='title'>Fantasy football rankings: Top 300 for 2016</Attribute>
	</DataObject>
	<DataObject type='thumbnail'>
		<Attribute name='src' value='http://a4.espncdn.com/combiner/i?img=%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16%2D9.jpg' />
		<Attribute name='width' value='1296' />
		<Attribute name='height' value='729' />
	</DataObject>
</PageMap>
-->
<link rel='alternate' hreflang='en-us' href='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' />
<link rel='alternate' hreflang='en' href='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' /><script type='text/javascript'>
			// load new edition settings
			var espn = espn || {};
			espn.i18n = espn.i18n || {};
			espn.i18n.lang = 'en';
			espn.i18n.siteId = '1';
			espn.i18n.site = 'espn';
			espn.i18n.editionKey = 'espn-en';
			espn.i18n.personalization = true;
			espn.i18n.country = 'us';
			espn.i18n.domain = 'www.espn.com';
			espn.i18n.searchUrl = 'http://search.espn.com/';
			espn.i18n.hasSearch = true;
			espn.i18n.nowFeed = true;
			espn.i18n.temperature = {scale: 'fahrenheit', symbol: '&deg; F' };
			espn.i18n.facebook = {appId: '116656161708917', locale: 'en_US' };
			espn.i18n.outbrain = {'mobile':{'compliantId':'MB_4','nonCompliantId':'MB_5'},'desktop':{'compliantId':'AR_15','nonCompliantId':'AR_12'},'video':{'mobile':{'compliantId':'MB_6'},'desktop':{'compliantId':'AR_16'}},'recap':{'mobile':{'compliantId':'MB_9'},'desktop':{'compliantId':'AR_30'}}}
			espn.i18n.betting = {show: true, provider: ''};
			espn.i18n.ticketsEnabled = true;
			espn.i18n.translations = {};
			espn.i18n.environment = 'prod';
			espn.i18n.sportBranding = {'cricket':'logos/logo-uk-cricinfo.png','soccer':'logos/logo-uk-fc.png','rugby':'logos/logo-uk-scrum.png','ncaaw':'logos/ESPNcom-powerby-espnw.png','ncw':'logos/ESPNcom-powerby-espnw.png','wnba':'logos/ESPNcom-powerby-espnw.png','womenbb':'logos/ESPNcom-powerby-espnw.png'};
			espn.i18n.sportToUrl = {'cricket':'http://www.espncricinfo.com','soccer':'http://www.espnfc.us','ncaaw':'http://espnw.com','ncw':'http://espnw.com','wnba':'http://espnw.com','womenbb':'http://espnw.com'};
			espn.i18n.showWatch = true;
			
			espn.i18n.showFCContent = false;
			espn.i18n.showCricInfoContent = false;
			espn.i18n.showInsider = true;
			espn.i18n.indexAutoStart = false;
			espn.i18n.customPrimaryNav = false;
			espn.i18n.sportReplacements = {};

			espn.i18n.uriRewrites = {'paramKeys':{'toEdition':{},'toEnglish':{}},'pathSegments':{'toEdition':{},'toEnglish':{}},'urls':{'toEdition':{},'toEnglish':{}},'roots':{'toEdition':{'/womenbb/':'/womens-basketball/','/ncaa/':'/college-sports/','/ncb/':'/mens-college-basketball/','/ncf/':'/college-football/','/flb/':'/fantasy/baseball/','/fhl/':'/fantasy/hockey/','/horse/':'/horse-racing/','/nascar/':'/racing/nascar/','/fba/':'/fantasy/basketball/','/rpm/':'/racing/','/oly/':'/olympics/','/ffl/':'/fantasy/football/'},'toEnglish':{'/womens-basketball/':'/womenbb/','/newyork/':'/new-york/','/fantasy/basketball/':'/fba/','/college-football/':'/ncf/','/womens-college-basketball/':'/ncw/','/sports/horse/':'/horse/','/gymnastics/':'/oly/','/sports/endurance/':'/endurance/','/fantasy/football/':'/ffl/','/oly/summer/cycling/':'/oly/summer/cycling/','/olympics/':'/oly/','/mens-college-basketball/':'/ncb/','/sports/womenbb/':'/womenbb/','/fantasy/baseball/':'/flb/','/mens-college-basketball/rumors':'/mens-college-basketball/rumors','/oly/summer/gymnastics/':'/oly/summer/gymnastics/','/horse-racing/':'/horse/','/fantasy/hockey/':'/fhl/','/espn/onenacion/':'/onenacion/','/college-sports/':'/ncaa/','/losangeles/':'/los-angeles/','/skiing/':'/oly/','/cycling/':'/oly/','/racing/':'/rpm/','/racing/nascar/':'/nascar/','/college-football/rumors':'/college-football/rumors','/figure-skating/':'/oly/'}},'paramValues':{'toEdition':{},'toEnglish':{}}};

			try {
				//find way to double encode
				var translations = {'year.mobile.filters':'year','removedFromYourFavorites':'<p>You've removed<\/p><h1>${title}<\/h1>${subTitle}<p>as a suggested favorite<\/p>','preferences.sport_labels.700':'Barclays Premier League','heliumdown':'Login Temporarily Unavailable','newsletters':'Newsletters','preferences.sport_labels.850':'Tennis','no':'No','pageTitle.Scores_%{leagueOrSport}':'${leagueOrSport} Scores','score':'Score','preferences.sport_labels.46':'NBA','message.leaguemanager':'Message LM','favoritesmgmt.manualSortSelected':'You have chosen to manually order how your favorites will appear across ESPN products. At any time, you may return to having ESPN order your favorites by selecting the \'Auto\' option.','onefeed.suggested':'Suggested Favorites','favoritesmgmt.favoriteEntity':'${entity} - Favorite','preferences.sport_labels.41':'NCAAM','manageSettingInPersonalSettings':'You can manage this setting in the future under your <a href=\'#\'>Personal Settings<\/a>','hide':'Hide','search':'Search','preferences.sport_labels.1700':'Track and Field','welcomeToESPN':'Welcome to the new ESPN.com','tweet':'Tweet','to_be_determined.abbrev':'TBD','favoriteadded':'Favorite Added','over/under.abbrev':'O/U','preferences.sport_labels.8300':'College Sports','preferences.sport_labels.5501':'FIFA Club World Cup','move':'Move','preferences.sport_labels.3700':'Olympic Sports','preferences.sport_labels.8319':'Snooker','alert':'Alert','preferences.sport_labels.8318':'Darts','favoritesmgmt.confirmHideFavorite':'Hide this from my favorites?','preferences.sport_labels.59':'WNBA','season.mobile.filters':'season','reactivate':'Reactivate','position.abbrev':'POS','favoritesmgmt.alertType':'Alert Type','preferences.sport_labels.54':'NCAAW','createAccount':'Sign Up','viewall':'View All','favoritesmgmt.suggestedHeader':'Suggestions for your location','home':'Home','footerText':'ESPN Internet Ventures. <a href=\'http://disneytermsofuse.com/\' rel=\'nofollow\'>Terms of Use<\/a>, <a href=\'http://disneyprivacycenter.com/\' rel=\'nofollow\'>Privacy Policy<\/a>, <a href=\'https://disneyprivacycenter.com/notice-to-california-residents/\' rel=\'nofollow\'>Your California Privacy Rights<\/a>, <a href=\'https://disneyprivacycenter.com/kids-privacy-policy/english/\'>Children's Online Privacy Policy<\/a> and <a href=\'http://preferences-mgr.truste.com/?type=espn&affiliateId=148\'>Interest-Based Ads<\/a> are applicable to you. All rights reserved.<\/span><span class=\'link-text-short\'>Footer<\/span>','remove':'Remove','preferences.sport_labels.3918':'English FA Cup','preferences.sport_labels.28':'NFL','preferences.sport_labels.3301':'MMA','opponent.abbrev':'OPP','preferences.sport_labels.1650':'Wrestling','preferences.sport_labels.23':'NCAAF','subscribe':'Subscribe','preferences.sport_labels.1200':'Horse Racing','pop-out':'Pop-out','inprogress':'In Progress','connectedfacebook':'Connected to Facebook','manageMy':'Manage my','disableVideoDockingPermanently':'Disable video docking permanently','preferences.sport_labels.3520':'Poker','suggested':'Suggested','insider.pickcenter.login_message':'To get exclusive PickCenter analysis, you must be an ESPN Insider','preferences.sport_labels.3920':'English Capital One Cup','yes':'Yes','register':'Register','preferences.sport_labels.1000':'Boxing','preferences.sport_labels.33':'CFL','preferences.sport_labels.8098':'X Games','reset.mobile.filters':'reset','favorites.tooManyTeamsToAdd':'Maximum favorite teams limit reached. Please remove at least one team prior to adding additional teams.','Soccer Scores':'Football Scores','confirm':'Confirm','onefeed.scheduleDraft':'Schedule Draft','comments':'Comments','viewAllResultsBySearchTerm':'View all results for '${search_term}'','insiderSubscription':'Insider Subscription','favoritesmgmt.suggestedHeaderReset':'Suggestions','purse':'Purse','undo':'Undo','manageFavoritesSignIn':'To manage favorites please sign-in or create an ESPN account','sports':'Sports','show':'Show','cancel':'Cancel','accountInformation':'Account Information','preferences.sport_labels.2030':'Formula 1','resize':'Resize','nflBye':'Bye','close':'Close','redesignWelcomeText':'We've redesigned the site with some new and exciting features. You have been selected as part of a limited set of fans who get to experience our new site and give it feedback before it launches!','favoritesmgmt.reorderSports':'Reorder Sports','scores':'Scores','thingsHaveChanged':'As you may notice, things have definitely changed','favoritesmgmt.noFavorites':'You have not chosen any favorites yet','preferences.sport_labels.3170':'College Sports','thereAreNoEventsByDisplayNameByDate':'There are no ${displayName} events for ${readableDate}','preferences.sport_labels.800':'Field Hockey','signOut':'Log Out','onefeed.draft':'Draft','filter.mobile.filters':'filter','videoSettings':'Video Settings','favorites.draftingNow':'Drafting Now','noTeamsInFavorites':'No teams in your favorites yet','preferences.sport_labels.90':'NHL','enter':'Enter','preferences.sport_labels.2020':'NASCAR','favorites':'Favorites','onefeed.insider.manage':'Manage','welcometext':'Welcome','submit.mobile.filters':'submit','email':'Email','favorites.streakLabel':'Current Streak:','pts':'Pts','favoritesmgmt.sportTeam':'${sportLabel} Team','preferences.sport_labels.10':'MLB','onefeed.draftNow':'Draft Now','preferences.sport_labels.200':'Cricket','preferences.sport_labels.770':'MLS','preferences.sport_labels.1300':'Cycling','preferences.sport_labels.775':'UEFA Champions League','preferences.sport_labels.300':'Rugby','today':'Today','preferences.sport_labels.776':'UEFA Europa League','add':'Add','preferences.sport_labels.8367':'esports','videoDockingDisabled':'Video docking disabled','connectfacebook':'Connect with Facebook','facebook.conversation.account_policy':'Use a <a href=\'https://www.facebook.com/r.php\' rel=\'nofollow\'>Facebook account<\/a> to add a comment, subject to Facebook's <a href=\'https://www.facebook.com/policies/\' rel=\'nofollow\'>Terms of Service<\/a> and <a href=\'https://www.facebook.com/about/privacy/\' rel=\'nofollow\'>Privacy Policy<\/a>. Your Facebook name, photo & other personal information you make public on Facebook will appear with your comment, and may be used on ESPN's media platforms. <a href=\'http://espn.com/espn/story/_/id/8756098/espn-facebook-comments-faq\'>Learn more<\/a>.','earnings':'Earnings','preferences.sport_labels.781':'European Championship','addSomeForQuickAccess':'Add some for quick access','preferences.sport_labels.2000':'Racing','preferences.sport_labels.2040':'IndyCar','activateInsider':'Activate Insider','favoritesmgmt.noSuggestedFavorites':'Additional Suggested Favorites are not available at this time','favoritesmgmt.confirmRemoveFavorite':'Remove Favorite?','addfavorite':'Add Favorite','preferences.sport_labels.606':'Football','signIn':'Log In','preferences.sport_labels.8374':'Kabaddi','preferences.sport_labels.8373':'Badminton','addFavorites':'Add favorites','preferences.sport_labels.600':'Soccer','preferences.sport_labels.8372':'Chess','preferences.sport_labels.1106':'Golf'};
				if(Object.keys(translations).length > 0) {
					espn.i18n.translations = translations;
				}
			} catch (err) {
				window.console.log('Error in espn.i18n loading translations', err);
			}

			espn.i18n.dateTime = {
				dateFormats: {
					time1: 'h:mm A',
					date1: 'MMM D, YYYY',
					date2: 'M/D/YYYY',
					date3: 'MM/DD/YYYY',
					date4: 'MMDDYYYY',
					date5: 'MMMM Do YYYY',
					date6: 'dddd, MMMM Do YYYY',
					date7: 'ddd, MMM D YYYY',
					date8: 'M/D',
					date9: 'ddd',
					date10: 'dddd, MMMM Do',
					date11: 'ddd, MMMM D',
					date12: 'MMMM D, YYYY',
					date13: 'dddd, M/D',
					date14: 'MMM D',
					date15: 'ddd, M/D'

				},

				
				firstDayOfWeek: 'Sunday',
				timeZoneBucket: 'America/New_York',
				dayNamesShort: ['Su','Mo','Tu','We','Th','Fr','Sa'],dayNamesMedium: ['Sun','Mon','Tues','Wed','Thu','Fri','Sat'],

dayNamesLong: ['Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday'],

monthNamesShort: ['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sep','Oct','Nov','Dec'],

monthNamesLong: ['January','February','March','April','May','June','July','August','September','October','November','December']
			};

		</script>
<script>
!function(){function n(n,e,i){var t;if(i){var r=new Date;r.setTime(r.getTime()+24*i*60*60*1e3),t='; expires='+r.toGMTString()}else t='';document.cookie=n+'='+e+t+'; path=/'}function e(n){for(var e=n+'=',i=document.cookie.split(';'),t=0;t<i.length;t++){for(var r=i[t];' '===r.charAt(0);)r=r.substring(1,r.length);if(0===r.indexOf(e))return r.substring(e.length,r.length)}return null}function i(){var i=e('country');if('in'!=i&&window.location.href.match(/(\?|\&)(src|country-view)=/)){var t=e('country-view');null===t&&n('country-view',espn.i18n.country,30)}else if('en'===espn.i18n.lang){var t=e('country-view'),r=t||i,o='|'+r+'|';if('|bd|bt|in|mv|np|pk|af|lk|'.indexOf(o)>-1?r='in':'|as|au|ck|fj|pf|ki|mh|fm|nu|pw|pg|tk|to|tv|ws|'.indexOf(o)>-1?r='au':'|uk|gb|fk|gg|gi|gs|im|io|je|sh|'.indexOf(o)>-1&&(r='gb'),null!==r&&('au'==r||'gb'==r||'in'==r)&&espn.i18n.country!==r)for(var a=document.querySelectorAll('link[hreflang]'),f=0;f<a.length;f++){var u=a[f],c=u.getAttribute('hreflang'),l=new RegExp(espn.i18n.lang+'-'+r,'i');if(void 0!==c&&c.match(l)){var g=u.getAttribute('href');if(void 0!==g){var s=g;window.location.href=s}}}}}espn&&espn.i18n&&(window.location.href.match(/(https?:\/\/insider.|\/insider)/)||i())}();
</script>


<link href='http://a.espncdn.com' rel='preconnect' crossorigin>
<link href='http://a1.espncdn.com' rel='preconnect' crossorigin>
<link href='http://a2.espncdn.com' rel='preconnect' crossorigin>
<link href='http://a3.espncdn.com' rel='preconnect' crossorigin>
<link href='http://a4.espncdn.com' rel='preconnect' crossorigin>
<link href='http://tredir.go.com' rel='preconnect' crossorigin>
<link href='https://cdn.registerdisney.go.com' rel='preconnect' crossorigin>
<link href='http://fan.api.espn.com' rel='preconnect' crossorigin>
<link href='http://cdn.espn.com' rel='preconnect' crossorigin>

<link rel='mask-icon' sizes='any' href='http://a.espncdn.com/prod/assets/icons/E.svg' color='#990000'>
<link rel='shortcut icon' href='http://a.espncdn.com/favicon.ico' />
<link rel='apple-touch-icon' href='http://a.espncdn.com/wireless/mw5/r1/images/bookmark-icons/espn_icon-57x57.min.png' />
<link rel='apple-touch-icon-precomposed' href='http://a.espncdn.com/wireless/mw5/r1/images/bookmark-icons/espn_icon-57x57.min.png'>
<link rel='apple-touch-icon-precomposed' sizes='72x72' href='http://a.espncdn.com/wireless/mw5/r1/images/bookmark-icons/espn_icon-72x72.min.png'>
<link rel='apple-touch-icon-precomposed' sizes='114x114' href='http://a.espncdn.com/wireless/mw5/r1/images/bookmark-icons/espn_icon-114x114.min.png'>
<link rel='apple-touch-icon-precomposed' sizes='152x152' href='http://a.espncdn.com/wireless/mw5/r1/images/bookmark-icons/espn_icon-152x152.min.png'>
<link rel='alternate' href='android-app://com.espn.score_center/sportscenter/x-callback-url/showStory?uid=16287927' />
<link rel='alternate' href='ios-app://317469184/sportscenter/x-callback-url/showStory?uid=16287927' />
<link id='font-link' rel='stylesheet' href='http://a.espncdn.com/redesign/fonts/base64-benton-woff.css'><link rel='stylesheet' href='http://a.espncdn.com/redesign/0.315.13/css/shell-desktop.css' /><link rel='stylesheet' href='http://a.espncdn.com/redesign/0.315.13/css/page.css'><link class='page-type-include' rel='stylesheet' href='http://a.espncdn.com/redesign/0.315.13/css/story.css'>
        <script src='http://a.espncdn.com/redesign/0.315.13/js/espn-head.js'></script>
    
<script src='http://a.espncdn.com/redesign/0.315.13/node_modules/espn-lazysizes/lazysizes.js' async></script>

	<script type='text/javascript'>
		var googletag = googletag || {};
		googletag.cmd = googletag.cmd || [];
		(function() {
			var gads = document.createElement('script');
			gads.async = true;
			gads.type = 'text/javascript';
			var useSSL = 'https:' == document.location.protocol;
			gads.src = (useSSL ? 'https:' : 'http:') + '//www.googletagservices.com/tag/js/gpt.js';
			var node = document.getElementsByTagName('script')[0];
			node.parentNode.insertBefore(gads, node);
		})();
	</script>

	<script type='text/javascript'>
		var espn = espn || {};
		espn.ads = espn.ads || {};
		espn.ads.config = {'selector':'.ad-slot','sizes':{'native':{'defaultSize':[1,4],'mappings':[{'viewport':[0,0],'slot':[[1,4]]}]},'overlay':{'defaultSize':[0,0],'mappings':[{'viewport':[0,0],'slot':[[0,0]]}]},'incontent':{'defaultSize':[300,250],'mappings':[{'viewport':[1024,0],'slot':[[300,250],[300,600]]}]},'incontent2':{'defaultSize':[300,250],'mappings':[{'viewport':[0,0],'slot':[[300,250]]}]},'presby':{'defaultSize':[298,50],'mappings':[{'viewport':[0,0],'slot':[[298,50]]}]},'wallpaper':{'defaultSize':[1680,1050],'mappings':[{'viewport':[1280,0],'slot':[[1680,1050]]},{'viewport':[1024,0],'slot':[[1280,455]]},{'viewport':[0,0],'slot':[]}]},'presentedbylogo':{'defaultSize':[110,28],'mappings':[{'viewport':[1024,0],'slot':[[110,28]]},{'viewport':[0,0],'slot':[[90,20]]}]},'instream':{'defaultSize':[1,3],'mappings':[{'viewport':[0,0],'slot':[[1,3]]}]},'exclusions':{'defaultSize':[1,2],'mappings':[{'viewport':[0,0],'slot':[[1,2]]}]},'midpage':{'defaultSize':[320,250],'mappings':[{'viewport':[1280,0],'slot':[[700,400]]},{'viewport':[1024,0],'slot':[[440,330]]},{'viewport':[768,0],'slot':[[320,250]]},{'viewport':[0,0],'slot':[[320,250]]}]},'incontentstrip':{'defaultSize':[298,50],'mappings':[{'viewport':[1024,0],'slot':[298,50]},{'viewport':[0,0],'slot':[]}]},'banner':{'defaultSize':[970,66],'mappings':[{'viewport':[1280,0],'slot':[[1280,100]]},{'viewport':[1024,0],'slot':[[970,66],[970,250]]},{'viewport':[768,0],'slot':[[728,90]]},{'viewport':[0,0],'slot':[[320,50]]}]}},'delayInPageAdSlots':true,'refreshOnBreakpointChange':true,'kvps':[{'name':'ed','value':'us'},{'name':'sp','value':'ffl'},{'name':'league','value':'3080'},{'name':'objid','value':'16287927'},{'name':'col','value':['fantasy_staff','staff_fantasy']},{'name':'pgtyp','value':'story'}],'network':'6444','supportDynamicPageLoad':true,'id':12129264,'level':'espn.com/fantasy/football/story','incontentPositions':{'defaults':{'now':4,'news':4,'favorites':-1},'index':{'nfl':{},'top':{'favorites':-1}}},'base':'espn.com','dynamicKeyValues':{'profile':{'key':'prof'}},'load':{'frontpage':{'tablet':'init','desktop':'init','mobile':'window.load'},'story':{'tablet':'window.load','desktop':'window.load','mobile':'window.load'},'defaults':{'tablet':'init','desktop':'init','mobile':'window.load'},'index':{'tablet':'window.load','desktop':'window.load','mobile':'window.load'},'schedule':{'tablet':'window.load','desktop':'window.load','mobile':'window.load'},'standings':{'tablet':'window.load','desktop':'window.load','mobile':'window.load'},'scoreboard':{'tablet':'window.load','desktop':'window.load','mobile':'window.load'}},'disabled':'false','breakpoints':{'s':[0,767],'xl':[1280],'l':[1024,1279],'m':[768,1023]}};	
		espn.ads.configPre = JSON.parse(JSON.stringify(espn.ads.config))
	</script>



<script>
	// Picture element HTML shim|v it for old IE (pairs with Picturefill.js)
	document.createElement( 'picture' );
</script>

	</head>

	<body class='story desktop  prod ' data-pagetype='story' data-sport='ffl' data-customstylesheet='null'>
		<div class='ad-slot ad-slot-exclusions' data-slot-type='exclusions' data-slot-kvps='pos=exclusions' data-category-exclusion='true'></div><div class='ad-slot ad-slot-overlay' data-slot-type='overlay' data-slot-kvps='pos=outofpage' data-out-of-page='true'></div><div class='ad-slot ad-slot-wallpaper' data-slot-type='wallpaper' data-exclude-bp='s,m' data-slot-kvps='pos=wallpaper' data-collapse-before-load='true'></div>
	<!-- abtest data object global -->
	<script type='text/javascript'>
		var abtestData = {};
		
	</script>

	

		<div id='fb-root'></div>


        <div id='global-viewport' data-behavior='global_nav_condensed global_nav_full'  class =' interior secondary'>
            

<nav id='global-nav-mobile' data-loadtype='server'>
</nav>

            <div class='menu-overlay-primary'></div>

            <div id='header-wrapper' data-behavior='global_header' class='hidden-print'>
				

<section id='global-scoreboard' class='hide-fullbtn'>
    <div class='wrap'>
        <div class='scoreboard-content'>
            
            <div class='scoreboard-dropdown-wrapper scoreboard-menu'>
                <!-- mobile dropdown -->
                <div class='league-nav-wrapper league-nav-mobile mobile-dropdown'>
                    <span class='mobile-arrow'></span>
                    <select id='league-nav'></select>
                </div>

                <!-- desktop dropdown -->
                <div class='dropdown-wrapper league-nav-desktop desktop-dropdown' data-behavior='button_dropdown'>
                    <button type='button' class='button button-filter med dropdown-toggle current-league-name'></button>
                    <ul class='dropdown-menu league-nav med'></ul>
                </div>
            </div>

            <div class='scoreboard-dropdown-wrapper  conference-menu'>
                <!-- mobile dropdown -->
                <div class='conference-nav-wrapper mobile-dropdown'>
                    <span class='mobile-arrow'></span>
                    <select id='conference-nav'></select>
                </div>

                <!-- desktop dropdown -->
                <div class='dropdown-wrapper desktop-dropdown' data-behavior='button_dropdown'>
                    <button type='button' class='button button-filter med dropdown-toggle current-conference-name'></button>
                    <ul class='dropdown-menu conference-nav med'></ul>
                </div>
            </div>
            

            <div class='scoreboard-dropdown-wrapper scores-date-pick'>
                <div class='dropdown-wrapper' data-behavior='button_dropdown'>
                    <button type='button' class='button button-filter dropdown-toggle med selected-date'></button>
                    <ul class='dropdown-menu date-nav med'></ul>
                </div>
            </div>


            

            <div class='scoreboard-dropdown-wrapper secondary-nav-container hidden'></div>

            <div class='scores-prev controls inactive'>&lt;</div>
            <div id='fullbtn' class='view-full'></div>
            <div class='scores-next controls'>&gt;</div>
            <div class='scores-carousel'>
                <ul id='leagues'></ul>
            </div>
        </div>
    </div>
</section>
				
<header id='global-header' class='espn-en user-account-management has-search'>
    <div class='menu-overlay-secondary'></div>

	<div class='container'>
		<a id='global-nav-mobile-trigger' href='#' data-route='false'><span>Menu</span></a><h1><a href='/'  name='&lpos=sitenavdefault&lid=sitenav_main-logo'>ESPN</a></h1>
		<ul class='tools'>
			
			<li class='search'>
<a href='#' class='icon-font-after icon-search-solid-after' id='global-search-trigger'></a>
<div id='global-search' class='global-search'>
	<input type='text' class='search-box' placeholder='Search Sports, Teams or Players...'><input type='submit' class='btn-search'>
</div></li>
			
			
			<li class='user' data-behavior='favorites_mgmt'></li>
			
			<li><a href='#' id='global-scoreboard-trigger' data-route='false'>Scores</a></li>
		</ul>
		

	</div>

	
<nav id='global-nav' data-loadtype='server'>
<ul itemscope='' itemtype='http://www.schema.org/SiteNavigationElement'>
<li itemprop='name'><a itemprop='url' href='/nfl/'>NFL</a></li><li itemprop='name'><a itemprop='url' href='/nba/'>NBA</a></li><li itemprop='name'><a itemprop='url' href='/mlb/'>MLB</a></li><li itemprop='name'><a itemprop='url' href='/college-football/'>NCAAF</a></li><li itemprop='name'><a itemprop='url' href='http://espnfc.com/'>Soccer</a></li><li itemprop='name'><a itemprop='url' href='/tennis/'>Tennis</a></li><li itemprop='name'><a itemprop='url' href='#'>&hellip;</a><div><ul class='split'><li itemprop='name'><a itemprop='url' href='/nhl/'>NHL</a></li><li itemprop='name'><a itemprop='url' href='/golf/'>Golf</a></li><li itemprop='name'><a itemprop='url' href='/mma/'>MMA</a></li><li itemprop='name'><a itemprop='url' href='/wwe/'>WWE</a></li><li itemprop='name'><a itemprop='url' href='http://www.espn.com/moresports/story/_/page/LittleLeagueWorldSeries/little-league-world-series-espn'>LLWS</a></li><li itemprop='name'><a itemprop='url' href='/mens-college-basketball/'>NCAAM</a></li><li itemprop='name'><a itemprop='url' href='/esports/'>esports</a></li><li itemprop='name'><a itemprop='url' href='/chalk/'>Chalk</a></li><li itemprop='name'><a itemprop='url' href='/racing/nascar/'>NASCAR</a></li><li itemprop='name'><a itemprop='url' href='/olympics/'>Rio 2016</a></li><li itemprop='name'><a itemprop='url' href='/racing/'>Racing</a></li><li itemprop='name'><a itemprop='url' href='http://www.espn.com/extra/specialolympics/'>Special Olympics</a></li><li itemprop='name'><a itemprop='url' href='/college-sports/'>NCAA</a></li><li itemprop='name'><a itemprop='url' href='/womens-basketball/'>NCAAW</a></li><li itemprop='name'><a itemprop='url' href='/horse-racing/'>Horse</a></li><li itemprop='name'><a itemprop='url' href='/boxing/'>Boxing</a></li><li itemprop='name'><a itemprop='url' href='/womens-basketball/'>WNBA</a></li><li itemprop='name'><a itemprop='url' href='http://www.espn.com/college-sports/football/recruiting/'>RN FB</a></li><li itemprop='name'><a itemprop='url' href='http://www.espn.com/college-sports/basketball/recruiting/index'>RN BB</a></li><li itemprop='name'><a itemprop='url' href='http://espncricinfo.com/'>Cricket</a></li><li itemprop='name'><a itemprop='url' href='http://www.espnscrum.com/'>Rugby</a></li><li itemprop='name'><a itemprop='url' href='http://xgames.com/'>X Games</a></li><li itemprop='name'><a itemprop='url' href='/endurance/'>Endurance</a></li><li itemprop='name'><a itemprop='url' href='http://www.tsn.ca/cfl'>CFL</a></li></ul></div></li><li class='pillar more-espn'><a href='#'>More ESPN</a></li><li class='pillar fantasy'><a href='/fantasy/'>Fantasy</a></li><li class='pillar listen'><a href='http://www.espn.com/espnradio/index'>Listen</a></li><li class='pillar watch'><a href='http://www.espn.com/watchespn/index'>Watch</a></li></ul>

</nav>




<nav id='global-nav-secondary' data-loadtype='tier-2-server' >
<div class='global-nav-container'>
<ul class='first-group'><li class='sports' itemprop='name'><span class='positioning'><a href='http://www.espn.com/fantasy/football/'><span class='brand-logo icon-logo icon-font-before icon-fantasy-football-solid-before'><img src='http://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/default-team-logo-500.png&w=100&h=100'></span><span class='link-text'>Fantasy Football</span></a></span></li><li class='sub'><a href='http://www.espn.com/fantasy/football/'  data-mobile='false' ><span class='link-text'>Home</span><span class='link-text-short'>Home</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/livedraftlobby?ex_cid=FFL2016_FFLSubnav' ><span class='link-text'>Draft Now</span><span class='link-text-short'>Draft Now</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/welcome/createleague?ex_cid=FFL2016_FFLSubnav' ><span class='link-text'>Create a League</span><span class='link-text-short'>Create a League</span></a></li><li class='sub'><a href='http://www.espn.com/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more' ><span class='link-text'>Draft Kit</span><span class='link-text-short'>Draft Kit</span></a></li><li class='sub'><a href='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' ><span class='link-text'>Rankings</span><span class='link-text-short'>Rankings</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/livedraftresults' ><span class='link-text'>ADP</span><span class='link-text-short'>ADP</span></a></li><li class='sub'><a href='http://games.espn.com/nfl-pigskin-pickem/2016/en/' ><span class='link-text'>Pigskin Pick'em</span><span class='link-text-short'>Pigskin Pick'em</span></a></li><li class='sub has-sub sub-more-more'><a href='#'  data-placeholder='more'  data-breakpoints='tablet,desktop,desktop-lg' ><span class='link-text'>More</span><span class='link-text-short'>More</span></a><div><ul class='split'><li class='sub external'><a href='http://support.espn.com/en_US/Fantasy-Football' ><span class='link-text'>Help</span><span class='link-text-short'>Help</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/tools/projections?display=alt'  data-mobile='false' ><span class='link-text'>Projections</span><span class='link-text-short'>Projections</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/resources/playernews'  data-mobile='false' ><span class='link-text'>Player News</span><span class='link-text-short'>Player News</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/mockdraftlobby'  data-mobile='false' ><span class='link-text'>Mock Draft Lobby</span><span class='link-text-short'>Mock Draft Lobby</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/leaders?'  data-mobile='false' ><span class='link-text'>Scoring Leaders</span><span class='link-text-short'>Scoring Leaders</span></a></li><li class='sub'><a href='http://insider.espn.com/blog/fantasy-football' ><span class='link-text'>Daily Fantasy Strategy</span><span class='link-text-short'>Daily Fantasy Strategy</span></a></li><li class='sub'><a href='http://www.espn.com/fantasy/football/story/_/id/17173370/fantasy-football-rb-depth-chart-2016' ><span class='link-text'>RB Depth Chart</span><span class='link-text-short'>RB Depth Chart</span></a></li><li class='sub'><a href='http://www.espn.com/fantasy/football/story/_/page/consistency2015/final-2015-fantasy-football-consistency-ratings' ><span class='link-text'>Consistency Ratings</span><span class='link-text-short'>Consistency Ratings</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/pointsagainst?'  data-mobile='false' ><span class='link-text'>Points Against</span><span class='link-text-short'>Points Against</span></a></li><li class='sub'><a href='http://www.espn.com/mobile/products/products?id=8244799'  data-mobile='false' ><span class='link-text'>Apps</span><span class='link-text-short'>Apps</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/tools/undroppables' ><span class='link-text'>Undroppables</span><span class='link-text-short'>Undroppables</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/tools/statcorrections'  data-mobile='false' ><span class='link-text'>Stat Corrections</span><span class='link-text-short'>Stat Corrections</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/resources/leaderboard?'  data-mobile='false' ><span class='link-text'>Leaderboard</span><span class='link-text-short'>Leaderboard</span></a></li><li class='sub insider'><a href='http://insider.espn.com/insider/fantasy/football/valuecalculator'  data-mobile='false' ><span class='link-text'>Dollar Value Generator</span><span class='link-text-short'>Dollar Value Generator</span></a></li><li class='sub insider'><a href='http://insider.espn.com/insider/fantasy/football/draftengine'  data-mobile='false' ><span class='link-text'>Draft Engine</span><span class='link-text-short'>Draft Engine</span></a></li><li class='sub'><a href='http://games.espn.com/ffl/content?page=fflrulesindex2016'  data-mobile='false' ><span class='link-text'>Rules</span><span class='link-text-short'>Rules</span></a></li></ul></div></li></ul>
	<script type='text/javascript'>
		var espn = espn || {};
		espn.nav = espn.nav || {};
		espn.nav.navId = 11929946;
		espn.nav.isFallback = false;
		
			espn.nav.tier2 = {'subNavMenu':{'fallback':false,'navigation':{'title':'Fantasy Football Subnav','items':[{'title':'FFL Home','links':[{'text':'Home','isPremium':false,'shortText':'Home','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://www.espn.com/fantasy/football/','isExternal':false}],'$ref':'/v2/navigation/12455944'},{'title':'FFL Draft Now','links':[{'text':'Draft Now','isPremium':false,'shortText':'Draft Now','rel':['sub'],'href':'http://games.espn.com/ffl/livedraftlobby?ex_cid=FFL2016_FFLSubnav','isExternal':false}],'$ref':'/v2/navigation/17225824'},{'title':'Create a League','links':[{'text':'Create a League','isPremium':false,'shortText':'Create a League','rel':['sub'],'href':'http://games.espn.com/ffl/welcome/createleague?ex_cid=FFL2016_FFLSubnav','isExternal':false}],'$ref':'/v2/navigation/15414062'},{'title':'Fantasy Teams Nav | Mobile','links':[{'text':'My Teams','isPremium':false,'shortText':'My Teams','rel':['sub'],'attributes':{'pagetype':'index','tab':'1','breakpoints':'mobile'},'href':'/fantasy/?tab=1','isExternal':false}],'$ref':'/v2/navigation/13688986'},{'title':'FFL Draft Kit','links':[{'text':'Draft Kit','isPremium':false,'shortText':'Draft Kit','rel':['sub'],'href':'http://www.espn.com/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more','isExternal':false}],'$ref':'/v2/navigation/13148259'},{'title':'FFL Weekly Rankings','links':[{'text':'Rankings','isPremium':false,'shortText':'Rankings','rel':['sub'],'href':'http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300','isExternal':false}],'$ref':'/v2/navigation/13672140'},{'title':'FFL Average Draft Position','links':[{'text':'ADP','isPremium':false,'shortText':'ADP','rel':['sub'],'href':'http://games.espn.com/ffl/livedraftresults','isExternal':false}],'$ref':'/v2/navigation/12455875'},{'title':'Pigskin Pick'Em','links':[{'text':'Pigskin Pick'em','isPremium':false,'shortText':'Pigskin Pick'em','rel':['sub'],'href':'http://games.espn.com/nfl-pigskin-pickem/2016/en/','isExternal':false}],'$ref':'/v2/navigation/13388825'},{'title':'Subnav More (Tablet/Desktop/Desktop-lg) - DO NOT EDIT','links':[{'text':'More','isPremium':false,'shortText':'More','rel':['sub'],'attributes':{'placeholder':'more','breakpoints':'tablet,desktop,desktop-lg'},'href':'#','isExternal':false}],'$ref':'/v2/navigation/13148518'},{'title':'Subnav More - DO NOT EDIT','links':[{'text':'More','isPremium':false,'shortText':'More','rel':['sub'],'attributes':{'placeholder':'more','breakpoints':'mobile'},'href':'#','isExternal':false}],'$ref':'/v2/navigation/11494110'},{'title':'Fantasy Support Portal - Help','links':[{'text':'Help','isPremium':false,'shortText':'Help','rel':['sub'],'href':'http://support.espn.com/en_US/Fantasy-Football','isExternal':true}],'$ref':'/v2/navigation/17241092'},{'title':'FFL Projections','links':[{'text':'Projections','isPremium':false,'shortText':'Projections','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/tools/projections?display=alt','isExternal':false}],'$ref':'/v2/navigation/12921228'},{'title':'FFL Player News','links':[{'text':'Player News','isPremium':false,'shortText':'Player News','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/resources/playernews','isExternal':false}],'$ref':'/v2/navigation/12455894'},{'title':'FFL Mock Draft Lobby','links':[{'text':'Mock Draft Lobby','isPremium':false,'shortText':'Mock Draft Lobby','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/mockdraftlobby','isExternal':false}],'$ref':'/v2/navigation/12887018'},{'title':'FFL Scoring Leaders','links':[{'text':'Scoring Leaders','isPremium':false,'shortText':'Scoring Leaders','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/leaders?','isExternal':false}],'$ref':'/v2/navigation/12455915'},{'title':'FFL DFS Blog','links':[{'text':'Daily Fantasy Strategy','isPremium':false,'shortText':'Daily Fantasy Strategy','rel':['sub'],'href':'http://insider.espn.com/blog/fantasy-football','isExternal':false}],'$ref':'/v2/navigation/13674104'},{'title':'FFL Nav RB Chart','links':[{'text':'RB Depth Chart','isPremium':false,'shortText':'RB Depth Chart','rel':['sub'],'href':'http://www.espn.com/fantasy/football/story/_/id/17173370/fantasy-football-rb-depth-chart-2016','isExternal':false}],'$ref':'/v2/navigation/13370583'},{'title':'FFL Consistency Ratings','links':[{'text':'Consistency Ratings','isPremium':false,'shortText':'Consistency Ratings','rel':['sub'],'href':'http://www.espn.com/fantasy/football/story/_/page/consistency2015/final-2015-fantasy-football-consistency-ratings','isExternal':false}],'$ref':'/v2/navigation/13773565'},{'title':'FFL Points Against','links':[{'text':'Points Against','isPremium':false,'shortText':'Points Against','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/pointsagainst?','isExternal':false}],'$ref':'/v2/navigation/12455907'},{'title':'FFL Apps','links':[{'text':'Apps','isPremium':false,'shortText':'Apps','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://www.espn.com/mobile/products/products?id=8244799','isExternal':false}],'$ref':'/v2/navigation/12455912'},{'title':'FFL Undroppables','links':[{'text':'Undroppables','isPremium':false,'shortText':'Undroppables','rel':['sub'],'href':'http://games.espn.com/ffl/tools/undroppables','isExternal':false}],'$ref':'/v2/navigation/12455908'},{'title':'FFL Stat Corrections','links':[{'text':'Stat Corrections','isPremium':false,'shortText':'Stat Corrections','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/tools/statcorrections','isExternal':false}],'$ref':'/v2/navigation/12455880'},{'title':'FFL Leaderboard','links':[{'text':'Leaderboard','isPremium':false,'shortText':'Leaderboard','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/resources/leaderboard?','isExternal':false}],'$ref':'/v2/navigation/12455853'},{'title':'FFL Dollar Value Generator','links':[{'text':'Dollar Value Generator','isPremium':true,'shortText':'Dollar Value Generator','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://insider.espn.com/insider/fantasy/football/valuecalculator','isExternal':false}],'$ref':'/v2/navigation/12455852'},{'title':'FFL Draft Engine','links':[{'text':'Draft Engine','isPremium':true,'shortText':'Draft Engine','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://insider.espn.com/insider/fantasy/football/draftengine','isExternal':false}],'$ref':'/v2/navigation/13376929'},{'title':'FFL Rules','links':[{'text':'Rules','isPremium':false,'shortText':'Rules','rel':['sub'],'attributes':{'mobile':'false'},'href':'http://games.espn.com/ffl/content?page=fflrulesindex2016','isExternal':false}],'$ref':'/v2/navigation/12455847'}],'links':[{'text':'Fantasy Football','isPremium':false,'shortText':'Fantasy Football','rel':['sports'],'attributes':{'icon':'fantasy-football','abbrev':'ffl'},'href':'http://www.espn.com/fantasy/football/','isExternal':false}],'$ref':'/v2/navigation/12405632','attributes':{'root':'ffl'}},'navId':12405632}};
		
		

	</script>
</div>
</nav>

</header>
            </div>

            <section id='pane-main'>

            	<div id='custom-nav' data-id='story'></div>

            	<div class='ad-slot ad-slot-banner ad-wrapper' data-slot-type='banner' data-slot-kvps='pos=banner'></div>

                <section id='main-container'>
                    
                    <div class='main-content layout-cb'>
                        <section id='news-feed' class='col-c chk-height' data-behavior='desktop_story_news_feed' data-minifeed='region=us&headlinestack=true&pubkey=espn-en-ffl-index&lang=en'><div id='news-feed-content'  class='sidebar'><div class='container-wrapper'><div class='container'><!--get: espn-en_story_ffl_16287927_2016-08-29T18:15:39Z_false_true_desktop_11--><article data-id='16287927' class='news-feed-item top news-feed-story-package active has-related'><a name='&lpos=ffl:feed:xx:mem4:ts1' class='story-link'   data-sport='ffl' data-id='16287927' href='/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-fantasy-football-player-rankings-top-fantasy-football-players-fantasy-football-draft'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:mem4:ts1'  href='/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-fantasy-football-player-rankings-top-fantasy-football-players-fantasy-football-draft' class='realStory' data-sport='ffl'>Fantasy football rankings: Top 300 for 2016</a></h1><div class='news-feed_item-meta '><span class='timestamp'>5h</span><span class='author'>Fantasy staff</span></div><p class='related-indicator'>2 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='17292901' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/id/17292901/mike-clay-ultimate-draft-board-fantasy-football'><span class='icon-font-before icon-plus-solid-before'></span> Mike Clay's ultimate draft board</a></li><li><a name='&lpos=' data-id='17271578' data-sport='ffl' class='icon-font-before icon-brand-insider-solid-before realStory' href='/fantasy/football/insider/story/_/id/17271578/mike-clay-breaks-which-players-likely-outpace-their-td-total-2015-fantasy-football'>Why these players will score more TDs than last season</a></li></ul></div></div></article><article class='ad-298'><div class='ad-center'><div class='ad-slot ad-slot-incontent-strip ad-wrapper' data-slot-type='incontentstrip' data-exclude-bp='s,m' data-slot-kvps='pos=incontentstrip'></div></div></article><article class='ad-300'><div class='ad-center'><div class='ad-slot ad-slot-incontent ad-wrapper' data-slot-type='incontent' data-exclude-bp='s,m' data-slot-kvps='pos=incontent'></div></div></article><!--get: espn-en_story_ffl_17405433_2016-08-27T23:31:03Z_false_false_desktop_11--><article data-id='17405433' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='17405433' href='/fantasy/football/story/_/id/17405433/dez-bryant-takes-biggest-fantasy-hit-latest-tony-romo-injury-fantasy-football-2016'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/id/17405433/dez-bryant-takes-biggest-fantasy-hit-latest-tony-romo-injury-fantasy-football-2016' class='realStory' data-sport='ffl'>Bryant takes biggest fantasy hit with Romo injury</a></h1><div class='news-feed_item-meta '><span class='timestamp'>2d</span><span class='author'>Tristan H. Cockcroft</span></div></div></div></article><!--get: espn-en_story_ffl_draftkitindex_2016-08-28T19:44:33Z_false_true_desktop_11--><article data-id='draftkitindex' class='news-feed-item top news-feed-story-package has-related'><a name='&lpos=ffl:feed:xx:mem5:ts1' class='story-link'   data-sport='ffl' data-id='draftkitindex' href='/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:mem5:ts1'  href='/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more' class='realStory' data-sport='ffl'>2016 fantasy football draft kit</a></h1><div class='news-feed_item-meta '><span class='timestamp'>1d</span><span class='author'>Fantasy Staff</span></div><p class='related-indicator'>1 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='2016fbcheatsheetcentral' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/page/2016fbcheatsheetcentral/fantasy-football-cheat-sheets-2016-player-rankings-draft-board-standard-ppr'><span class='icon-font-before icon-plus-solid-before'></span> Fantasy football cheat sheet central</a></li></ul></div></div></article><!--get: espn-en_story_ffl_17369314_2016-08-24T19:04:41Z_false_false_desktop_11--><article data-id='17369314' class='news-feed-item '><a name='&lpos=' class='story-link'   data-sport='ffl' data-id='17369314' href='/fantasy/football/story/_/id/17369314/fantasy-football-handcuff-running-backs-value-nfl-2016'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos='  href='/fantasy/football/story/_/id/17369314/fantasy-football-handcuff-running-backs-value-nfl-2016' class='realStory' data-sport='ffl'>Drafting handcuff RBs is overrated</a></h1><div class='news-feed_item-meta '><span class='timestamp'>5d</span><span class='author'>Tristan H. Cockcroft</span></div></div></div></article><!--get: espn-en_story_ffl_mockdraft160822_2016-08-22T15:16:00Z_false_true_desktop_11--><article data-id='mockdraft160822' class='news-feed-item top news-feed-story-package active has-related'><a name='&lpos=ffl:feed:xx:mem6:ts1' class='story-link'   data-sport='ffl' data-id='mockdraft160822' href='/fantasy/football/story/_/page/mockdraft160822/fantasy-football-mock-draft-strategies-10-team-standard-leagues'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:mem6:ts1'  href='/fantasy/football/story/_/page/mockdraft160822/fantasy-football-mock-draft-strategies-10-team-standard-leagues' class='realStory' data-sport='ffl'>Fantasy football mock draft: Testing out strategies</a></h1><div class='news-feed_item-meta '><span class='timestamp'>7d</span><span class='author'>Tom Carpenter</span></div><p class='related-indicator'>1 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='14472239' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/id/14472239/mike-clay-2016-fantasy-football-rankings-nfl'><span class='icon-font-before icon-plus-solid-before'></span> Clay: 2016 fantasy football rankings</a></li></ul></div></div></article><!--get: espn-en_story_ffl_17365240_2016-08-22T19:25:50Z_false_false_desktop_11--><article data-id='17365240' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='17365240' href='/fantasy/football/story/_/id/17365240/with-dion-lewis-there-viable-fantasy-option-new-england-patriots-backfield-fantasy-football-2016'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/id/17365240/with-dion-lewis-there-viable-fantasy-option-new-england-patriots-backfield-fantasy-football-2016' class='realStory' data-sport='ffl'>With Lewis out, is there a Patriots RB you can trust?</a></h1><div class='news-feed_item-meta '><span class='timestamp'>7d</span><span class='author'>Tristan H. Cockcroft</span></div></div></div></article><!--get: espn-en_story_ffl_14765088_2016-07-26T18:26:49Z_false_false_desktop_11--><article data-id='14765088' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='14765088' href='/fantasy/football/story/_/id/14765088/matthew-berry-very-early-2016-fantasy-football-rankings-nfl'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/id/14765088/matthew-berry-very-early-2016-fantasy-football-rankings-nfl' class='realStory' data-sport='ffl'>Matthew Berry's fantasy football rankings</a></h1><div class='news-feed_item-meta '><span class='timestamp'>34d</span></div></div></div></article><!--get: espn-en_story_ffl_TMRLoveHate160811_2016-08-21T02:02:56Z_false_true_desktop_11--><article data-id='TMRLoveHate160811' class='news-feed-item top news-feed-story-package active has-related'><a name='&lpos=ffl:feed:xx:mem12:ts1' class='story-link'   data-sport='ffl' data-id='TMRLoveHate160811' href='/fantasy/football/story/_/page/TMRLoveHate160811/most-overvalued-undervalued-fantasy-football'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:mem12:ts1'  href='/fantasy/football/story/_/page/TMRLoveHate160811/most-overvalued-undervalued-fantasy-football' class='realStory' data-sport='ffl'>Berry: Love/Hate and the whole story</a></h1><div class='news-feed_item-meta '><span class='timestamp'>9d</span><span class='author'>Matthew Berry</span></div><p class='related-indicator'>2 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='14765088' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/id/14765088/matthew-berry-2016-fantasy-football-rankings-nfl'><span class='icon-font-before icon-plus-solid-before'></span> Berry: 2016 fantasy football rankings</a></li><li><a name='&lpos=' data-id='draftkitindex' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more'><span class='icon-font-before icon-plus-solid-before'></span> 2016 fantasy football draft kit</a></li></ul></div></div></article><!--get: espn-en_story_ffl_16287927_2016-08-17T20:13:28Z_false_false_desktop_11--><article data-id='16287927' class='news-feed-item '><a name='&lpos=' class='story-link'   data-sport='story' data-id='16287927' href='/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-fantasy-football-player-rankings-top-fantasy-football-players-fantasy-football-draft'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos='  href='/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-fantasy-football-player-rankings-top-fantasy-football-players-fantasy-football-draft' class='realStory' data-sport='story'>Fantasy football rankings: Top 300</a></h1><div class='news-feed_item-meta '><span class='timestamp'>12d</span></div></div></div></article><!--get: espn-en_story_ffl_17292901_2016-08-21T02:04:06Z_false_true_desktop_11--><article data-id='17292901' class='news-feed-item top news-feed-story-package has-related'><a name='&lpos=ffl:feed:xx:mem8:ts1' class='story-link'   data-sport='ffl' data-id='17292901' href='/fantasy/football/story/_/id/17292901/mike-clay-ultimate-draft-board-fantasy-football'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:mem8:ts1'  href='/fantasy/football/story/_/id/17292901/mike-clay-ultimate-draft-board-fantasy-football' class='realStory' data-sport='ffl'>Mike Clay's ultimate draft board</a></h1><div class='news-feed_item-meta '><span class='timestamp'>9d</span><span class='author'>Mike Clay</span></div><p class='related-indicator'>1 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='14472239' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/id/14472239/mike-clay-2016-fantasy-football-rankings-nfl'><span class='icon-font-before icon-plus-solid-before'></span> Clay: 2016 fantasy football rankings</a></li></ul></div></div></article><!--get: espn-en_story_ffl_17301852_2016-08-23T15:46:02Z_false_false_desktop_11--><article data-id='17301852' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='17301852' href='/fantasy/football/story/_/id/17301852/updated-sleepers-breakouts-busts-2016-season-nfl-fantasy-football'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/id/17301852/updated-sleepers-breakouts-busts-2016-season-nfl-fantasy-football' class='realStory' data-sport='ffl'>Updated sleepers, busts, breakouts for 2016</a></h1><div class='news-feed_item-meta '><span class='timestamp'>6d</span><span class='author'>ESPN Fantasy staff</span></div></div></div></article><!--get: espn-en_story_ffl_32for32xRBfantasy160816_2016-08-17T18:21:26Z_false_true_desktop_11--><article data-id='32for32xRBfantasy160816' class='news-feed-item top news-feed-story-package has-related'><a name='&lpos=' class='story-link'   data-sport='nfl' data-id='32for32xRBfantasy160816' href='/nfl/story/_/page/32for32xRBfantasy160816/2016-nfl-fantasy-football-quarterback-projections-all-32-teams-adrian-peterson-minnesota-vikings-todd-gurley-los-angeles-rams'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos='  href='/nfl/story/_/page/32for32xRBfantasy160816/2016-nfl-fantasy-football-quarterback-projections-all-32-teams-adrian-peterson-minnesota-vikings-todd-gurley-los-angeles-rams' class='realStory' data-sport='nfl'>Fantasy RB projections for all 32 NFL teams</a></h1><div class='news-feed_item-meta '><div class='category-link'><a href='/nfl/'>NFL</a></div><span class='timestamp'>12d</span><span class='author'>ESPN.com staff</span></div><p class='related-indicator'>1 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='32for32xQBfantasy160815' data-sport='nfl' class=' realStory' href='/nfl/story/_/page/32for32xQBfantasy160815/2016-nfl-fantasy-football-quarterback-previews-all-32-teams-ben-roethlisberger-pittsburgh-steelers-aaron-rodgers-green-bay-packers'><span class='icon-font-before icon-plus-solid-before'></span> Fantasy QB projections for all 32 NFL teams</a></li></ul></div></div></article><!--get: espn-en_story_ffl_17173370_2016-08-04T14:20:21Z_false_false_desktop_11--><article data-id='17173370' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='17173370' href='/fantasy/football/story/_/id/17173370/fantasy-football-rb-depth-chart-2016'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/id/17173370/fantasy-football-rb-depth-chart-2016' class='realStory' data-sport='ffl'>Running back depth chart</a></h1><div class='news-feed_item-meta '><span class='timestamp'>25d</span></div></div></div></article><!--get: espn-en_story_ffl_2016fbcheatsheetcentral_2016-08-05T15:34:33Z_false_false_desktop_11--><article data-id='2016fbcheatsheetcentral' class='news-feed-item '><a name='&lpos=ffl:feed:xx:news' class='story-link'   data-sport='ffl' data-id='2016fbcheatsheetcentral' href='/fantasy/football/story/_/page/2016fbcheatsheetcentral/fantasy-football-cheat-sheets-2016-player-rankings-draft-board-standard-ppr'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos=ffl:feed:xx:news'  href='/fantasy/football/story/_/page/2016fbcheatsheetcentral/fantasy-football-cheat-sheets-2016-player-rankings-draft-board-standard-ppr' class='realStory' data-sport='ffl'>Fantasy football cheat sheet central</a></h1><div class='news-feed_item-meta '><span class='timestamp'>24d</span></div></div></div></article><!--get: espn-en_story_ffl_17157660_2016-08-11T19:34:45Z_false_true_desktop_11--><article data-id='17157660' class='news-feed-item top news-feed-story-package has-related'><a name='&lpos=' class='story-link'   data-sport='ffl' data-id='17157660' href='/fantasy/football/story/_/id/17157660/strategy-secrets-tips-how-draft-fantasy-football'></a><div class='text-container'><div class='item-info-wrap'><h1><a name='&lpos='  href='/fantasy/football/story/_/id/17157660/strategy-secrets-tips-how-draft-fantasy-football' class='realStory' data-sport='ffl'>The Draft-Day Manifesto</a></h1><div class='news-feed_item-meta '><span class='timestamp'>18d</span><span class='author'>Matthew Berry</span></div><p class='related-indicator'>1 Related</p></div><div class='related-links' data-behavior='news_feed_item_related_links'><ul><li><a name='&lpos=' data-id='draftkitindex' data-sport='ffl' class=' realStory' href='/fantasy/football/story/_/page/draftkitindex/fantasy-football-draft-kit-espn-2016-rankings-mock-drafts-sleepers-more'><span class='icon-font-before icon-plus-solid-before'></span> 2016 fantasy football draft kit</a></li></ul></div></div></article></div></div></div></section><section id='article-feed' class='col-b' data-behavior='author_overlay article_header_news_feed_item_meta social_tools comment'><article class='article' data-id='16287927' data-behavior='story_scroll story_progress iframe' data-src='/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300'><div class='container'><div class='ad-slot ad-slot-instream ad-wrapper' data-slot-type='instream' data-slot-kvps='pos=instream'></div><!--<div class='presby'><img alt='Hot Read presented by Subway' class='portrait' src='http://a.espncdn.com/redesign/0.315.13/assets/img/temp/presby.jpg'></div>--><header class='article-header'><h1>2016 Fantasy football rankings: Top 300</h1></header><figure  data-video='native,640,360,17415669' class='iframe-video article-figure video ' data-source='espn'><div class='img-wrap'><picture ><source srcset='http://a.espncdn.com/combiner/i?img=%2Fmedia%2Fmotion%2F2016%2F0829%2Fdm_160829_Fantasy_Josh_Gordon%2Fdm_160829_Fantasy_Josh_Gordon.jpg&w=943&h=530&cquality=80' media='(min-width: 376px)'><source srcset='http://a.espncdn.com/combiner/i?img=%2Fmedia%2Fmotion%2F2016%2F0829%2Fdm_160829_Fantasy_Josh_Gordon%2Fdm_160829_Fantasy_Josh_Gordon.jpg&w=375&cquality=80, http://a.espncdn.com/combiner/i?img=%2Fmedia%2Fmotion%2F2016%2F0829%2Fdm_160829_Fantasy_Josh_Gordon%2Fdm_160829_Fantasy_Josh_Gordon.jpg&w=750&cquality=40 2x' media='(max-width: 375px)'><img  class='null lazyload' data-image-container='.article-figure'  /></picture><span class='video-play-button' data-id='17415669'>play</span></div><figcaption><div class='caption-wrapper'><div class='text-container'><span class='headline'>Why Josh Gordon is sliding in the rankings (1:16)</span><p>Josh Gordon's suspension isn't the only thing impacting where he's being drafted. Who's preseason performance is making Field Yates pay close attention to the Browns receivers? (1:16)</p></div></div></figcaption></figure><ul data-id='16287927' data-name='2016 Fantasy football rankings: Top 300' data-type='video' class='article-social horizontal' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300'><li><a href='https://www.facebook.com/dialog/share?href=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&app_id=116656161708917' class='btn-social icon-font-before icon-facebook-solid-before horizontal' target='new' data-social-type='horizontal' data-social-tool='facebook' data-short-text='Share' data-long-text='Share with Facebook'>Facebook</a></li><li><a href='http://twitter.com/intent/tweet?lang=en&url=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&text=Fantasy%20football%20rankings%3A%20Top%20300%20for%202016' class='btn-social icon-font-before icon-twitter-solid-before horizontal' target='new' data-social-type='horizontal' data-social-tool='twitter' data-short-text='Tweet' data-long-text='Share with Twitter'>Twitter</a></li><li><a href='whatsapp://send?text=2016%20Fantasy%20football%20rankings%3A%20Top%20300%20website%3A%20http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016-fantasy-football-rankings-top-300' class='btn-social icon-font-before icon-whatsapp-solid-before horizontal' data-social-type='horizontal' data-social-tool='whatsapp'></a></li><li><a href='https://pinterest.com/pin/create/button/?url=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300&description=2016+Fantasy+football+rankings%3A+Top+300&media=http%3A%2F%2Fa.espncdn.com%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16-9.jpg' class='btn-social icon-font-before icon-pinterest-solid-before horizontal' data-social-type='horizontal' data-social-tool='pinterest'>Pinterest</a></li><li class='internal send-email'><a href='mailto:?subject=2016 Fantasy football rankings: Top 300&body=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-route='false' class='btn-social icon-font-before icon-email-solid-before page-action email horizontal' data-social-type='horizontal' data-social-tool='email'>Email</a></li><li class='internal'><a href='#' class='btn-social page-action comment icon-font-before icon-comment-solid-before horizontal' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-social-type='horizontal' data-social-tool='comment'>comment</a></li></ul><div class='article-body'><div class='article-meta'><span class='timestamp' data-behavior='date_time' data-date='2016-08-28T02:31:00Z'><span data-dateFormat='date1'>Aug 27, 2016</span></span><ul class='authors'><li><div class='author'>Fantasy staff</div></li></ul></div><ul data-id='16287927' data-name='2016 Fantasy football rankings: Top 300' data-type='video' class='article-social vertical' data-behavior='sticky_social' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300'><li></li><li><a href='https://www.facebook.com/dialog/share?href=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&app_id=116656161708917' class='btn-social icon-font-before icon-facebook-solid-before vertical' target='new' data-social-type='vertical' data-social-tool='facebook' data-short-text='Share' data-long-text='Share with Facebook'>Facebook</a></li><li><a href='http://twitter.com/intent/tweet?lang=en&url=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&text=Fantasy%20football%20rankings%3A%20Top%20300%20for%202016' class='btn-social icon-font-before icon-twitter-solid-before vertical' target='new' data-social-type='vertical' data-social-tool='twitter' data-short-text='Tweet' data-long-text='Share with Twitter'>Twitter</a></li><li><a href='whatsapp://send?text=2016%20Fantasy%20football%20rankings%3A%20Top%20300%20website%3A%20http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016-fantasy-football-rankings-top-300' class='btn-social icon-font-before icon-whatsapp-solid-before vertical' data-social-type='vertical' data-social-tool='whatsapp'></a></li><li><a href='https://pinterest.com/pin/create/button/?url=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300&description=2016+Fantasy+football+rankings%3A+Top+300&media=http%3A%2F%2Fa.espncdn.com%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16-9.jpg' class='btn-social icon-font-before icon-pinterest-solid-before vertical' data-social-type='vertical' data-social-tool='pinterest'>Pinterest</a></li><li class='internal send-email'><a href='mailto:?subject=2016 Fantasy football rankings: Top 300&body=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' class='btn-social action email icon-font-before icon-email-solid-before vertical' data-route='false' class='page-action email' data-social-type='vertical' data-social-tool='email'>Email</a></li><li class='internal first'><a href='http://espn.go.com/espn/print?id=16287927' class='btn-social page-action print icon-font-before icon-print-solid-before vertical' data-social-type='vertical' data-social-tool='print'>print</a></li><li class='internal'><a href='#' class='btn-social page-action comment icon-font-before icon-comment-solid-before vertical' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-social-type='vertical' data-social-tool='comment'>comment</a></li></ul><video1></video1><p><i>NOTE: These rankings will be updated throughout the summer, so please check back often.</i></p><aside class='inline inline-table'><table cellspacing='0' cellpadding='0' data-text-contract='-' data-text-expand='+' data-fix-cols='0' data-behavior='responsive_table' class='inline-table'><caption>ESPN Fantasy rankings for 2016</caption><tbody><tr class='last'><td><a href='/fantasy/football/story/_/id/16287927/fantasy-football-rankings-2016-espn-nfl-rankings-top-300-overall'>Top 300</a> | <a href='/fantasy/football/story/_/id/17054264/fantasy-football-ppr-rankings-2016-espn-nfl-rankings-ppr-top-300-overall'>PPR top 300</a> | <a href='/fantasy/football/story/_/id/16288142/fantasy-football-rankings-2016-espn-nfl-ranks-quarterbacks'>QB</a> | <a href='/fantasy/football/story/_/id/16288373/fantasy-football-rankings-2016-espn-nfl-ranks-running-backs'>RB</a> | <a href='/fantasy/football/story/_/id/16288450/fantasy-football-rankings-2016-espn-nfl-ranks-wide-receivers'>WR</a> | <a href='/fantasy/football/story/_/id/16288526/fantasy-football-rankings-2016-espn-nfl-ranks-tight-ends'>TE</a> | <a href='/fantasy/football/story/_/id/16288583/fantasy-football-rankings-2016-espn-nfl-ranks-defense-special-teams-d-st'>DST</a> | <a href='/fantasy/football/story/_/id/16288579/fantasy-football-rankings-2016-espn-nfl-ranks-kickers'>K</a> | <a href='/fantasy/football/story/_/id/15499951/fantasy-football-idp-rankings-2016-espn-nfl-ranks-defensive-linemen-linebackers-defensive-backs-rookies'>IDP</a></td></tr><tr class='last'><td><b>Analysts:</b> <a href='/fantasy/football/story/_/id/14765088/matthew-berry-2016-fantasy-football-rankings-nfl'>Matthew Berry</a> | <a href='/fantasy/football/story/_/id/15592938/eric-karabell-top-100-rankings-2016-fantasy-football-nfl'>Eric Karabell</a> | <a href='/fantasy/football/story/_/id/15564986/tristan-h-cockcroft-2016-fantasy-football-rankings-nfl'>Tristan H. Cockcroft</a><br></td></tr><tr class='last'><td><a href='/fantasy/football/story/_/id/14472239/mike-clay-2016-fantasy-football-rankings-nfl'>Mike Clay</a> | <a href='/fantasy/football/story/_/id/17171463/field-yates-qb-rb-wr-te-d-st-kicker-rankings-2016-fantasy-football-nfl'>Field Yates</a> | <a href='/fantasy/football/story/_/id/16282802/mike-clay-2016-fantasy-football-ppr-rankings'>Clay (PPR)</a> | <a href='/fantasy/football/story/_/id/15698900/mike-clay-top-200-dynasty-fantasy-football-rankings-nfl'>Clay (Dynasty)</a></td></tr></tbody></table></aside><aside class='inline inline-table'><table cellspacing='0' cellpadding='0' data-text-contract='-' data-text-expand='+' data-fix-cols='0' data-behavior='responsive_table' class='inline-table'><caption>2016 rankings: Top 300 overall</caption><thead><tr><th>Rank, Player</th><th>Pos</th><th>Team</th><th>Bye</th><th>Pos Rk</th></tr></thead><tbody><tr class='last'><td>1. <a href='http://www.espn.com/nfl/player/_/id/13934/antonio-brown'>Antonio Brown</a></td><td>WR</td><td>PIT</td><td>8</td><td>WR1</td></tr><tr class='last'><td>2. <a href='http://www.espn.com/nfl/player/_/id/16733/odell-beckham-jr'>Odell Beckham Jr</a>.</td><td>WR</td><td>NYG</td><td>8</td><td>WR2</td></tr><tr class='last'><td>3. <a href='http://www.espn.com/nfl/player/_/id/10452/adrian-peterson'>Adrian Peterson</a></td><td>RB</td><td>MIN</td><td>6</td><td>RB1</td></tr><tr class='last'><td>4. <a href='http://www.espn.com/nfl/player/_/id/13982/julio-jones'>Julio Jones</a></td><td>WR</td><td>ATL</td><td>11</td><td>WR3</td></tr><tr class='last'><td>5. <a href='http://www.espn.com/nfl/player/_/id/2977644/todd-gurley'>Todd Gurley</a></td><td>RB</td><td>LA</td><td>8</td><td>RB2</td></tr><tr class='last'><td>6. <a href='http://www.espn.com/nfl/player/_/id/3051392/ezekiel-elliott'>Ezekiel Elliott</a></td><td>RB</td><td>DAL</td><td>7</td><td>RB3</td></tr><tr class='last'><td>7. <a href='http://www.espn.com/nfl/player/_/id/15795/deandre-hopkins'>DeAndre Hopkins</a></td><td>WR</td><td>HOU</td><td>9</td><td>WR4</td></tr><tr class='last'><td>8. <a href='http://www.espn.com/nfl/player/_/id/2508176/david-johnson'>David Johnson</a></td><td>RB</td><td>ARI</td><td>9</td><td>RB4</td></tr><tr class='last'><td>9. <a href='http://www.espn.com/nfl/player/_/id/16944/devonta-freeman'>Devonta Freeman</a></td><td>RB</td><td>ATL</td><td>11</td><td>RB5</td></tr><tr class='last'><td>10. <a href='http://www.espn.com/nfl/player/_/id/13983/aj-green'>A.J. Green</a></td><td>WR</td><td>CIN</td><td>9</td><td>WR5</td></tr><tr class='last'><td>11. <a href='http://www.espn.com/nfl/player/_/id/13229/rob-gronkowski'>Rob Gronkowski</a></td><td>TE</td><td>NE</td><td>9</td><td>TE1</td></tr><tr class='last'><td>12. <a href='http://www.espn.com/nfl/player/_/id/15825/le'veon-bell'>Le'Veon Bell</a></td><td>RB</td><td>PIT</td><td>8</td><td>RB6</td></tr><tr class='last'><td>13. <a href='http://www.espn.com/nfl/player/_/id/16799/allen-robinson'>Allen Robinson</a></td><td>WR</td><td>JAC</td><td>5</td><td>WR6</td></tr><tr class='last'><td>14. <a href='http://www.espn.com/nfl/player/_/id/14886/lamar-miller'>Lamar Miller</a></td><td>RB</td><td>HOU</td><td>9</td><td>RB7</td></tr><tr class='last'><td>15. <a href='http://www.espn.com/nfl/player/_/id/13215/dez-bryant'>Dez Bryant</a></td><td>WR</td><td>DAL</td><td>7</td><td>WR7</td></tr><tr class='last'><td>16. <a href='http://www.espn.com/nfl/player/_/id/14885/doug-martin'>Doug Martin</a></td><td>RB</td><td>TB</td><td>6</td><td>RB8</td></tr><tr class='last'><td>17. <a href='http://www.espn.com/nfl/player/_/id/11270/jordy-nelson'>Jordy Nelson</a></td><td>WR</td><td>GB</td><td>4</td><td>WR8</td></tr><tr class='last'><td>18. <a href='http://www.espn.com/nfl/player/_/id/13981/mark-ingram'>Mark Ingram</a></td><td>RB</td><td>NO</td><td>5</td><td>RB9</td></tr><tr class='last'><td>19. <a href='http://www.espn.com/nfl/player/_/id/9705/brandon-marshall'>Brandon Marshall</a></td><td>WR</td><td>NYJ</td><td>11</td><td>WR9</td></tr><tr class='last'><td>20. <a href='http://www.espn.com/nfl/player/_/id/15848/eddie-lacy'>Eddie Lacy</a></td><td>RB</td><td>GB</td><td>4</td><td>RB10</td></tr><tr class='last'><td>21. <a href='http://www.espn.com/nfl/player/_/id/14912/alshon-jeffery'>Alshon Jeffery</a></td><td>WR</td><td>CHI</td><td>9</td><td>WR10</td></tr><tr class='last'><td>22. <a href='http://www.espn.com/nfl/player/_/id/11307/jamaal-charles'>Jamaal Charles</a></td><td>RB</td><td>KC</td><td>5</td><td>RB11</td></tr><tr class='last'><td>23. <a href='http://www.espn.com/nfl/player/_/id/16737/mike-evans'>Mike Evans</a></td><td>WR</td><td>TB</td><td>6</td><td>WR11</td></tr><tr class='last'><td>24. <a href='http://www.espn.com/nfl/player/_/id/16725/sammy-watkins'>Sammy Watkins</a></td><td>WR</td><td>BUF</td><td>10</td><td>WR12</td></tr><tr class='last'><td>25. <a href='http://www.espn.com/nfl/player/_/id/12514/lesean-mccoy'>LeSean McCoy</a></td><td>RB</td><td>BUF</td><td>10</td><td>RB12</td></tr><tr class='last'><td>26. <a href='http://www.espn.com/nfl/player/_/id/16731/brandin-cooks'>Brandin Cooks</a></td><td>WR</td><td>NO</td><td>5</td><td>WR13</td></tr><tr class='last'><td>27. <a href='http://www.espn.com/nfl/player/_/id/11247/jonathan-stewart'>Jonathan Stewart</a></td><td>RB</td><td>CAR</td><td>7</td><td>RB13</td></tr><tr class='last'><td>28. <a href='http://www.espn.com/nfl/player/_/id/15860/jordan-reed'>Jordan Reed</a></td><td>TE</td><td>WAS</td><td>9</td><td>TE2</td></tr><tr class='last'><td>29. <a href='http://www.espn.com/nfl/player/_/id/2976499/amari-cooper'>Amari Cooper</a></td><td>WR</td><td>OAK</td><td>10</td><td>WR14</td></tr><tr class='last'><td>30. <a href='http://www.espn.com/nfl/player/_/id/13216/demaryius-thomas'>Demaryius Thomas</a></td><td>WR</td><td>DEN</td><td>11</td><td>WR15</td></tr><tr class='last'><td>31. <a href='http://www.espn.com/nfl/player/_/id/15818/keenan-allen'>Keenan Allen</a></td><td>WR</td><td>SD</td><td>11</td><td>WR16</td></tr><tr class='last'><td>32. <a href='http://www.espn.com/nfl/player/_/id/16777/carlos-hyde'>Carlos Hyde</a></td><td>RB</td><td>SF</td><td>8</td><td>RB14</td></tr><tr class='last'><td>33. <a href='http://www.espn.com/nfl/player/_/id/16040/cj-anderson'>C.J. Anderson</a></td><td>RB</td><td>DEN</td><td>11</td><td>RB15</td></tr><tr class='last'><td>34. <a href='http://www.espn.com/nfl/player/_/id/2576237/thomas-rawls'>Thomas Rawls</a></td><td>RB</td><td>SEA</td><td>5</td><td>RB16</td></tr><tr class='last'><td>35. <a href='http://www.espn.com/nfl/player/_/id/13994/cam-newton'>Cam Newton</a></td><td>QB</td><td>CAR</td><td>7</td><td>QB1</td></tr><tr class='last'><td>36. <a href='http://www.espn.com/nfl/player/_/id/14924/ty-hilton'>T.Y. Hilton</a></td><td>WR</td><td>IND</td><td>10</td><td>WR17</td></tr><tr class='last'><td>37. <a href='http://www.espn.com/nfl/player/_/id/12649/julian-edelman'>Julian Edelman</a></td><td>WR</td><td>NE</td><td>9</td><td>WR18</td></tr><tr class='last'><td>38. <a href='http://www.espn.com/nfl/player/_/id/14221/doug-baldwin'>Doug Baldwin</a></td><td>WR</td><td>SEA</td><td>5</td><td>WR19</td></tr><tr class='last'><td>39. <a href='http://www.espn.com/nfl/player/_/id/16790/jarvis-landry'>Jarvis Landry</a></td><td>WR</td><td>MIA</td><td>8</td><td>WR20</td></tr><tr class='last'><td>40. <a href='http://www.espn.com/nfl/player/_/id/11278/matt-forte'>Matt Forte</a></td><td>RB</td><td>NYJ</td><td>11</td><td>RB17</td></tr><tr class='last'><td>41. <a href='http://www.espn.com/nfl/player/_/id/16803/jeremy-hill'>Jeremy Hill</a></td><td>RB</td><td>CIN</td><td>9</td><td>RB18</td></tr><tr class='last'><td>42. <a href='http://www.espn.com/nfl/player/_/id/12579/jeremy-maclin'>Jeremy Maclin</a></td><td>WR</td><td>KC</td><td>5</td><td>WR21</td></tr><tr class='last'><td>43. <a href='http://www.espn.com/nfl/player/_/id/14053/randall-cobb'>Randall Cobb</a></td><td>WR</td><td>GB</td><td>4</td><td>WR22</td></tr><tr class='last'><td>44. <a href='http://www.espn.com/nfl/player/_/id/13271/eric-decker'>Eric Decker</a></td><td>WR</td><td>NYJ</td><td>11</td><td>WR23</td></tr><tr class='last'><td>45. <a href='http://www.espn.com/nfl/player/_/id/13217/golden-tate'>Golden Tate</a></td><td>WR</td><td>DET</td><td>10</td><td>WR24</td></tr><tr class='last'><td>46. <a href='http://www.espn.com/nfl/player/_/id/16791/donte-moncrief'>Donte Moncrief</a></td><td>WR</td><td>IND</td><td>10</td><td>WR25</td></tr><tr class='last'><td>47. <a href='http://www.espn.com/nfl/player/_/id/13295/emmanuel-sanders'>Emmanuel Sanders</a></td><td>WR</td><td>DEN</td><td>11</td><td>WR26</td></tr><tr class='last'><td>48. <a href='http://www.espn.com/nfl/player/_/id/10475/greg-olsen'>Greg Olsen</a></td><td>TE</td><td>CAR</td><td>7</td><td>TE3</td></tr><tr class='last'><td>49. <a href='http://www.espn.com/nfl/player/_/id/8439/aaron-rodgers'>Aaron Rodgers</a></td><td>QB</td><td>GB</td><td>4</td><td>QB2</td></tr><tr class='last'><td>50. <a href='http://www.espn.com/nfl/player/_/id/14881/russell-wilson'>Russell Wilson</a></td><td>QB</td><td>SEA</td><td>5</td><td>QB3</td></tr><tr class='last'><td>51. <a href='http://www.espn.com/nfl/player/_/id/16730/kelvin-benjamin'>Kelvin Benjamin</a></td><td>WR</td><td>CAR</td><td>7</td><td>WR27</td></tr><tr class='last'><td>52. <a href='http://www.espn.com/nfl/player/_/id/14908/michael-floyd'>Michael Floyd</a></td><td>WR</td><td>ARI</td><td>9</td><td>WR28</td></tr><tr class='last'><td>53. <a href='http://www.espn.com/nfl/player/_/id/5528/larry-fitzgerald'>Larry Fitzgerald</a></td><td>WR</td><td>ARI</td><td>9</td><td>WR29</td></tr><tr class='last'><td>54. <a href='http://www.espn.com/nfl/player/_/id/16804/john-brown'>John Brown</a></td><td>WR</td><td>ARI</td><td>9</td><td>WR30</td></tr><tr class='last'><td>55. <a href='http://www.espn.com/nfl/player/_/id/15920/latavius-murray'>Latavius Murray</a></td><td>RB</td><td>OAK</td><td>10</td><td>RB19</td></tr><tr class='last'><td>56. <a href='http://www.espn.com/nfl/player/_/id/13204/ryan-mathews'>Ryan Mathews</a></td><td>RB</td><td>PHI</td><td>4</td><td>RB20</td></tr><tr class='last'><td>57. <a href='http://www.espn.com/nfl/player/_/id/14005/demarco-murray'>DeMarco Murray</a></td><td>RB</td><td>TEN</td><td>13</td><td>RB21</td></tr><tr class='last'><td>58. <a href='http://www.espn.com/nfl/player/_/id/2515416/jeremy-langford'>Jeremy Langford</a></td><td>RB</td><td>CHI</td><td>9</td><td>RB22</td></tr><tr class='last'><td>59. <a href='http://www.espn.com/nfl/player/_/id/2980105/matt-jones'>Matt Jones</a></td><td>RB</td><td>WAS</td><td>9</td><td>RB23</td></tr><tr class='last'><td>60. <a href='http://www.espn.com/nfl/player/_/id/9761/delanie-walker'>Delanie Walker</a></td><td>TE</td><td>TEN</td><td>13</td><td>TE4</td></tr><tr class='last'><td>61. <a href='http://www.espn.com/nfl/player/_/id/14874/andrew-luck'>Andrew Luck</a></td><td>QB</td><td>IND</td><td>10</td><td>QB4</td></tr><tr class='last'><td>62. <a href='http://www.espn.com/nfl/player/_/id/12497/arian-foster'>Arian Foster</a></td><td>RB</td><td>MIA</td><td>8</td><td>RB24</td></tr><tr class='last'><td>63. <a href='http://www.espn.com/nfl/player/_/id/2576434/melvin-gordon'>Melvin Gordon</a></td><td>RB</td><td>SD</td><td>11</td><td>RB25</td></tr><tr class='last'><td>64. <a href='http://www.espn.com/nfl/player/_/id/2969962/duke-johnson-jr'>Duke Johnson Jr</a>.</td><td>RB</td><td>CLE</td><td>13</td><td>RB26</td></tr><tr class='last'><td>65. <a href='http://www.espn.com/nfl/player/_/id/11788/danny-woodhead'>Danny Woodhead</a></td><td>RB</td><td>SD</td><td>11</td><td>RB27</td></tr><tr class='last'><td>66. <a href='http://www.espn.com/nfl/player/_/id/8479/frank-gore'>Frank Gore</a></td><td>RB</td><td>IND</td><td>10</td><td>RB28</td></tr><tr class='last'><td>67. <a href='http://www.espn.com/nfl/player/_/id/12503/rashad-jennings'>Rashad Jennings</a></td><td>RB</td><td>NYG</td><td>8</td><td>RB29</td></tr><tr class='last'><td>68. <a href='http://www.espn.com/nfl/player/_/id/2580/drew-brees'>Drew Brees</a></td><td>QB</td><td>NO</td><td>5</td><td>QB5</td></tr><tr class='last'><td>69. <a href='http://www.espn.com/nfl/player/_/id/5536/ben-roethlisberger'>Ben Roethlisberger</a></td><td>QB</td><td>PIT</td><td>8</td><td>QB6</td></tr><tr class='last'><td>70. <a href='http://www.espn.com/nfl/player/_/id/16763/jordan-matthews'>Jordan Matthews</a></td><td>WR</td><td>PHI</td><td>4</td><td>WR31</td></tr><tr class='last'><td>71. <a href='http://www.espn.com/nfl/player/_/id/11283/desean-jackson'>DeSean Jackson</a></td><td>WR</td><td>WAS</td><td>9</td><td>WR32</td></tr><tr class='last'><td>72. <a href='http://www.espn.com/nfl/player/_/id/15072/marvin-jones'>Marvin Jones</a></td><td>WR</td><td>DET</td><td>10</td><td>WR33</td></tr><tr class='last'><td>73. <a href='http://www.espn.com/nfl/player/_/id/2976516/tj-yeldon'>T.J. Yeldon</a></td><td>RB</td><td>JAC</td><td>5</td><td>RB30</td></tr><tr class='last'><td>74. <a href='http://www.espn.com/nfl/player/_/id/15826/giovani-bernard'>Giovani Bernard</a></td><td>RB</td><td>CIN</td><td>9</td><td>RB31</td></tr><tr class='last'><td>75. <a href='http://www.espn.com/nfl/player/_/id/2576336/ameer-abdullah'>Ameer Abdullah</a></td><td>RB</td><td>DET</td><td>10</td><td>RB32</td></tr><tr class='last'><td>76. <a href='http://www.espn.com/nfl/player/_/id/13587/chris-ivory'>Chris Ivory</a></td><td>RB</td><td>JAC</td><td>5</td><td>RB33</td></tr><tr class='last'><td>77. <a href='http://www.espn.com/nfl/player/_/id/3043078/derrick-henry'>Derrick Henry</a></td><td>RB</td><td>TEN</td><td>13</td><td>RB34</td></tr><tr class='last'><td>78. <a href='http://www.espn.com/nfl/player/_/id/4459/carson-palmer'>Carson Palmer</a></td><td>QB</td><td>ARI</td><td>9</td><td>QB7</td></tr><tr class='last'><td>79. <a href='http://www.espn.com/nfl/player/_/id/2330/tom-brady'>Tom Brady</a></td><td>QB</td><td>NE</td><td>9</td><td>QB8</td></tr><tr class='last'><td>80. <a href='http://www.espn.com/nfl/player/_/id/17177/allen-hurns'>Allen Hurns</a></td><td>WR</td><td>JAC</td><td>5</td><td>WR34</td></tr><tr class='last'><td>81. <a href='http://www.espn.com/nfl/player/_/id/12563/michael-crabtree'>Michael Crabtree</a></td><td>WR</td><td>OAK</td><td>10</td><td>WR35</td></tr><tr class='last'><td>82. <a href='http://www.espn.com/nfl/player/_/id/2576623/devante-parker'>DeVante Parker</a></td><td>WR</td><td>MIA</td><td>8</td><td>WR36</td></tr><tr class='last'><td>83. <a href='http://www.espn.com/nfl/player/_/id/2577327/tyler-lockett'>Tyler Lockett</a></td><td>WR</td><td>SEA</td><td>5</td><td>WR37</td></tr><tr class='last'><td>84. <a href='http://www.espn.com/nfl/player/_/id/3042435/kevin-white'>Kevin White</a></td><td>WR</td><td>CHI</td><td>9</td><td>WR38</td></tr><tr class='last'><td>85. <a href='http://www.espn.com/nfl/player/_/id/2976592/sterling-shepard'>Sterling Shepard</a></td><td>WR</td><td>NYG</td><td>8</td><td>WR39</td></tr><tr class='last'><td>86. <a href='http://www.espn.com/nfl/player/_/id/14032/torrey-smith'>Torrey Smith</a></td><td>WR</td><td>SF</td><td>8</td><td>WR40</td></tr><tr class='last'><td>87. <a href='http://www.espn.com/nfl/player/_/id/2976212/stefon-diggs'>Stefon Diggs</a></td><td>WR</td><td>MIN</td><td>6</td><td>WR41</td></tr><tr class='last'><td>88. <a href='http://www.espn.com/nfl/player/_/id/5526/eli-manning'>Eli Manning</a></td><td>QB</td><td>NYG</td><td>8</td><td>QB9</td></tr><tr class='last'><td>89. <a href='http://www.espn.com/nfl/player/_/id/16724/blake-bortles'>Blake Bortles</a></td><td>QB</td><td>JAC</td><td>5</td><td>QB10</td></tr><tr class='last'><td>90. <a href='http://www.espn.com/nfl/player/_/id/5529/philip-rivers'>Philip Rivers</a></td><td>QB</td><td>SD</td><td>11</td><td>QB11</td></tr><tr class='last'><td>91. <a href='http://www.espn.com/nfl/player/_/id/15847/travis-kelce'>Travis Kelce</a></td><td>TE</td><td>KC</td><td>5</td><td>TE5</td></tr><tr class='last'><td>92. <a href='http://www.espn.com/nfl/player/_/id/14900/coby-fleener'>Coby Fleener</a></td><td>TE</td><td>NO</td><td>5</td><td>TE6</td></tr><tr class='last'><td>93. <a href='http://www.espn.com/nfl/player/_/id/15788/tyler-eifert'>Tyler Eifert</a></td><td>TE</td><td>CIN</td><td>9</td><td>TE7</td></tr><tr class='last'><td>94. <a href='http://www.espn.com/nfl/player/_/id/9613/deangelo-williams'>DeAngelo Williams</a></td><td>RB</td><td>PIT</td><td>8</td><td>RB35</td></tr><tr class='last'><td>95. <a href='http://www.espn.com/nfl/player/_/id/14129/bilal-powell'>Bilal Powell</a></td><td>RB</td><td>NYJ</td><td>11</td><td>RB36</td></tr><tr class='last'><td>96. <a href='http://www.espn.com/nfl/player/_/id/15705/josh-gordon'>Josh Gordon</a></td><td>WR</td><td>CLE</td><td>13</td><td>WR42</td></tr><tr class='last'><td>97. <a href='http://www.espn.com/nfl/player/_/id/17258/willie-snead'>Willie Snead</a></td><td>WR</td><td>NO</td><td>5</td><td>WR43</td></tr><tr class='last'><td>98. <a href='http://www.espn.com/nfl/player/_/id/8475/vincent-jackson'>Vincent Jackson</a></td><td>WR</td><td>TB</td><td>6</td><td>WR44</td></tr><tr class='last'><td>99. <a href='http://www.espn.com/nfl/player/_/id/15786/tavon-austin'>Tavon Austin</a></td><td>WR</td><td>LA</td><td>8</td><td>WR45</td></tr><tr class='last'><td>100. <a href='http://www.espn.com/nfl/player/_/id/2573300/jay-ajayi'>Jay Ajayi</a></td><td>RB</td><td>MIA</td><td>8</td><td>RB37</td></tr><tr class='last'><td>101. <a href='http://www.espn.com/nfl/player/_/id/2977609/devin-funchess'>Devin Funchess</a></td><td>WR</td><td>CAR</td><td>7</td><td>WR46</td></tr><tr class='last'><td>102. <a href='http://www.espn.com/nfl/player/_/id/15994/theo-riddick'>Theo Riddick</a></td><td>RB</td><td>DET</td><td>10</td><td>RB38</td></tr><tr class='last'><td>103. <a href='http://www.espn.com/nfl/player/_/id/11467/justin-forsett'>Justin Forsett</a></td><td>RB</td><td>BAL</td><td>8</td><td>RB39</td></tr><tr class='last'><td>104. <a href='http://www.espn.com/nfl/player/_/id/16749/charles-sims'>Charles Sims</a></td><td>RB</td><td>TB</td><td>6</td><td>RB40</td></tr><tr class='last'><td>105. <a href='http://www.espn.com/nfl/player/_/id/17133/isaiah-crowell'>Isaiah Crowell</a></td><td>RB</td><td>CLE</td><td>13</td><td>RB41</td></tr><tr class='last'><td>106. <a href='http://www.espn.com/nfl/player/_/id/13214/james-starks'>James Starks</a></td><td>RB</td><td>GB</td><td>4</td><td>RB42</td></tr><tr class='last'><td>107. <a href='http://www.espn.com/nfl/player/_/id/13213/legarrette-blount'>LeGarrette Blount</a></td><td>RB</td><td>NE</td><td>9</td><td>RB43</td></tr><tr class='last'><td>108. <a href='http://www.espn.com/nfl/player/_/id/2979477/tevin-coleman'>Tevin Coleman</a></td><td>RB</td><td>ATL</td><td>11</td><td>RB44</td></tr><tr class='last'><td>109. <a href='http://www.espn.com/nfl/player/_/id/11364/gary-barnidge'>Gary Barnidge</a></td><td>TE</td><td>CLE</td><td>13</td><td>TE8</td></tr><tr class='last'><td>110. <a href='http://www.espn.com/nfl/player/_/id/15835/zach-ertz'>Zach Ertz</a></td><td>TE</td><td>PHI</td><td>4</td><td>TE9</td></tr><tr class='last'><td>111. <a href='http://www.espn.com/nfl/player/_/id/5362/antonio-gates'>Antonio Gates</a></td><td>TE</td><td>SD</td><td>11</td><td>TE10</td></tr><tr class='last'><td>112. <a href='http://www.espn.com/nfl/player/_/id/2978929/corey-coleman'>Corey Coleman</a></td><td>WR</td><td>CLE</td><td>13</td><td>WR47</td></tr><tr class='last'><td>113. <a href='http://www.espn.com/nfl/player/_/id/15062/travis-benjamin'>Travis Benjamin</a></td><td>WR</td><td>SD</td><td>11</td><td>WR48</td></tr><tr class='last'><td>114. <a href='http://www.espn.com/nfl/player/_/id/2976316/michael-thomas'>Michael Thomas</a></td><td>WR</td><td>NO</td><td>5</td><td>WR49</td></tr><tr class='last'><td>115. <a href='http://www.espn.com/nfl/player/_/id/2622/steve-smith-sr'>Steve Smith Sr</a>.</td><td>WR</td><td>BAL</td><td>8</td><td>WR50</td></tr><tr class='last'><td>116. <a href='http://www.espn.com/nfl/player/_/id/15873/markus-wheaton'>Markus Wheaton</a></td><td>WR</td><td>PIT</td><td>8</td><td>WR51</td></tr><tr class='last'><td>117. <a href='http://www.espn.com/nfl/player/_/id/2579604/phillip-dorsett'>Phillip Dorsett</a></td><td>WR</td><td>IND</td><td>10</td><td>WR52</td></tr><tr class='last'><td>118. <a href='http://www.espn.com/nfl/player/_/id/14402/chris-hogan'>Chris Hogan</a></td><td>WR</td><td>NE</td><td>9</td><td>WR53</td></tr><tr class='last'><td>119. <a href='http://www.espn.com/nfl/player/_/id/14583/kamar-aiken'>Kamar Aiken</a></td><td>WR</td><td>BAL</td><td>8</td><td>WR54</td></tr><tr class='last'><td>120. <a href='http://www.espn.com/nfl/player/_/id/16946/bruce-ellington'>Bruce Ellington</a></td><td>WR</td><td>SF</td><td>8</td><td>WR55</td></tr><tr class='last'><td>121. <a href='http://www.espn.com/nfl/player/_/id/15102/rishard-matthews'>Rishard Matthews</a></td><td>WR</td><td>TEN</td><td>13</td><td>WR56</td></tr><tr class='last'><td>122. <a href='http://www.espn.com/nfl/player/_/id/14922/mohamed-sanu'>Mohamed Sanu</a></td><td>WR</td><td>ATL</td><td>11</td><td>WR57</td></tr><tr class='last'><td>123. <a href='http://www.espn.com/nfl/player/_/id/3122866/devontae-booker'>Devontae Booker</a></td><td>RB</td><td>DEN</td><td>11</td><td>RB45</td></tr><tr class='last'><td>124. <a href='http://www.espn.com/nfl/player/_/id/8544/darren-sproles'>Darren Sproles</a></td><td>RB</td><td>PHI</td><td>4</td><td>RB46</td></tr><tr class='last'><td>125. <a href='http://www.espn.com/nfl/player/_/id/16913/james-white'>James White</a></td><td>RB</td><td>NE</td><td>9</td><td>RB47</td></tr><tr class='last'><td>126. <a href='http://www.espn.com/nfl/player/_/id/16782/jerick-mckinnon'>Jerick McKinnon</a></td><td>RB</td><td>MIN</td><td>6</td><td>RB48</td></tr><tr class='last'><td>127. <a href='http://www.espn.com/nfl/player/_/id/3052876/will-fuller'>Will Fuller</a></td><td>WR</td><td>HOU</td><td>9</td><td>WR58</td></tr><tr class='last'><td>128. <a href='http://www.espn.com/nfl/player/_/id/3045144/tyler-boyd'>Tyler Boyd</a></td><td>WR</td><td>CIN</td><td>9</td><td>WR59</td></tr><tr class='last'><td>129. <a href='http://www.espn.com/nfl/player/_/id/15855/christine-michael'>Christine Michael</a></td><td>RB</td><td>SEA</td><td>5</td><td>RB49</td></tr><tr class='last'><td>130. <a href='http://www.espn.com/nfl/player/_/id/2577654/deandre-washington'>DeAndre Washington</a></td><td>RB</td><td>OAK</td><td>10</td><td>RB50</td></tr><tr class='last'><td>131. <a href='http://www.espn.com/nfl/player/_/id/14163/tyrod-taylor'>Tyrod Taylor</a></td><td>QB</td><td>BUF</td><td>10</td><td>QB12</td></tr><tr class='last'><td>132. <a href='http://www.espn.com/nfl/player/_/id/14880/kirk-cousins'>Kirk Cousins</a></td><td>QB</td><td>WAS</td><td>9</td><td>QB13</td></tr><tr class='last'><td>133. <a href='http://www.espn.com/nfl/player/_/id/16757/derek-carr'>Derek Carr</a></td><td>QB</td><td>OAK</td><td>10</td><td>QB14</td></tr><tr class='last'><td>134. <a href='http://www.espn.com/nfl/player/_/id/2576980/marcus-mariota'>Marcus Mariota</a></td><td>QB</td><td>TEN</td><td>13</td><td>QB15</td></tr><tr class='last'><td>135. <a href='http://www.espn.com/nfl/player/_/id/14017/shane-vereen'>Shane Vereen</a></td><td>RB</td><td>NYG</td><td>8</td><td>RB51</td></tr><tr class='last'><td>136. <a href='http://www.espn.com/nfl/player/_/id/14204/julius-thomas'>Julius Thomas</a></td><td>TE</td><td>JAC</td><td>5</td><td>TE11</td></tr><tr class='last'><td>137. <a href='http://www.espn.com/nfl/player/_/id/12699/zach-miller'>Zach Miller</a></td><td>TE</td><td>CHI</td><td>9</td><td>TE12</td></tr><tr class='last'><td>138. <a href='http://www.espn.com/nfl/player/_/id/11295/martellus-bennett'>Martellus Bennett</a></td><td>TE</td><td>NE</td><td>9</td><td>TE13</td></tr><tr class='last'><td>139. <a href='http://www.espn.com/nfl/player/_/id/13232/jimmy-graham'>Jimmy Graham</a></td><td>TE</td><td>SEA</td><td>5</td><td>TE14</td></tr><tr class='last'><td>140. <a href='http://www.espn.com/nfl/player/_/id/16732/eric-ebron'>Eric Ebron</a></td><td>TE</td><td>DET</td><td>10</td><td>TE15</td></tr><tr class='last'><td>141. <a href='/nfl/team/_/name/sea/seattle-seahawks'>Seattle Seahawks</a></td><td>DST</td><td>SEA</td><td>5</td><td>DST1</td></tr><tr class='last'><td>142. <a href='/nfl/team/_/name/den/denver-broncos'>Denver Broncos</a></td><td>DST</td><td>DEN</td><td>11</td><td>DST2</td></tr><tr class='last'><td>143. <a href='/nfl/team/_/name/car/carolina-panthers'>Carolina Panthers</a></td><td>DST</td><td>CAR</td><td>7</td><td>DST3</td></tr><tr class='last'><td>144. <a href='/nfl/team/_/name/cin/cincinnati-bengals'>Cincinnati Bengals</a></td><td>DST</td><td>CIN</td><td>9</td><td>DST4</td></tr><tr class='last'><td>145. <a href='/nfl/team/_/name/hou/houston-texans'>Houston Texans</a></td><td>DST</td><td>HOU</td><td>9</td><td>DST5</td></tr><tr class='last'><td>146. <a href='/nfl/team/_/name/kc/kansas-city-chiefs'>Kansas City Chiefs</a></td><td>DST</td><td>KC</td><td>5</td><td>DST6</td></tr><tr class='last'><td>147. <a href='/nfl/team/_/name/ari/arizona-cardinals'>Arizona Cardinals</a></td><td>DST</td><td>ARI</td><td>9</td><td>DST7</td></tr><tr class='last'><td>148. <a href='http://www.espn.com/nfl/player/_/id/9704/stephen-gostkowski'>Stephen Gostkowski</a></td><td>K</td><td>NE</td><td>9</td><td>K1</td></tr><tr class='last'><td>149. <a href='/nfl/team/_/name/gb/green-bay-packers'>Green Bay Packers</a></td><td>DST</td><td>GB</td><td>4</td><td>DST8</td></tr><tr class='last'><td>150. <a href='/nfl/team/_/name/oak/oakland-raiders'>Oakland Raiders</a></td><td>DST</td><td>OAK</td><td>10</td><td>DST9</td></tr><tr class='last'><td>151. <a href='/nfl/team/_/name/ne/new-england-patriots'>New England Patriots</a></td><td>DST</td><td>NE</td><td>9</td><td>DST10</td></tr><tr class='last'><td>152. <a href='http://www.espn.com/nfl/player/_/id/11923/steven-hauschka'>Steven Hauschka</a></td><td>K</td><td>SEA</td><td>5</td><td>K2</td></tr><tr class='last'><td>153. <a href='http://www.espn.com/nfl/player/_/id/14322/dan-bailey'>Dan Bailey</a></td><td>K</td><td>DAL</td><td>7</td><td>K3</td></tr><tr class='last'><td>154. <a href='http://www.espn.com/nfl/player/_/id/15683/justin-tucker'>Justin Tucker</a></td><td>K</td><td>BAL</td><td>8</td><td>K4</td></tr><tr class='last'><td>155. <a href='http://www.espn.com/nfl/player/_/id/1097/adam-vinatieri'>Adam Vinatieri</a></td><td>K</td><td>IND</td><td>10</td><td>K5</td></tr><tr class='last'><td>156. <a href='http://www.espn.com/nfl/player/_/id/10636/mason-crosby'>Mason Crosby</a></td><td>K</td><td>GB</td><td>4</td><td>K6</td></tr><tr class='last'><td>157. <a href='http://www.espn.com/nfl/player/_/id/12460/graham-gano'>Graham Gano</a></td><td>K</td><td>CAR</td><td>7</td><td>K7</td></tr><tr class='last'><td>158. <a href='http://www.espn.com/nfl/player/_/id/15058/blair-walsh'>Blair Walsh</a></td><td>K</td><td>MIN</td><td>6</td><td>K8</td></tr><tr class='last'><td>159. <a href='http://www.espn.com/nfl/player/_/id/16976/chandler-catanzaro'>Chandler Catanzaro</a></td><td>K</td><td>ARI</td><td>9</td><td>K9</td></tr><tr class='last'><td>160. <a href='http://www.espn.com/nfl/player/_/id/11122/matt-prater'>Matt Prater</a></td><td>K</td><td>DET</td><td>10</td><td>K10</td></tr><tr class='last'><td>161. <a href='http://www.espn.com/nfl/player/_/id/16020/spencer-ware'>Spencer Ware</a></td><td>RB</td><td>KC</td><td>5</td><td>RB52</td></tr><tr class='last'><td>162. <a href='http://www.espn.com/nfl/player/_/id/2577253/javorius-allen'>Javorius Allen</a></td><td>RB</td><td>BAL</td><td>8</td><td>RB53</td></tr><tr class='last'><td>163. <a href='http://www.espn.com/nfl/player/_/id/16783/terrance-west'>Terrance West</a></td><td>RB</td><td>BAL</td><td>8</td><td>RB54</td></tr><tr class='last'><td>164. <a href='http://www.espn.com/nfl/player/_/id/2980148/cj-prosise'>C.J. Prosise</a></td><td>RB</td><td>SEA</td><td>5</td><td>RB55</td></tr><tr class='last'><td>165. <a href='http://www.espn.com/nfl/player/_/id/16016/kenny-stills'>Kenny Stills</a></td><td>WR</td><td>MIA</td><td>8</td><td>WR60</td></tr><tr class='last'><td>166. <a href='http://www.espn.com/nfl/player/_/id/2574549/sammie-coates'>Sammie Coates</a></td><td>WR</td><td>PIT</td><td>8</td><td>WR61</td></tr><tr class='last'><td>167. <a href='http://www.espn.com/nfl/player/_/id/12601/mike-wallace'>Mike Wallace</a></td><td>WR</td><td>BAL</td><td>8</td><td>WR62</td></tr><tr class='last'><td>168. <a href='http://www.espn.com/nfl/player/_/id/2982828/tajae-sharpe'>Tajae Sharpe</a></td><td>WR</td><td>TEN</td><td>13</td><td>WR63</td></tr><tr class='last'><td>169. <a href='http://www.espn.com/nfl/player/_/id/12483/matthew-stafford'>Matthew Stafford</a></td><td>QB</td><td>DET</td><td>10</td><td>QB16</td></tr><tr class='last'><td>170. <a href='http://www.espn.com/nfl/player/_/id/14012/andy-dalton'>Andy Dalton</a></td><td>QB</td><td>CIN</td><td>9</td><td>QB17</td></tr><tr class='last'><td>171. <a href='http://www.espn.com/nfl/player/_/id/2969939/jameis-winston'>Jameis Winston</a></td><td>QB</td><td>TB</td><td>6</td><td>QB18</td></tr><tr class='last'><td>172. <a href='http://www.espn.com/nfl/player/_/id/11258/chris-johnson'>Chris Johnson</a></td><td>RB</td><td>ARI</td><td>9</td><td>RB56</td></tr><tr class='last'><td>173. <a href='http://www.espn.com/nfl/player/_/id/3060022/jordan-howard'>Jordan Howard</a></td><td>RB</td><td>CHI</td><td>9</td><td>RB57</td></tr><tr class='last'><td>174. <a href='http://www.espn.com/nfl/player/_/id/4527/jason-witten'>Jason Witten</a></td><td>TE</td><td>DAL</td><td>7</td><td>TE16</td></tr><tr class='last'><td>175. <a href='http://www.espn.com/nfl/player/_/id/14901/dwayne-allen'>Dwayne Allen</a></td><td>TE</td><td>IND</td><td>10</td><td>TE17</td></tr><tr class='last'><td>176. <a href='http://www.espn.com/nfl/player/_/id/15009/alfred-morris'>Alfred Morris</a></td><td>RB</td><td>DAL</td><td>7</td><td>RB58</td></tr><tr class='last'><td>177. <a href='http://www.espn.com/nfl/player/_/id/11383/tim-hightower'>Tim Hightower</a></td><td>RB</td><td>NO</td><td>5</td><td>RB59</td></tr><tr class='last'><td>178. <a href='http://www.espn.com/nfl/player/_/id/3042429/wendell-smallwood'>Wendell Smallwood</a></td><td>RB</td><td>PHI</td><td>4</td><td>RB60</td></tr><tr class='last'><td>179. <a href='http://www.espn.com/nfl/player/_/id/3051889/laquon-treadwell'>Laquon Treadwell</a></td><td>WR</td><td>MIN</td><td>6</td><td>WR64</td></tr><tr class='last'><td>180. <a href='http://www.espn.com/nfl/player/_/id/2576019/josh-doctson'>Josh Doctson</a></td><td>WR</td><td>WAS</td><td>9</td><td>WR65</td></tr><tr class='last'><td>181. <a href='http://www.espn.com/nfl/player/_/id/3043263/jaelen-strong'>Jaelen Strong</a></td><td>WR</td><td>HOU</td><td>9</td><td>WR66</td></tr><tr class='last'><td>182. <a href='http://www.espn.com/nfl/player/_/id/14851/terrelle-pryor'>Terrelle Pryor</a></td><td>WR</td><td>CLE</td><td>13</td><td>WR67</td></tr><tr class='last'><td>183. <a href='http://www.espn.com/nfl/player/_/id/15885/charles-johnson'>Charles Johnson</a></td><td>WR</td><td>MIN</td><td>6</td><td>WR68</td></tr><tr class='last'><td>184. <a href='http://www.espn.com/nfl/player/_/id/2971589/paul-perkins'>Paul Perkins</a></td><td>RB</td><td>NYG</td><td>8</td><td>RB61</td></tr><tr class='last'><td>185. <a href='http://www.espn.com/nfl/player/_/id/2971618/nelson-agholor'>Nelson Agholor</a></td><td>WR</td><td>PHI</td><td>4</td><td>WR69</td></tr><tr class='last'><td>186. <a href='http://www.espn.com/nfl/player/_/id/2971433/dorial-green-beckham'>Dorial Green-Beckham</a></td><td>WR</td><td>PHI</td><td>4</td><td>WR70</td></tr><tr class='last'><td>187. <a href='http://www.espn.com/nfl/player/_/id/2972460/breshad-perriman'>Breshad Perriman</a></td><td>WR</td><td>BAL</td><td>8</td><td>WR71</td></tr><tr class='last'><td>188. <a href='http://www.espn.com/nfl/player/_/id/14145/charles-clay'>Charles Clay</a></td><td>TE</td><td>BUF</td><td>10</td><td>TE18</td></tr><tr class='last'><td>189. <a href='/nfl/team/_/name/min/minnesota-vikings'>Minnesota Vikings</a></td><td>DST</td><td>MIN</td><td>6</td><td>DST11</td></tr><tr class='last'><td>190. <a href='/nfl/team/_/name/nyj/new-york-jets'>New York Jets</a></td><td>DST</td><td>NYJ</td><td>11</td><td>DST12</td></tr><tr class='last'><td>191. <a href='http://www.espn.com/nfl/player/_/id/2978887/roberto-aguayo'>Roberto Aguayo</a></td><td>K</td><td>TB</td><td>6</td><td>K11</td></tr><tr class='last'><td>192. <a href='http://www.espn.com/nfl/player/_/id/17372/chris-boswell'>Chris Boswell</a></td><td>K</td><td>PIT</td><td>8</td><td>K12</td></tr><tr class='last'><td>193. <a href='http://www.espn.com/nfl/player/_/id/8664/ryan-fitzpatrick'>Ryan Fitzpatrick</a></td><td>QB</td><td>NYJ</td><td>11</td><td>QB19</td></tr><tr class='last'><td>194. <a href='http://www.espn.com/nfl/player/_/id/14876/ryan-tannehill'>Ryan Tannehill</a></td><td>QB</td><td>MIA</td><td>8</td><td>QB20</td></tr><tr class='last'><td>195. <a href='http://www.espn.com/nfl/player/_/id/11237/matt-ryan'>Matt Ryan</a></td><td>QB</td><td>ATL</td><td>11</td><td>QB21</td></tr><tr class='last'><td>196. <a href='http://www.espn.com/nfl/player/_/id/11439/pierre-garcon'>Pierre Garcon</a></td><td>WR</td><td>WAS</td><td>9</td><td>WR72</td></tr><tr class='last'><td>197. <a href='http://www.espn.com/nfl/player/_/id/2512593/clive-walford'>Clive Walford</a></td><td>TE</td><td>OAK</td><td>10</td><td>TE19</td></tr><tr class='last'><td>198. <a href='http://www.espn.com/nfl/player/_/id/4512/anquan-boldin'>Anquan Boldin</a></td><td>WR</td><td>DET</td><td>10</td><td>WR73</td></tr><tr class='last'><td>199. <a href='http://www.espn.com/nfl/player/_/id/2971888/kenneth-dixon'>Kenneth Dixon</a></td><td>RB</td><td>BAL</td><td>8</td><td>RB62</td></tr><tr class='last'><td>200. <a href='http://www.espn.com/nfl/player/_/id/9588/reggie-bush'>Reggie Bush</a></td><td>RB</td><td>BUF</td><td>10</td><td>RB63</td></tr><tr class='last'><td>201. <a href='http://www.espn.com/nfl/player/_/id/14198/dion-lewis'>Dion Lewis</a></td><td>RB</td><td>NE</td><td>9</td><td>RB64</td></tr><tr class='last'><td>202. <a href='http://www.espn.com/nfl/player/_/id/17284/charcandrick-west'>Charcandrick West</a></td><td>RB</td><td>KC</td><td>5</td><td>RB65</td></tr><tr class='last'><td>203. <a href='http://www.espn.com/nfl/player/_/id/14518/shaun-draughn'>Shaun Draughn</a></td><td>RB</td><td>SF</td><td>8</td><td>RB66</td></tr><tr class='last'><td>204. <a href='http://www.espn.com/nfl/player/_/id/16942/ka'deem-carey'>Ka'Deem Carey</a></td><td>RB</td><td>CHI</td><td>9</td><td>RB67</td></tr><tr class='last'><td>205. <a href='http://www.espn.com/nfl/player/_/id/16055/benjamin-cunningham'>Benjamin Cunningham</a></td><td>RB</td><td>LA</td><td>8</td><td>RB68</td></tr><tr class='last'><td>206. <a href='http://www.espn.com/nfl/player/_/id/2979843/kenyan-drake'>Kenyan Drake</a></td><td>RB</td><td>MIA</td><td>8</td><td>RB69</td></tr><tr class='last'><td>207. <a href='http://www.espn.com/nfl/player/_/id/14894/robert-turbin'>Robert Turbin</a></td><td>RB</td><td>IND</td><td>10</td><td>RB70</td></tr><tr class='last'><td>208. <a href='http://www.espn.com/nfl/player/_/id/15966/chris-thompson'>Chris Thompson</a></td><td>RB</td><td>WAS</td><td>9</td><td>RB71</td></tr><tr class='last'><td>209. <a href='http://www.espn.com/nfl/player/_/id/14904/ladarius-green'>Ladarius Green</a></td><td>TE</td><td>PIT</td><td>8</td><td>TE20</td></tr><tr class='last'><td>210. <a href='http://www.espn.com/nfl/player/_/id/14189/jordan-cameron'>Jordan Cameron</a></td><td>TE</td><td>MIA</td><td>8</td><td>TE21</td></tr><tr class='last'><td>211. <a href='http://www.espn.com/nfl/player/_/id/15878/terrance-williams'>Terrance Williams</a></td><td>WR</td><td>DAL</td><td>7</td><td>WR74</td></tr><tr class='last'><td>212. <a href='http://www.espn.com/nfl/player/_/id/2576716/jamison-crowder'>Jamison Crowder</a></td><td>WR</td><td>WAS</td><td>9</td><td>WR75</td></tr><tr class='last'><td>213. <a href='http://www.espn.com/nfl/player/_/id/12556/kenny-britt'>Kenny Britt</a></td><td>WR</td><td>LA</td><td>8</td><td>WR76</td></tr><tr class='last'><td>214. <a href='http://www.espn.com/nfl/player/_/id/2578533/chris-conley'>Chris Conley</a></td><td>WR</td><td>KC</td><td>5</td><td>WR77</td></tr><tr class='last'><td>215. <a href='http://www.espn.com/nfl/player/_/id/16800/davante-adams'>Davante Adams</a></td><td>WR</td><td>GB</td><td>4</td><td>WR78</td></tr><tr class='last'><td>216. <a href='http://www.espn.com/nfl/player/_/id/2570987/braxton-miller'>Braxton Miller</a></td><td>WR</td><td>HOU</td><td>9</td><td>WR79</td></tr><tr class='last'><td>217. <a href='http://www.espn.com/nfl/player/_/id/10453/ted-ginn-jr'>Ted Ginn Jr</a>.</td><td>WR</td><td>CAR</td><td>7</td><td>WR80</td></tr><tr class='last'><td>218. <a href='http://www.espn.com/nfl/player/_/id/14909/kendall-wright'>Kendall Wright</a></td><td>WR</td><td>TEN</td><td>13</td><td>WR81</td></tr><tr class='last'><td>219. <a href='http://www.espn.com/nfl/player/_/id/15428/jermaine-kearse'>Jermaine Kearse</a></td><td>WR</td><td>SEA</td><td>5</td><td>WR82</td></tr><tr class='last'><td>220. <a href='http://www.espn.com/nfl/player/_/id/13553/victor-cruz'>Victor Cruz</a></td><td>WR</td><td>NYG</td><td>8</td><td>WR83</td></tr><tr class='last'><td>221. <a href='/nfl/team/_/name/buf/buffalo-bills'>Buffalo Bills</a></td><td>DST</td><td>BUF</td><td>10</td><td>DST13</td></tr><tr class='last'><td>222. <a href='/nfl/team/_/name/la/los-angeles-rams'>Los Angeles Rams</a></td><td>DST</td><td>LA</td><td>8</td><td>DST14</td></tr><tr class='last'><td>223. <a href='http://www.espn.com/nfl/player/_/id/17427/cairo-santos'>Cairo Santos</a></td><td>K</td><td>KC</td><td>5</td><td>K13</td></tr><tr class='last'><td>224. <a href='http://www.espn.com/nfl/player/_/id/9354/robbie-gould'>Robbie Gould</a></td><td>K</td><td>CHI</td><td>9</td><td>K14</td></tr><tr class='last'><td>225. <a href='http://www.espn.com/nfl/player/_/id/14879/brock-osweiler'>Brock Osweiler</a></td><td>QB</td><td>HOU</td><td>9</td><td>QB22</td></tr><tr class='last'><td>226. <a href='http://www.espn.com/nfl/player/_/id/11252/joe-flacco'>Joe Flacco</a></td><td>QB</td><td>BAL</td><td>8</td><td>QB23</td></tr><tr class='last'><td>227. <a href='http://www.espn.com/nfl/player/_/id/12537/jared-cook'>Jared Cook</a></td><td>TE</td><td>GB</td><td>4</td><td>TE22</td></tr><tr class='last'><td>228. <a href='http://www.espn.com/nfl/player/_/id/2578553/malcolm-mitchell'>Malcolm Mitchell</a></td><td>WR</td><td>NE</td><td>9</td><td>WR84</td></tr><tr class='last'><td>229. <a href='http://www.espn.com/nfl/player/_/id/16787/marqise-lee'>Marqise Lee</a></td><td>WR</td><td>JAC</td><td>5</td><td>WR85</td></tr><tr class='last'><td>230. <a href='http://www.espn.com/nfl/player/_/id/2587819/tyrell-williams'>Tyrell Williams</a></td><td>WR</td><td>SD</td><td>11</td><td>WR86</td></tr><tr class='last'><td>231. <a href='http://www.espn.com/nfl/player/_/id/17051/albert-wilson'>Albert Wilson</a></td><td>WR</td><td>KC</td><td>5</td><td>WR87</td></tr><tr class='last'><td>232. <a href='http://www.espn.com/nfl/player/_/id/2982804/leonte-carroo'>Leonte Carroo</a></td><td>WR</td><td>MIA</td><td>8</td><td>WR88</td></tr><tr class='last'><td>233. <a href='http://www.espn.com/nfl/player/_/id/2518678/justin-hardy'>Justin Hardy</a></td><td>WR</td><td>ATL</td><td>11</td><td>WR89</td></tr><tr class='last'><td>234. <a href='http://www.espn.com/nfl/player/_/id/15880/robert-woods'>Robert Woods</a></td><td>WR</td><td>BUF</td><td>10</td><td>WR90</td></tr><tr class='last'><td>235. <a href='http://www.espn.com/nfl/player/_/id/13203/cj-spiller'>C.J. Spiller</a></td><td>RB</td><td>NO</td><td>5</td><td>RB72</td></tr><tr class='last'><td>236. <a href='http://www.espn.com/nfl/player/_/id/3043097/cameron-artis-payne'>Cameron Artis-Payne</a></td><td>RB</td><td>CAR</td><td>7</td><td>RB73</td></tr><tr class='last'><td>237. <a href='http://www.espn.com/nfl/player/_/id/2971062/keith-marshall'>Keith Marshall</a></td><td>RB</td><td>WAS</td><td>9</td><td>RB74</td></tr><tr class='last'><td>238. <a href='http://www.espn.com/nfl/player/_/id/15952/mike-gillislee'>Mike Gillislee</a></td><td>RB</td><td>BUF</td><td>10</td><td>RB75</td></tr><tr class='last'><td>239. <a href='http://www.espn.com/nfl/player/_/id/15893/andre-ellington'>Andre Ellington</a></td><td>RB</td><td>ARI</td><td>9</td><td>RB76</td></tr><tr class='last'><td>240. <a href='http://www.espn.com/nfl/player/_/id/2573974/tyler-ervin'>Tyler Ervin</a></td><td>RB</td><td>HOU</td><td>9</td><td>RB77</td></tr><tr class='last'><td>241. <a href='http://www.espn.com/nfl/player/_/id/17452/branden-oliver'>Branden Oliver</a></td><td>RB</td><td>SD</td><td>11</td><td>RB78</td></tr><tr class='last'><td>242. <a href='http://www.espn.com/nfl/player/_/id/16530/khiry-robinson'>Khiry Robinson</a></td><td>RB</td><td>NYJ</td><td>11</td><td>RB79</td></tr><tr class='last'><td>243. <a href='http://www.espn.com/nfl/player/_/id/9597/jay-cutler'>Jay Cutler</a></td><td>QB</td><td>CHI</td><td>9</td><td>QB24</td></tr><tr class='last'><td>244. <a href='http://www.espn.com/nfl/player/_/id/16795/austin-seferian-jenkins'>Austin Seferian-Jenkins</a></td><td>TE</td><td>TB</td><td>6</td><td>TE23</td></tr><tr class='last'><td>245. <a href='http://www.espn.com/nfl/player/_/id/14054/kyle-rudolph'>Kyle Rudolph</a></td><td>TE</td><td>MIN</td><td>6</td><td>TE24</td></tr><tr class='last'><td>246. <a href='http://www.espn.com/nfl/player/_/id/14895/ronnie-hillman'>Ronnie Hillman</a></td><td>RB</td><td>DEN</td><td>11</td><td>RB80</td></tr><tr class='last'><td>247. <a href='http://www.espn.com/nfl/player/_/id/11238/darren-mcfadden'>Darren McFadden</a></td><td>RB</td><td>DAL</td><td>7</td><td>RB81</td></tr><tr class='last'><td>248. <a href='http://www.espn.com/nfl/player/_/id/15369/lance-dunbar'>Lance Dunbar</a></td><td>RB</td><td>DAL</td><td>7</td><td>RB82</td></tr><tr class='last'><td>249. <a href='http://www.espn.com/nfl/player/_/id/2515759/jj-nelson'>J.J. Nelson</a></td><td>WR</td><td>ARI</td><td>9</td><td>WR91</td></tr><tr class='last'><td>250. <a href='http://www.espn.com/nfl/player/_/id/12576/brandon-lafell'>Brandon LaFell</a></td><td>WR</td><td>CIN</td><td>9</td><td>WR92</td></tr><tr class='last'><td>251. <a href='http://www.espn.com/nfl/player/_/id/3042910/rashard-higgins'>Rashard Higgins</a></td><td>WR</td><td>CLE</td><td>13</td><td>WR93</td></tr><tr class='last'><td>252. <a href='http://www.espn.com/nfl/player/_/id/16026/quinton-patton'>Quinton Patton</a></td><td>WR</td><td>SF</td><td>8</td><td>WR94</td></tr><tr class='last'><td>253. <a href='/nfl/team/_/name/ind/indianapolis-colts'>Indianapolis Colts</a></td><td>DST</td><td>IND</td><td>10</td><td>DST15</td></tr><tr class='last'><td>254. <a href='/nfl/team/_/name/jax/jacksonville-jaguars'>Jacksonville Jaguars</a></td><td>DST</td><td>JAC</td><td>5</td><td>DST16</td></tr><tr class='last'><td>255. <a href='http://www.espn.com/nfl/player/_/id/4680/josh-brown'>Josh Brown</a></td><td>K</td><td>NYG</td><td>8</td><td>K15</td></tr><tr class='last'><td>256. <a href='http://www.espn.com/nfl/player/_/id/16339/brandon-mcmanus'>Brandon McManus</a></td><td>K</td><td>DEN</td><td>11</td><td>K16</td></tr><tr class='last'><td>257. <a href='http://www.espn.com/nfl/player/_/id/2512523/will-tye'>Will Tye</a></td><td>TE</td><td>NYG</td><td>8</td><td>TE25</td></tr><tr class='last'><td>258. <a href='http://www.espn.com/nfl/player/_/id/14085/virgil-green'>Virgil Green</a></td><td>TE</td><td>DEN</td><td>11</td><td>TE26</td></tr><tr class='last'><td>259. <a href='http://www.espn.com/nfl/player/_/id/15853/vance-mcdonald'>Vance McDonald</a></td><td>TE</td><td>SF</td><td>8</td><td>TE27</td></tr><tr class='last'><td>260. <a href='http://www.espn.com/nfl/player/_/id/14875/robert-griffin'>Robert Griffin</a></td><td>QB</td><td>CLE</td><td>13</td><td>QB25</td></tr><tr class='last'><td>261. <a href='http://www.espn.com/nfl/player/_/id/16728/teddy-bridgewater'>Teddy Bridgewater</a></td><td>QB</td><td>MIN</td><td>6</td><td>QB26</td></tr><tr class='last'><td>262. <a href='http://www.espn.com/nfl/player/_/id/15349/cole-beasley'>Cole Beasley</a></td><td>WR</td><td>DAL</td><td>7</td><td>WR95</td></tr><tr class='last'><td>263. <a href='http://www.espn.com/nfl/player/_/id/17402/seth-roberts'>Seth Roberts</a></td><td>WR</td><td>OAK</td><td>10</td><td>WR96</td></tr><tr class='last'><td>264. <a href='http://www.espn.com/nfl/player/_/id/2979590/jesse-james'>Jesse James</a></td><td>TE</td><td>PIT</td><td>8</td><td>TE28</td></tr><tr class='last'><td>265. <a href='http://www.espn.com/nfl/player/_/id/2970726/maxx-williams'>Maxx Williams</a></td><td>TE</td><td>BAL</td><td>8</td><td>TE29</td></tr><tr class='last'><td>266. <a href='http://www.espn.com/nfl/player/_/id/8416/alex-smith'>Alex Smith</a></td><td>QB</td><td>KC</td><td>5</td><td>QB27</td></tr><tr class='last'><td>267. <a href='http://www.espn.com/nfl/player/_/id/2577417/dak-prescott'>Dak Prescott</a></td><td>QB</td><td>DAL</td><td>7</td><td>QB28</td></tr><tr class='last'><td>268. <a href='http://www.espn.com/nfl/player/_/id/13197/sam-bradford'>Sam Bradford</a></td><td>QB</td><td>PHI</td><td>4</td><td>QB29</td></tr><tr class='last'><td>269. <a href='http://www.espn.com/nfl/player/_/id/2511109/trevor-siemian'>Trevor Siemian</a></td><td>QB</td><td>DEN</td><td>11</td><td>QB30</td></tr><tr class='last'><td>270. <a href='http://www.espn.com/nfl/player/_/id/13987/blaine-gabbert'>Blaine Gabbert</a></td><td>QB</td><td>SF</td><td>8</td><td>QB31</td></tr><tr class='last'><td>271. <a href='http://www.espn.com/nfl/player/_/id/2577134/ty-montgomery'>Ty Montgomery</a></td><td>WR</td><td>GB</td><td>4</td><td>WR97</td></tr><tr class='last'><td>272. <a href='http://www.espn.com/nfl/player/_/id/11674/danny-amendola'>Danny Amendola</a></td><td>WR</td><td>NE</td><td>9</td><td>WR98</td></tr><tr class='last'><td>273. <a href='http://www.espn.com/nfl/player/_/id/11276/eddie-royal'>Eddie Royal</a></td><td>WR</td><td>CHI</td><td>9</td><td>WR99</td></tr><tr class='last'><td>274. <a href='http://www.espn.com/nfl/player/_/id/13958/andrew-hawkins'>Andrew Hawkins</a></td><td>WR</td><td>CLE</td><td>13</td><td>WR100</td></tr><tr class='last'><td>275. <a href='http://www.espn.com/nfl/player/_/id/16836/jared-abbrederis'>Jared Abbrederis</a></td><td>WR</td><td>GB</td><td>4</td><td>WR101</td></tr><tr class='last'><td>276. <a href='http://www.espn.com/nfl/player/_/id/2521161/zach-zenner'>Zach Zenner</a></td><td>RB</td><td>DET</td><td>10</td><td>RB83</td></tr><tr class='last'><td>277. <a href='http://www.espn.com/nfl/player/_/id/16889/andre-williams'>Andre Williams</a></td><td>RB</td><td>NYG</td><td>8</td><td>RB84</td></tr><tr class='last'><td>278. <a href='http://www.espn.com/nfl/player/_/id/15755/fozzy-whittaker'>Fozzy Whittaker</a></td><td>RB</td><td>CAR</td><td>7</td><td>RB85</td></tr><tr class='last'><td>279. <a href='http://www.espn.com/nfl/player/_/id/3025433/mike-davis'>Mike Davis</a></td><td>RB</td><td>SF</td><td>8</td><td>RB86</td></tr><tr class='last'><td>280. <a href='http://www.espn.com/nfl/player/_/id/2570986/malcolm-brown'>Malcolm Brown</a></td><td>RB</td><td>LA</td><td>8</td><td>RB87</td></tr><tr class='last'><td>281. <a href='http://www.espn.com/nfl/player/_/id/16921/alfred-blue'>Alfred Blue</a></td><td>RB</td><td>HOU</td><td>9</td><td>RB88</td></tr><tr class='last'><td>282. <a href='http://www.espn.com/nfl/player/_/id/2576165/josh-ferguson'>Josh Ferguson</a></td><td>RB</td><td>IND</td><td>10</td><td>RB89</td></tr><tr class='last'><td>283. <a href='http://www.espn.com/nfl/player/_/id/3046409/alex-collins'>Alex Collins</a></td><td>RB</td><td>SEA</td><td>5</td><td>RB90</td></tr><tr class='last'><td>284. Karlos Williams</td><td>RB</td><td>FA</td><td>--</td><td>RB91</td></tr><tr class='last'><td>285. <a href='/nfl/team/_/name/bal/baltimore-ravens'>Baltimore Ravens</a></td><td>DST</td><td>BAL</td><td>8</td><td>DST17</td></tr><tr class='last'><td>286. <a href='/nfl/team/_/name/pit/pittsburgh-steelers'>Pittsburgh Steelers</a></td><td>DST</td><td>PIT</td><td>8</td><td>DST18</td></tr><tr class='last'><td>287. <a href='http://www.espn.com/nfl/player/_/id/4333/matt-bryant'>Matt Bryant</a></td><td>K</td><td>ATL</td><td>11</td><td>K17</td></tr><tr class='last'><td>288. <a href='http://www.espn.com/nfl/player/_/id/9329/nick-novak'>Nick Novak</a></td><td>K</td><td>HOU</td><td>9</td><td>K18</td></tr><tr class='last'><td>289. <a href='http://www.espn.com/nfl/player/_/id/16792/jace-amaro'>Jace Amaro</a></td><td>TE</td><td>NYJ</td><td>11</td><td>TE30</td></tr><tr class='last'><td>290. <a href='http://www.espn.com/nfl/player/_/id/17453/cameron-brate'>Cameron Brate</a></td><td>TE</td><td>TB</td><td>6</td><td>TE31</td></tr><tr class='last'><td>291. <a href='http://www.espn.com/nfl/player/_/id/3046439/hunter-henry'>Hunter Henry</a></td><td>TE</td><td>SD</td><td>11</td><td>TE32</td></tr><tr class='last'><td>292. <a href='http://www.espn.com/nfl/player/_/id/16786/richard-rodgers'>Richard Rodgers</a></td><td>TE</td><td>GB</td><td>4</td><td>TE33</td></tr><tr class='last'><td>293. <a href='http://www.espn.com/nfl/player/_/id/14007/lance-kendricks'>Lance Kendricks</a></td><td>TE</td><td>LA</td><td>8</td><td>TE34</td></tr><tr class='last'><td>294. <a href='http://www.espn.com/nfl/player/_/id/14911/rueben-randle'>Rueben Randle</a></td><td>WR</td><td>PHI</td><td>4</td><td>WR102</td></tr><tr class='last'><td>295. <a href='http://www.espn.com/nfl/player/_/id/2576395/devin-smith'>Devin Smith</a></td><td>WR</td><td>NYJ</td><td>11</td><td>WR103</td></tr><tr class='last'><td>296. <a href='http://www.espn.com/nfl/player/_/id/5209/tony-romo'>Tony Romo</a></td><td>QB</td><td>DAL</td><td>7</td><td>QB32</td></tr><tr class='last'><td>297. <a href='/nfl/team/_/name/phi/philadelphia-eagles'>Philadelphia Eagles</a></td><td>DST</td><td>PHI</td><td>4</td><td>DST19</td></tr><tr class='last'><td>298. <a href='/nfl/team/_/name/tb/tampa-bay-buccaneers'>Tampa Bay Buccaneers</a></td><td>DST</td><td>TB</td><td>6</td><td>DST20</td></tr><tr class='last'><td>299. <a href='/nfl/team/_/name/chi/chicago-bears'>Chicago Bears</a></td><td>DST</td><td>CHI</td><td>9</td><td>DST21</td></tr><tr class='last'><td>300. <a href='/nfl/team/_/name/det/detroit-lions'>Detroit Lions</a></td><td>DST</td><td>DET</td><td>10</td><td>DST22</td></tr></tbody></table></aside>
</div><footer class='article-footer'><ul data-id='16287927' data-name='2016 Fantasy football rankings: Top 300' data-type='video' class='article-social horizontal' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300'><li><a href='https://www.facebook.com/dialog/share?href=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&app_id=116656161708917' class='btn-social icon-font-before icon-facebook-solid-before horizontal' target='new' data-social-type='horizontal' data-social-tool='facebook' data-short-text='Share' data-long-text='Share with Facebook'>Facebook</a></li><li><a href='http://twitter.com/intent/tweet?lang=en&url=http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016%2Dfantasy%2Dfootball%2Drankings%2Dtop%2D300&text=Fantasy%20football%20rankings%3A%20Top%20300%20for%202016' class='btn-social icon-font-before icon-twitter-solid-before horizontal' target='new' data-social-type='horizontal' data-social-tool='twitter' data-short-text='Tweet' data-long-text='Share with Twitter'>Twitter</a></li><li><a href='whatsapp://send?text=2016%20Fantasy%20football%20rankings%3A%20Top%20300%20website%3A%20http%3A%2F%2Fwww.espn.com%2Ffantasy%2Ffootball%2Fstory%2F_%2Fid%2F16287927%2F2016-fantasy-football-rankings-top-300' class='btn-social icon-font-before icon-whatsapp-solid-before horizontal' data-social-type='horizontal' data-social-tool='whatsapp'></a></li><li><a href='https://pinterest.com/pin/create/button/?url=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300&description=2016+Fantasy+football+rankings%3A+Top+300&media=http%3A%2F%2Fa.espncdn.com%2Fphoto%2F2016%2F0731%2Fr108675_1296x729_16-9.jpg' class='btn-social icon-font-before icon-pinterest-solid-before horizontal' data-social-type='horizontal' data-social-tool='pinterest'>Pinterest</a></li><li class='internal send-email'><a href='mailto:?subject=2016 Fantasy football rankings: Top 300&body=http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-route='false' class='btn-social icon-font-before icon-email-solid-before page-action email horizontal' data-social-type='horizontal' data-social-tool='email'>Email</a></li><li class='internal'><a href='#' class='btn-social page-action comment icon-font-before icon-comment-solid-before horizontal' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-social-type='horizontal' data-social-tool='comment'>comment</a></li></ul><div class='sponsored-links'><h4>Sponsored Headlines</h4><div class='outbrain-container' data-widget-id='noncompliant' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300' data-ob-template='espn'></div></div><div class='internal comments'><div class='page-action comment button-alt lg' data-src='http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300'> Comments </div></div></footer></div></article></section>
                    </div>

                    

                </section>
               

            </section>
        </div>
		

<script>
	var espn_ui = window.espn_ui || {};
	espn_ui.staticRef = 'http://a.espncdn.com/redesign/0.315.13';
	espn_ui.imgRef = 'http://a.espncdn.com/redesign/assets/img/';
	espn_ui.insertRef = 'http://a.espncdn.com';
	espn_ui.deviceType = 'desktop';
	espn_ui.pageShell = false;
	espn.api = {};
	espn.api.disasterURLs = {
		'cdn.espn.com':'cdn.espn.com',
		'sports.core.api.espn.com':'sports.core.api.espn.com',
		'site.api.espn.com':'site.api.espn.com',
		'site.api.prod.espninfra.starwave.com':'site.api.prod.espninfra.starwave.com',
		'fan.core.api.espn.com':'fan.core.api.espn.com',
		'site.core.api.prod.espninfra.starwave.com':'site.core.api.prod.espninfra.starwave.com',
		'api.espn.com':'api.espn.com',
		'api-app.espn.com':'api-app.espn.com',
		'api.prod.espninfra.starwave.com':'api.prod.espninfra.starwave.com'
	};
	espn_ui.webview = false;
	espn_ui.onefeed = false;
</script>

<script src='http://a.espncdn.com/redesign/0.315.13/js/espn-critical.js'></script>


<script type='text/javascript'>
	var espn = espn || {};
	/* building skeleton for namespace */
    espn.scoreboard = {
        topics: {
            scoreboard: '',
            scoreboxes: []
        },
        models: {},
        views: {},
        collections: {},
        timezoneOffset: 0,
        favorites: {},
        editData: {},
        activeLeague: 'topEvents',
        hiddenLeague: 'null',
        settings: {
			activeLeagues: [{'sportId':0,'league':'topEvents','displayName':'Top Events'},{'sportId':851,'link':{'title':'Full Results &#187;','onclick':'','href':'http://www.espn.com/tennis/dailyResults'},'sport':'tennis','top25Only':true,'league':'atp','displayName':'Tennis (M)'},{'sportId':900,'link':{'title':'Full Results &#187;','onclick':'','href':'http://www.espn.com/tennis/dailyResults'},'sport':'tennis','top25Only':true,'league':'wta','displayName':'Tennis (W)'},{'sportId':10,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espn.com/mlb/scoreboard'},'sport':'baseball','top25Only':true,'league':'mlb','displayName':'MLB'},{'sportId':28,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espn.com/nfl/scoreboard'},'sport':'football','top25Only':true,'league':'nfl','displayName':'NFL'},{'sportId':23,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espn.com/college-football/scoreboard'},'sport':'football','top25Only':false,'league':'college-football','displayName':'NCAAF'},{'sportId':700,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espnfc.com/scores?cc=5901'},'sport':'soccer','top25Only':true,'league':'eng.1','displayName':'English Premier League'},{'sportId':770,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espnfc.com/scores?cc=5901'},'sport':'soccer','top25Only':true,'league':'usa.1','displayName':'MLS'},{'sportId':760,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espnfc.com/scores?cc=5901'},'sport':'soccer','top25Only':true,'league':'mex.1','displayName':'Mexican Liga MX'},{'sportId':740,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espnfc.com/scores?cc=5901'},'sport':'soccer','top25Only':true,'league':'esp.1','displayName':'La Liga'},{'sportId':1106,'link':{'title':'Full Leaderboard &#187;','onclick':'','href':'http://www.espn.com/golf/leaderboard'},'sport':'golf','top25Only':true,'league':'pga','displayName':'Golf (M)'},{'sportId':59,'link':{'title':'Full Scoreboard &#187;','onclick':'','href':'http://www.espn.com/wnba/scoreboard'},'sport':'basketball','top25Only':true,'league':'wnba','displayName':'WNBA'},{'sportId':2021,'link':{'title':'Full results &#187;','onclick':'','href':'http://www.espn.com/racing/schedule'},'sport':'racing','top25Only':true,'league':'sprint','displayName':'NASCAR'}],
			useStatic: false,
			initialTopic: 'event-topevents',
			version: 2
			
			
			
			
			
			
		},
		data: {'sports':[{'uid':'s:850','id':'850','leagues':[{'uid':'s:850~l:900','id':'900','events':[{'summary':'Final','uid':'s:850~l:900~e:189~c:73385','matchNumber':'1st Match','status':'post','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:900~a:2114','id':'2114','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/2114.png','rank':'','linescores':[{'score':6,'label':'1','setScore':6,'period':1},{'score':3,'label':'2','setScore':3,'period':2},{'score':4,'label':'3','setScore':4,'period':3}],'name':'T. Townsend','score':'6-4 3-6 4-6','winner':false,'displayName':'Taylor Townsend','type':'athlete'},{'uid':'s:850~l:900~a:630','id':'630','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/den.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/630.png','rank':'','linescores':[{'score':4,'label':'1','setScore':4,'period':1},{'score':6,'label':'2','setScore':6,'period':2},{'score':6,'label':'3','setScore':6,'period':3}],'name':'C. Wozniacki','score':'4-6 6-3 6-4','winner':true,'displayName':'Caroline Wozniacki','type':'athlete'}],'broadcast':'','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=2'}],'round':1,'competitionId':'73385','date':'2016-08-29T15:00:00Z','period':3,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':0,'name':'US Open','fullStatus':{'type':{'id':3,'shortDetail':'Final','detail':'Final','description':'FINAL','state':'post'},'period':3},'note':'Round 1 - Grandstand - 1st Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4}]},{'summary':'Final/Retired','uid':'s:850~l:900~e:189~c:73410','matchNumber':'2nd Match','status':'post','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:900~a:1095','id':'1095','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/slo.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1095.png','rank':'','linescores':[{'score':0,'label':'1','setScore':0,'period':1},{'score':0,'label':'2','setScore':0,'period':2}],'name':'P. Hercog','score':'0-6 0-1','winner':false,'displayName':'Polona Hercog','type':'athlete'},{'uid':'s:850~l:900~a:745','id':'745','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ger.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/745.png','rank':'2','linescores':[{'score':6,'label':'1','setScore':6,'period':1},{'score':1,'label':'2','setScore':1,'period':2}],'name':'A. Kerber','score':'6-0 1-0','winner':true,'displayName':'Angelique Kerber','type':'athlete'}],'broadcast':'','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=2'}],'round':1,'competitionId':'73410','date':'2016-08-29T16:50:00Z','period':2,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':1,'name':'US Open','fullStatus':{'type':{'id':38,'shortDetail':'Final/Retired','detail':'Final/Retired','description':'RETIRED','state':'post'},'period':2},'note':'Round 1 - Arthur Ashe Stadium - 2nd Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4}]},{'summary':'9:30 PM ET','uid':'s:850~l:900~e:189~c:73379','matchNumber':'5th Match','status':'pre','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:900~a:1556','id':'1556','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1556.png','rank':'8','linescores':[],'name':'M. Keys','score':'','winner':false,'displayName':'Madison Keys','type':'athlete'},{'uid':'s:850~l:900~a:1765','id':'1765','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1765.png','rank':'','linescores':[],'name':'A. Riske','score':'','winner':false,'displayName':'Alison Riske','type':'athlete'}],'broadcast':'ESPN2','link':'','links':[{'text':'Schedule','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=2'}],'round':1,'competitionId':'73379','date':'2016-08-30T01:30:00Z','period':0,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':2,'name':'US Open','fullStatus':{'type':{'id':1,'shortDetail':'9:30 PM ET','detail':'9:30 PM ET','description':'SCHEDULED','state':'pre'},'period':0},'note':'Round 1 - Arthur Ashe Stadium - 5th Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN2','broadcasterId':139,'callLetters':'ESPN2','broadcastId':139,'shortName':'ESPN2','type':'TV','lang':'en','typeId':1}]}],'name':'Women's Tennis Association','smartdates':['2016-08-27T07:00:00Z','2016-08-29T07:00:00Z','2016-08-30T07:00:00Z'],'slug':'wta','abbreviation':'wta','shortName':'WTA'},{'uid':'s:850~l:851','id':'851','events':[{'summary':'Final','uid':'s:850~l:851~e:189~c:73299','matchNumber':'3rd Match','status':'post','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:851~a:261','id':'261','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/esp.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/261.png','rank':'4','linescores':[{'score':6,'label':'1','setScore':6,'period':1},{'score':6,'label':'2','setScore':6,'period':2},{'score':6,'label':'3','setScore':6,'period':3}],'name':'R. Nadal','score':'6-1 6-4 6-2','winner':true,'displayName':'Rafael Nadal','type':'athlete'},{'uid':'s:850~l:851~a:1168','id':'1168','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/uzb.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1168.png','rank':'','linescores':[{'score':1,'label':'1','setScore':1,'period':1},{'score':4,'label':'2','setScore':4,'period':2},{'score':2,'label':'3','setScore':2,'period':3}],'name':'D. Istomin','score':'1-6 4-6 2-6','winner':false,'displayName':'Denis Istomin','type':'athlete'}],'broadcast':'ESPN','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=1'}],'round':1,'competitionId':'73299','date':'2016-08-29T18:00:00Z','period':3,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':3,'name':'US Open','fullStatus':{'type':{'id':3,'shortDetail':'Final','detail':'Final','description':'FINAL','state':'post'},'period':3},'note':'Round 1 - Arthur Ashe Stadium - 3rd Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4},{'region':'us','isNational':true,'name':'ESPN','broadcasterId':126,'callLetters':'ESPN','broadcastId':126,'shortName':'ESPN','type':'TV','lang':'en','typeId':1}]},{'summary':'Final','uid':'s:850~l:851~e:189~c:73298','matchNumber':'1st Match','status':'post','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:851~a:613','id':'613','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/bra.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/613.png','rank':'','linescores':[{'score':4,'label':'1','setScore':4,'period':1},{'score':5,'label':'2','setScore':5,'period':2},{'score':1,'label':'3','setScore':1,'period':3}],'name':'R. Dutra Silva','score':'4-6 5-7 1-6','winner':false,'displayName':'Rogerio Dutra Silva','type':'athlete'},{'uid':'s:850~l:851~a:464','id':'464','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/cro.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/464.png','rank':'7','linescores':[{'score':6,'label':'1','setScore':6,'period':1},{'score':7,'label':'2','setScore':7,'period':2},{'score':6,'label':'3','setScore':6,'period':3}],'name':'M. Cilic','score':'6-4 7-5 6-1','winner':true,'displayName':'Marin Cilic','type':'athlete'}],'broadcast':'','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=1'}],'round':1,'competitionId':'73298','date':'2016-08-29T15:00:00Z','period':3,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':4,'name':'US Open','fullStatus':{'type':{'id':3,'shortDetail':'Final','detail':'Final','description':'FINAL','state':'post'},'period':3},'note':'Round 1 - Louis Armstrong Stadium - 1st Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4}]},{'summary':'2nd Set','uid':'s:850~l:851~e:189~c:73295','matchNumber':'4th Match','status':'in','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:851~a:1895','id':'1895','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1895.png','rank':'26','linescores':[{'tieBreakScore':7,'score':7,'label':'1','setScore':7,'period':1},{'score':5,'label':'2','setScore':5,'period':2}],'name':'J. Sock','score':'7-6(7-3) 5-5','winner':false,'displayName':'Jack Sock','type':'athlete'},{'uid':'s:850~l:851~a:2946','id':'2946','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/2946.png','rank':'','linescores':[{'tieBreakScore':3,'score':6,'label':'1','setScore':6,'period':1},{'score':5,'label':'2','setScore':5,'period':2}],'name':'T. Fritz','score':'6-7(3-7) 5-5','winner':false,'displayName':'Taylor Fritz','type':'athlete'}],'broadcast':'','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=1'},{'text':'Courtcast','href':'http://espn.go.com/tennis/courtcast'}],'round':1,'competitionId':'73295','date':'2016-08-29T21:30:00Z','period':2,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':5,'name':'US Open','fullStatus':{'type':{'id':2,'shortDetail':'2nd Set','detail':'2nd Set','description':'IN PROGRESS','state':'in'},'period':2},'note':'Round 1 - Louis Armstrong Stadium - 4th Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4}]},{'summary':'Final','uid':'s:850~l:851~e:189~c:73287','matchNumber':'2nd Match','status':'post','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:851~a:1023','id':'1023','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1023.png','rank':'20','linescores':[{'score':3,'label':'1','setScore':3,'period':1},{'score':4,'label':'2','setScore':4,'period':2},{'tieBreakScore':7,'score':7,'label':'3','setScore':7,'period':3},{'score':6,'label':'4','setScore':6,'period':4},{'tieBreakScore':7,'score':7,'label':'5','setScore':7,'period':5}],'name':'J. Isner','score':'3-6 4-6 7-6(7-5) 6-2 7-6(7-3)','winner':true,'displayName':'John Isner','type':'athlete'},{'uid':'s:850~l:851~a:2708','id':'2708','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/2708.png','rank':'','linescores':[{'score':6,'label':'1','setScore':6,'period':1},{'score':6,'label':'2','setScore':6,'period':2},{'tieBreakScore':5,'score':6,'label':'3','setScore':6,'period':3},{'score':2,'label':'4','setScore':2,'period':4},{'tieBreakScore':3,'score':6,'label':'5','setScore':6,'period':5}],'name':'F. Tiafoe','score':'6-3 6-4 6-7(5-7) 2-6 6-7(3-7)','winner':false,'displayName':'Frances Tiafoe','type':'athlete'}],'broadcast':'','link':'','links':[{'text':'Results','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=1'}],'round':1,'competitionId':'73287','date':'2016-08-29T17:45:00Z','period':5,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':6,'name':'US Open','fullStatus':{'type':{'id':3,'shortDetail':'Final','detail':'Final','description':'FINAL','state':'post'},'period':5},'note':'Round 1 - Grandstand - 2nd Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN3','broadcasterId':122,'callLetters':'ESPN3','broadcastId':122,'shortName':'ESPN3','type':'Web','lang':'en','typeId':4}]},{'summary':'7:00 PM ET','uid':'s:850~l:851~e:189~c:73283','matchNumber':'4th Match','status':'pre','location':'Flushing Meadows, New York, USA','competitors':[{'uid':'s:850~l:851~a:296','id':'296','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ser.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/296.png','rank':'1','linescores':[],'name':'N. Djokovic','score':'','winner':false,'displayName':'Novak Djokovic','type':'athlete'},{'uid':'s:850~l:851~a:1278','id':'1278','logo':'http://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/pol.png','headshot':'http://a.espncdn.com/i/headshots/tennis/players/full/1278.png','rank':'','linescores':[],'name':'J. Janowicz','score':'','winner':false,'displayName':'Jerzy Janowicz','type':'athlete'}],'broadcast':'ESPN2','link':'','links':[{'text':'Schedule','href':'http://espn.go.com/tennis/scoreboard?tournamentId=189&year=2016&matchType=1'}],'round':1,'competitionId':'73283','date':'2016-08-29T23:00:00Z','period':0,'onWatch':false,'id':'189','timeValid':true,'appLinks':[],'season':2016,'priority':7,'name':'US Open','fullStatus':{'type':{'id':1,'shortDetail':'7:00 PM ET','detail':'7:00 PM ET','description':'SCHEDULED','state':'pre'},'period':0},'note':'Round 1 - Arthur Ashe Stadium - 4th Match','broadcasts':[{'region':'us','isNational':true,'name':'ESPN2','broadcasterId':139,'callLetters':'ESPN2','broadcastId':139,'shortName':'ESPN2','type':'TV','lang':'en','typeId':1}]}],'name':'Association of Tennis Professionals','smartdates':['2016-08-27T07:00:00Z','2016-08-29T07:00:00Z','2016-08-30T07:00:00Z'],'slug':'atp','abbreviation':'atp','shortName':'ATP'}],'name':'tennis','slug':'tennis'},{'uid':'s:1','id':'1','leagues':[{'uid':'s:1~l:10','id':'10','events':[{'uid':'s:1~l:10~e:360829101~c:360829101','summary':'Top 2nd','location':'Oriole Park at Camden Yards','onSecond':0,'outsText':'2 Outs','competitors':[{'uid':'s:1~l:10~t:1','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/bal.png','competitionIdPrevious':'360828110','score':'0','winner':false,'competitionIdNext':'360830101','type':'team','abbreviation':'BAL','id':'1','record':'71-59','color':'201b1b','name':'Orioles','displayName':'Baltimore Orioles','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/bal.png','homeAway':'home'},{'uid':'s:1~l:10~t:14','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/tor.png','competitionIdPrevious':'360828114','score':'0','winner':false,'competitionIdNext':'360830101','type':'team','abbreviation':'TOR','id':'14','record':'74-56','color':'0069ac','name':'Blue Jays','displayName':'Toronto Blue Jays','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/tor.png','homeAway':'away'}],'link':'','broadcast':'','date':'2016-08-29T23:05:00Z','id':'360829101','onWatch':false,'baseRunnersText':'Bases empty','priority':8,'status':'in','clock':2,'seasonType':2,'seriesSummary':'TOR wins 7-6','links':[{'text':'Gamecast','href':'http://espn.go.com/mlb/gamecast?gameId=360829101'},{'text':'Box Score','href':'http://espn.go.com/mlb/boxscore?gameId=360829101'}],'period':2,'competitionId':'360829101','onFirst':0,'timeValid':true,'appLinks':[{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829101'}],'season':2016,'onThird':0,'fullStatus':{'clock':2,'type':{'id':2,'shortDetail':'Top 2nd','detail':'Top 2nd','description':'IN PROGRESS','state':'in'},'period':2},'broadcasts':[{'region':'us','isNational':false,'priority':0,'name':'Mid-Atlantic Sports Network','broadcasterId':153,'callLetters':'MASN','broadcastId':153,'shortName':'MASN','type':'TV','lang':'en','typeId':1}]},{'uid':'s:1~l:10~e:360829102~c:360829102','summary':'Bot 1st','location':'Fenway Park','onSecond':0,'outsText':'2 Outs','competitors':[{'uid':'s:1~l:10~t:2','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/bos.png','competitionIdPrevious':'360828102','score':'0','winner':false,'competitionIdNext':'360830102','type':'team','abbreviation':'BOS','id':'2','record':'72-58','color':'00224b','name':'Red Sox','displayName':'Boston Red Sox','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/bos.png','homeAway':'home'},{'uid':'s:1~l:10~t:30','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/tb.png','competitionIdPrevious':'360828118','score':'0','winner':false,'competitionIdNext':'360830102','type':'team','abbreviation':'TB','id':'30','record':'55-74','color':'002454','name':'Rays','displayName':'Tampa Bay Rays','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/tb.png','homeAway':'away'}],'link':'','broadcast':'','date':'2016-08-29T23:10:00Z','id':'360829102','onWatch':false,'baseRunnersText':'Bases empty','priority':9,'status':'in','clock':2,'seasonType':2,'seriesSummary':'BOS wins 7-6','links':[{'text':'Gamecast','href':'http://espn.go.com/mlb/gamecast?gameId=360829102'},{'text':'Box Score','href':'http://espn.go.com/mlb/boxscore?gameId=360829102'}],'period':1,'competitionId':'360829102','onFirst':0,'timeValid':true,'appLinks':[{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829102'}],'season':2016,'onThird':0,'fullStatus':{'clock':2,'type':{'id':2,'shortDetail':'Bot 1st','detail':'Bot 1st','description':'IN PROGRESS','state':'in'},'period':1},'broadcasts':[{'region':'us','isNational':false,'priority':0,'name':'NESN','broadcasterId':19,'callLetters':'NESN','broadcastId':19,'shortName':'NESN','type':'TV','lang':'en','typeId':1}]},{'summary':'2016-08-30T00:00:00Z','uid':'s:1~l:10~e:360829113~c:360829113','location':'Globe Life Park in Arlington','seasonType':2,'clock':0,'status':'pre','seriesSummary':'TEX wins 8-4','competitors':[{'uid':'s:1~l:10~t:13','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/tex.png','competitionIdPrevious':'360828113','score':'0','winner':false,'competitionIdNext':'360830113','type':'team','abbreviation':'TEX','id':'13','record':'77-54','color':'003879','name':'Rangers','displayName':'Texas Rangers','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/tex.png','homeAway':'home'},{'uid':'s:1~l:10~t:12','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/sea.png','competitionIdPrevious':'360828104','score':'0','winner':false,'competitionIdNext':'360830113','type':'team','abbreviation':'SEA','id':'12','record':'68-62','color':'012a5b','name':'Mariners','displayName':'Seattle Mariners','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/sea.png','homeAway':'away'}],'broadcast':'ESPN','link':'','links':[{'text':'Preview','href':'http://espn.go.com/mlb/preview?gameId=360829113'},{'text':'Tickets','href':'http://www.stubhub.com/texas-rangers-tickets-rangers-vs-mariners-8-29-2016/event/9442892/'}],'competitionId':'360829113','date':'2016-08-30T00:00:00Z','period':0,'onWatch':true,'id':'360829113','timeValid':true,'appLinks':[{'rel':['event','app','watchespn'],'href':'watchespn://showEvent?gameId=360829113'},{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829113'}],'season':2016,'priority':10,'fullStatus':{'clock':0,'type':{'id':1,'shortDetail':'2016-08-30T00:00:00Z','detail':'2016-08-30T00:00:00Z','description':'SCHEDULED','state':'pre'},'period':0},'broadcasts':[{'region':'us','isNational':true,'priority':0,'name':'ESPN','broadcasterId':24,'callLetters':'ESPN','broadcastId':24,'shortName':'ESPN','type':'TV','lang':'en','typeId':1},{'region':'us','isNational':false,'priority':0,'name':'Fox Sports Southwest','broadcasterId':79,'callLetters':'FXSW','broadcastId':79,'shortName':'FSSW','type':'TV','lang':'en','typeId':1}]},{'summary':'2016-08-30T00:05:00Z','uid':'s:1~l:10~e:360829116~c:360829116','location':'Wrigley Field','seasonType':2,'clock':0,'status':'pre','seriesSummary':'CHC wins 9-3','competitors':[{'uid':'s:1~l:10~t:16','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/chc.png','competitionIdPrevious':'360828119','score':'0','winner':false,'competitionIdNext':'360830116','type':'team','abbreviation':'CHC','id':'16','record':'82-47','color':'00417d','name':'Cubs','displayName':'Chicago Cubs','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/chc.png','homeAway':'home'},{'uid':'s:1~l:10~t:23','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/pit.png','competitionIdPrevious':'360828108','score':'0','winner':false,'competitionIdNext':'360830116','type':'team','abbreviation':'PIT','id':'23','record':'67-61','color':'111111','name':'Pirates','displayName':'Pittsburgh Pirates','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/pit.png','homeAway':'away'}],'broadcast':'','link':'','links':[{'text':'Preview','href':'http://espn.go.com/mlb/preview?gameId=360829116'},{'text':'Tickets','href':'http://www.stubhub.com/chicago-cubs-tickets-cubs-vs-pirates-8-29-2016/event/9445349/'}],'competitionId':'360829116','date':'2016-08-30T00:05:00Z','period':0,'onWatch':false,'id':'360829116','timeValid':true,'appLinks':[{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829116'}],'season':2016,'priority':11,'fullStatus':{'clock':0,'type':{'id':1,'shortDetail':'2016-08-30T00:05:00Z','detail':'2016-08-30T00:05:00Z','description':'SCHEDULED','state':'pre'},'period':0},'broadcasts':[]},{'summary':'2016-08-30T00:15:00Z','uid':'s:1~l:10~e:360829107~c:360829107','location':'Kauffman Stadium','seasonType':2,'clock':0,'status':'pre','seriesSummary':'NYY wins 3-1','competitors':[{'uid':'s:1~l:10~t:7','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/kc.png','competitionIdPrevious':'360828102','score':'0','winner':false,'competitionIdNext':'360830107','type':'team','abbreviation':'KC','id':'7','record':'68-62','color':'003b72','name':'Royals','displayName':'Kansas City Royals','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/kc.png','homeAway':'home'},{'uid':'s:1~l:10~t:10','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/nyy.png','competitionIdPrevious':'360828110','score':'0','winner':false,'competitionIdNext':'360830107','type':'team','abbreviation':'NYY','id':'10','record':'67-62','color':'011739','name':'Yankees','displayName':'New York Yankees','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/nyy.png','homeAway':'away'}],'broadcast':'','link':'','links':[{'text':'Preview','href':'http://espn.go.com/mlb/preview?gameId=360829107'},{'text':'Tickets','href':'http://www.stubhub.com/kansas-city-royals-tickets-royals-vs-yankees-8-29-2016/event/9444881/'}],'competitionId':'360829107','date':'2016-08-30T00:15:00Z','period':0,'onWatch':false,'id':'360829107','timeValid':true,'appLinks':[{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829107'}],'season':2016,'priority':12,'fullStatus':{'clock':0,'type':{'id':1,'shortDetail':'2016-08-30T00:15:00Z','detail':'2016-08-30T00:15:00Z','description':'SCHEDULED','state':'pre'},'period':0},'broadcasts':[]},{'summary':'2016-08-30T02:05:00Z','uid':'s:1~l:10~e:360829103~c:360829103','location':'Angel Stadium of Anaheim','seasonType':2,'clock':0,'status':'pre','seriesSummary':'Series starts Mon 8/29','competitors':[{'uid':'s:1~l:10~t:3','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/laa.png','competitionIdPrevious':'360828106','score':'0','winner':false,'competitionIdNext':'360830103','type':'team','abbreviation':'LAA','id':'3','record':'56-74','color':'a50017','name':'Angels','displayName':'Los Angeles Angels','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/laa.png','homeAway':'home'},{'uid':'s:1~l:10~t:17','logo':'http://a.espncdn.com/i/teamlogos/mlb/500/scoreboard/cin.png','competitionIdPrevious':'360828129','score':'0','winner':false,'competitionIdNext':'360830103','type':'team','abbreviation':'CIN','id':'17','record':'55-74','color':'c41422','name':'Reds','displayName':'Cincinnati Reds','logoDark':'http://a.espncdn.com/i/teamlogos/mlb/500-dark/scoreboard/cin.png','homeAway':'away'}],'broadcast':'','link':'','links':[{'text':'Preview','href':'http://espn.go.com/mlb/preview?gameId=360829103'},{'text':'Tickets','href':'http://www.stubhub.com/los-angeles-angels-tickets-angels-vs-reds-8-29-2016/event/9442995/'}],'competitionId':'360829103','date':'2016-08-30T02:05:00Z','period':0,'onWatch':false,'id':'360829103','timeValid':true,'appLinks':[{'rel':['event','app','sportscenter'],'href':'sportscenter://x-callback-url/showGame?sportName=baseball&leagueAbbrev=mlb&gameId=360829103'}],'season':2016,'priority':13,'fullStatus':{'clock':0,'type':{'id':1,'shortDetail':'2016-08-30T02:05:00Z','detail':'2016-08-30T02:05:00Z','description':'SCHEDULED','state':'pre'},'period':0},'broadcasts':[{'region':'us','isNational':false,'priority':0,'name':'Fox Sports West','broadcasterId':76,'callLetters':'FOXW','broadcastId':76,'shortName':'FSW','type':'TV','lang':'en','typeId':1}]}],'name':'Major League Baseball','smartdates':['2016-08-28T07:00Z','2016-08-29T07:00Z','2016-08-30T07:00Z'],'slug':'mlb','abbreviation':'mlb','shortName':'MLB'}],'name':'baseball','slug':'baseball'},{'id':'-1','leagues':[{'id':'-1','events':[{'appLinks':[],'priority':14,'description':'2016 US Open','name':'2016 US Open','links':[{'text':'Full Coverage','href':'http://www.espn.com/watchespn/index#sport/tennis/'}],'notes':[{'text':'Today's US Open action is underway. Watch it all live on ESPN and ESPN app/WatchESPN. ','type':'editorial'}]}],'name':'custom','slug':'custom','abbreviation':'custom'}],'name':'custom','slug':'custom'}]}
    };
</script>


	<script type='text/javascript'>jQuery.subscribe('espn.defer.end', function(){ espn.scoreboard.init(); })</script>

	<script>
	(function(){
		var deferLoaded = false;
		function loadDefer(){
			if( !deferLoaded ){
				var deferScripts = ['http://a.espncdn.com/redesign/0.315.13/js/espn-defer.js', 'http://a.espncdn.com/redesign/0.315.13/js/espn-defer-low.js'];
				for( var s = 0; s < deferScripts.length; s++ ){
				  	var script = document.createElement('script');
				    script.src = deferScripts[s];
				    document.getElementsByTagName('head')[0].appendChild(script);
				}
			    deferLoaded = true;
			}
		}
		if( window.espn.loadType === 'loadEnd' && ( espn_ui.device.isMobile === true || espn_ui.device.isTablet === true ) ){
			$( window ).load(function() {
				setTimeout( loadDefer, 0 )
			});
			setTimeout( loadDefer, 5000 )
		}else{
			loadDefer();
		}
		
	})();
	</script>

	

<script>espn_ui.Helpers.translate.init();</script>


	<!--BEGIN QUALTRICS SITE INTERCEPT-->
	<div id='SI_9EvK9r52GPmgW9v'><!--DO NOT REMOVE-CONTENTS PLACED HERE--></div>
	<!--END SITE INTERCEPT-->

	
	<!-- SiteCatalyst code version: AppMeasurement 1.0 Copyright 1996-2013 Adobe, Inc. -->
	<script type='text/javascript'>

	if (typeof s_omni === 'undefined') {
		jQuery(function($){
			$.getScriptCache('http://a.espncdn.com/redesign/0.315.13/js/espn-analytics.js', 	function() {		var deferEvent = 'user.parsed',		trackInit = false;
		function initTrack(){			if (!trackInit && espn.track && (typeof espn.track.init) === 'function') {				espn.track.init({'cto':true,'chartbeat':{'authors':'story','title':'2016 Fantasy football rankings top 300','sections':'ffl','loadVidJS':true,'loadPubJS':false,'path':'/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300','domain':'www.espn.com','zone':'www.espn.com.us.ffl'},'device':'desktop','omniture':{'site':'espn','pageName':'ffl:story','premium':'premium-no','storyInfo':'16287927+2016+fantasy+football+rankings+top+300','sport':'ffl','contentType':'story','hier1':'ffl:story','convrSport':'ffl','lang':'en_us','pageURL':'www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300','section':'ffl','countryRegion':'en-us','columnist':'staff_fantasy','sections':'ffl:story','prop35':'2016-08-28','account':'wdgespcom'},'isFeaturePhone':false,'ABTest':{'raw':'{\'target\':{\'enabled\':false,\'placements\':[{\'site\':\'espn.co.uk\',\'flag\':false,\'regexp\':\'(/)\'},{\'site\':\'www.espn.com\',\'flag\':false,\'regexp\':\'(/.*)\'}],\'script\':\'http://a.espncdn.com/prod/scripts/analytics/target.20.r2.js\'},\'optimizely\':{\'enabled\':false,\'placements\':[{\'site\':\'espn.co.uk\',\'flag\':true,\'regexp\':\'(/)\'},{\'site\':\'www.espn.com\',\'flag\':true,\'regexp\':\'(/.*)\'}],\'oldscript\':\'http://a.espncdn.com/sports/optimizely.js\',\'script\':\'http://cdn.optimizely.com/js/310987714.js\'},\'fastcast\':{\'enabled\':false,\'placements\':{\'/ncf/index\':\'true\',\'/nba/index\':\'true\',\'^/.+$\':\'false\'},\'script\':\'http://a.espncdn.com/combiner/c?js=analytics/espn.fastcastTracking.4.js\'}}','optimizelyURLs':[{'site':'espn.co.uk','flag':true,'regexp':'(/)'},{'site':'www.espn.com','flag':true,'regexp':'(/.*)'}],'tScript':'http://a.espncdn.com/prod/scripts/analytics/target.20.r2.js','host':'espn.com','environment':'prod','optimizely':false,'target':false,'domain':'www.espn.com','isOptimizied':true,'targetURLs':[{'site':'espn.co.uk','flag':false,'regexp':'(/)'},{'site':'www.espn.com','flag':false,'regexp':'(/.*)'}],'oScript':'http://cdn.optimizely.com/js/310987714.js'}});				trackInit = true;			}		}		$.subscribe(deferEvent, initTrack);		setTimeout(initTrack, 5000);		if(window.espn_ui.userParsed){			$.publish('user.parsed');		}	});
		});
	}

	</script>

	<!-- End SiteCatalyst code version: AppMeasurement 1.0 --><script>
var sbDebug = window.espn && window.espn.flow && window.espn.flow.debug === true;
if(!sbDebug) {
	if (espn_ui.device.isMobile === true || espn_ui.device.isTablet === true) {
		jQuery.subscribe('espn.defer.end', function() {
			if (DTSS_WebSockets) {
				DTSS_WebSockets.PRECONNECT = true;
				DTSS_WebSockets.FORCE_PRECONNECT = true;
			}
		})
	} else {
		if (DTSS_WebSockets) {
			DTSS_WebSockets.PRECONNECT = true;
			DTSS_WebSockets.FORCE_PRECONNECT = true;
		}
	}
}
</script>


	</body>
</html>";
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
