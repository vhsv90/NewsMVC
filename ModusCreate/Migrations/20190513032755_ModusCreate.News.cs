using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModusCreate.Migrations
{
    public partial class ModusCreateNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Category", "Date", "Description", "Title" },
                values: new object[,]
                {
                    { 1L, "Weather", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"A new round of powerful storms is causing more flooding in multiple states, with parts of the Deep South likely on the receiving end of some of the most severe weather through the end of the week that will impact about 40 million Americans.
                                        The National Weather Service cautioned residents of southeastern Texas, Louisiana and Mississippi to brace for a multiday barrage of dangerous heavy rain and flash flooding.
                                        The agency issued a flash flood watch for large portions of southeast Texas and Louisiana Thursday, to remain in effect through Saturday evening. Anywhere from 4 to 8 inches of rainfall are expected in the area, the NWS said.
                                        On Tuesday, surprise rain storms submerged streets and swamped homes in parts of Houston, the Houston Chronicle reported. The unexpected torrential rains also inundated schools and businesses, and stranded motorists and school children for hours.
                                        In all, 10 inches of rain fell in certain areas, leading to several high-water rescues by emergency responders. The Red Cross set up a shelter at a church northeast of Houston's downtown.", "Severe Weather And Storms Pummel Southern States" },
                    { 2L, "Traffic", new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Jim Russ' Weekend Traffic Advisory 
                                        The Maryland State Highway Administration will CLOSE MD 213 in the town of Centreville in Queen Anne’s County this weekend to install a temporary bridge over Gravel Run.
                                        MD 213 will be CLOSED between MD 304/Railroad Avenue and MD 305/Hope Road from 8 p.m. on Friday, May 10th until 5 a.m. on Monday, May 13th.
                                        Use US 301 as the alternate route.
                                        The temporary bridge will be in use while the permanent bridge on MD 213 across Gravel Run is reconstructed.
                                        Northbound Harbor Tunnel Closed Until Mid-June
                                        The Northbound tube of the Harbor Tunnel will be closed around-the-clock until mid-June as part of the project to rebuild two aging bridges on I-895 north of the tunnel.
                                        The closure took place on the evening of Friday, April 12th.
                                        While the Northbound tube is closed, the Southbound tube will carry two-way traffic, one lane in each direction.", "Jim Russ' Weekend Traffic Advisory" },
                    { 3L, "Sports", new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Albert Pujols joined the 2,000-RBI club on Thursday. Mike DiGiovanna, who I believe has seen all four members of the club play in person, was there and wrote,
                                        Whether driving in runs is more of a skill or a product of opportunity is open to debate. What cannot be denied is that Albert Pujols has been very good at it for a very long time.
                                        The Angels slugger notched the 2,000th RBI of his 19-year career with a solo home run to left field in the third inning of a 13-0 victory over the Detroit Tigers on Thursday in Comerica Park.", "Albert Pujols reaches major milestone" },
                    { 4L, "Government", new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), @"The social media giant said it received 6% fewer requests for user data from governments between June and December 2018 than during its previous reporting period.
                                        According to the newly released data, Twitter received 6,904 government requests for information on 11,112 accounts — the exact number of requests as its most recent report but with fewer accounts affected. The company turned over some data in just over half of all cases.
                                        The U.S. filed the most requests — a total of 2,092 requests for data on 3,860 accounts, representing about one-third of all global requests.", "Twitter publishes latest government data request figures" },
                    { 5L, "Technology", new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), @"This is at least the second time we've heard this rumor this year, but it remains questionable for a few reasons. For one, the iPhone SE uses the same A9 chip as the iPhone 6s and the fifth-generation iPad, so it would seem inconsistent if the iPhone SE was dropped but the latter two devices remained supported. 
                                        It could be theorized that Apple wants to drop support for iOS devices with 4-inch displays, including the iPhone 5s and iPhone SE, but there is again some inconsistency there, as the sixth-generation iPod touch will allegedly run iOS 13.", "Questionable Rumor Says iOS 13 Will Drop Support for iPhone 5s, iPhone 6 and 6 Plus, and iPhone SE" },
                    { 6L, "Technology", new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Since Google Calendar is one of the company's oldest and most ubiquitous products, you might think it would have reached this milestone already. However, it's only now joining the illustrious list of apps that have been installed from Play Store a total of one billion times.    
                                        Unlike Maps and Chrome, Calendar isn't a mandatory part of the GMS (Google Mobile Services) package, so OEMs are free to include their own calendar app instead, which many of them do. Even so, certain manufacturers whose Android skins are very close to stock still choose to go with Google Calendar, and Android One devices like those from Nokia also ship with it. It also plays a huge part in G Suite, so many will need it for work. It's not surprising that it's got to one billion, then.", "Google Calendar reaches 1 billion installs on the Play Store" },
                    { 7L, "Sports", new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), @"There is reportedly some thought within the Golden State Warriors organization that Kevin Durant leaving in free agency is not a foregone conclusion. 
                                        According to Sam Amick of The Athletic, there is a recent sense among those close to the Warriors that KD might think twice about leaving and instead re-sign due to the recent stretch of domination and fan appreciation.
                                        Durant, who has primarily been linked to the New York Knicks, is currently on the shelf with a right calf strain and is set to miss the remainder of Golden State's second-round playoff series against the Houston Rockets.", "Kevin Durant Rumors: 'Recent Sense' Star Could Re-Think Leaving Warriors in FA" },
                    { 8L, "Sports", new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), @"In the fourth quarter of the Portland Trail Blazers' Game 6 win against the Denver Nuggets, four players were assessed technical fouls after they got into a shoving match.
                                        Things got heated midway through the final period after Denver center Nikola Jokic was called for an offensive foul and the players got into a shoving match and had to be separated. After a review, there were offsetting technicals involving Denver's Will Barton and Torrey Craig, and Seth Curry and Zach Collins for Portland.
                                        Barton told The Denver Post the scuffle started when Collins fell into his knee with 6 minutes and 16 seconds left in the quarter. Barton said he was trying to protect himself before pushing Curry.", "Curry on scuffle with Barton: Nuggets are 'sassy' team" },
                    { 9L, "Health", new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Pharmaceutical giant Gilead Sciences has agreed to donate drugs that reduce the risk of HIV transmission for up to 200,000 people a year, the Trump administration says.
                                        The agreement between Gilead and the Trump administration will last until at least Dec. 31, 2025, and possibly through the end of 2030, Health and Human Services Secretary Alex Azar said in a statement Thursday. Gilead will donate its PrEP medication Truvada, which is used to reduce the risk of HIV infection and usually sells for $1,600 to $2,000 a month in the United States.", "Drugmaker Gilead reaches multiyear agreement with White House to donate HIV prevention med" },
                    { 10L, "Health", new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), @"The Iowa Department of Public Health wants to warn people about a strain of Hepatitis C in the state.
                                        Researchers say more than 18,000 Iowans were diagnosed with the virus since 2000, however, they say the number of Iowans unaware of their infection is possibly larger.
                                        Experts say if untreated, Hepatitis C can cause cirrhosis and liver cancer.
                                        In addition, the CDC said Hepatitis A infections have soared nearly 300 percent among adults in the U.S. in recent years.", "Health officials warning of Hepatitis C strain in Iowa" },
                    { 11L, "Entertainment", new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), @"North, Saint and Chicago West have a new little brother.
                                        Kim Kardashian, 38, and Kanye West, 41, have welcomed their fourth child together, a baby boy born via surrogate, she announced on Twitter on Friday.
                                        “He’s here and he’s perfect!” she wrote.", "Kim Kardashian and Kanye West welcome fourth child, a baby boy" },
                    { 12L, "Entertainment", new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legendary/Warner Bros. Ryan Reynolds-voiced pic gobbled up $5.7M last night from showtimes beginning at 4PM. It a great amount not far from New Line’s $5.9M Thursday night for Shazam! which turned in a $20.3M Friday for a $53.5M 3-day. Pokemon Detective Pikachu is poised for a $50M-$55M opening. Warners has done right by the franchise before when it opened the first title stateside in 1999, Pokemon: The First Movie, to a notable $31M at 3,043 theaters (unadjusted for inflation and big for the day).", "‘Pokemon Detective Pikachu’ Earns Great $5.7M Thursday; ‘Avengers: Endgame’ Heads For $700M" },
                    { 13L, "Entertainment", new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), @"It might be time to open a savings account dedicated to Rihanna: on Friday, she announced the launch of a luxury fashion line with LVMH, the conglomerate that's also home to Dior, Louis Vuitton and Fendi, among many others.
                                        Fenty, set to debut this spring, is the latest of Rihanna's business ventures, joining her industry-changing cosmetics brand Fenty Beauty and lingerie brand Savage X Fenty, which launched in 2017 and 2018, respectively.", "Rihanna to expand empire with launch of luxury fashion line" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
