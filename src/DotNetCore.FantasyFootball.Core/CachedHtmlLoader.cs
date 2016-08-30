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
