namespace SWN.Data
{
    public class DataConstants
    {
        public class UserData
        {
            public const int UsernameMaxLength = 30;
            public const string EmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        }

        public class GameData
        {
            public const int NameMaxLength = 50;
            public const int DescriptionMaxLength = 1000;
        }

        public class FocusData
        {
            public const int NameMaxLength = 25;

            public const string FocusAlertName = "Alert";
            public const string FoucsAlertDescription = "You are keenly aware of your surroundings and virtually impossible to take unaware. You have an instinctive alacrity of response that helps you act before less wary persons can think to move.\nLevel 1: Gain Notice as a bonus skill. You cannot be surprised, nor can others use the Execution Attack option on you. When you roll initiative, roll twice and take the best result.\nLevel 2: You always act first in a combat round unless someone else involved is also this Alert.";

            public const string FocusArmsmanName = "Armsman";
            public const string FoucsArmsmanDescription = "You have an unusual competence with thrown weapons and melee attacks. This focus’ benefits do not apply to unarmed attacks or projectile weapons. For thrown weapons, you can’t use the benefits of the Armsman focus at the same time as Gunslinger.\nLevel 1: Gain Stab as a bonus skill. You can draw or sheath a Stowed melee or thrown weapon as an Instant action. You may add your Stab skill level to a melee or thrown weapon’s damage roll or Shock damage, assuming it has any to begin with.\nLevel 2: Your primitive melee and thrown weapons count as TL4 weapons for the purpose of overcoming advanced armors. Even on a miss with a melee weapon, you do an unmodified 1d4 damage to the target, plus any Shock damage. This bonus damage doesn’t apply to thrown weapons or attacks that use the Punch skill.";

            public const string FocusAssassinName = "Assassin";
            public const string FoucsAssassinDescription = "You are practiced at sudden murder, and have certain advantages in carrying out an Execution Attack as described in the rules on page 52.\nLevel 1: Gain Sneak as a bonus skill. You can conceal an object no larger than a knife or pistol from anything less invasive than a strip search, including normal TL4 weapon detection devices. You can draw or produce this object as an On Turn action, and your point-blank ranged attacks made from surprise with it cannot miss the target.\nLevel 2: You can take a Move action on the same round as you make an Execution Attack, closing rapidly with a target before you attack. You may split this Move action when making an Execution Attack, taking part of it before you murder your target and part of it afterwards. This movement happens too quickly to alert a victim or to be hindered by bodyguards, barring an actual physical wall of meat between you and your prey.";

            public const string FocusAuthorityName = "Authority";
            public const string FoucsAuthorityDescription = "You have an uncanny kind of charisma about you, one that makes others instinctively follow your instructions and further your causes. At level 1, this is a knack of charm and personal magnetism, while level 2 might suggest latent telepathic influence or transhuman memetic hacking augmentations. Where this focus refers to followers, it means NPCs who have voluntarily chosen to be in your service. PCs never count as followers.\nLevel 1: Gain Lead as a bonus skill. Once per day, you can make a request from an NPC who is not openly hostile to you, rolling a Cha/Lead skill check at a difficulty of the NPC’s Morale score. If you succeed, they will comply with the request, provided it is not harmful or extremely uncharacteristic.\nLevel 2: Those who follow you are fired with confidence. Any NPC being directly led by you gains a Morale and hit roll bonus equal to your Lead skill and a +1 bonus on all skill checks. Your followers will not act against your interests unless under extreme pressure.";

            public const string FocusCloseCombatantName = "Close Combatant";
            public const string FoucsCloseCombatantDescription = "You’ve had all too much practice at close-in fighting and desperate struggles with pistol or blade. You’re extremely skilled at avoiding injury in melee combat, and at level 2 you can dodge through a melee scrum without fear of being knifed in passing.\nLevel 1: Gain any combat skill as a bonus skill. You can use pistol-sized ranged weapons in melee without suffering penalties for the proximity of melee attackers. You ignore Shock damage from melee assailants, even if you’re unarmored at the time.\nLevel 2: The Shock damage from your melee attacks treats all targets as if they were AC 10. The Fighting Withdrawal combat action is treated as an On Turn action for you and can be performed freely.";

            public const string FocusConnectedName = "Connected";
            public const string FoucsConnectedDescription = "You’re remarkably gifted at making friends and forging ties with the people around you. Wherever you go, you always seem to know somebody useful to your ends.\nLevel 1: Gain Connect as a bonus skill. If you’ve spent at least a week in a not-entirely-hostile location, you’ll have built a web of contacts willing to do favors for you that are no more than mildly illegal. You can call on one favor per game day and the GM decides how far they’ll go for you.\nLevel 2: Once per game session, if it’s not entirely implausible, you meet someone you know who is willing to do modest favors for you. You can decide when and where you want to meet this person, but the GM decides who they are and what they can do for you.";

            public const string FocusDieHardName = "Die Hard";
            public const string FoucsDieHardDescription = "You are surprisingly hard to kill. You can survive injuries or bear up under stresses that would incapacitate a less determined hero.\nLevel 1: You gain an extra 2 maximum hit points per level. This bonus applies retroactively if you take this focus after first level. You automatically stabilize if mortally wounded by anything smaller than a Heavy weapon.\nLevel 2: The first time each day that you are reduced to zero hit points by an injury, you instead survive with one hit point remaining. This ability can’t save you from Heavy weapons or similar trauma.";

            public const string FocusDiplomatName = "Diplomat";
            public const string FoucsDiplomatDescription = "You know how to get your way in personal negotiations, and can manipulate the attitudes of those around you. Even so, while smooth words are versatile, they’ll only work if your interlocutor is actually willing to listen to you.\nLevel 1: Gain Talk as a bonus skill. You speak all the languages common to the sector and can learn new ones to a workable level in a week, becoming fluent in a month. Reroll 1s on any skill check dice related to negotiation or diplomacy.\nLevel 2: Once per game session, shift an intelligent NPC’s reaction roll one step closer to friendly if you can talk to them for at least thirty seconds.";

            public const string FocusGunslingerName = "Gunslinger";
            public const string FoucsGunslingerDescription = "You have a gift with a gun. While this talent most commonly applies to slugthrowers or energy weapons, it is also applicable to thrown weapons, bows, or other ranged weapons that can be used with the Shoot skill. For thrown weapons, you can’t use the benefits of the Armsman focus at the same time as Gunslinger.\nLevel 1: Gain Shoot as a bonus skill. You can draw or holster a Stowed ranged weapon as an On Turn action. You may add your Shoot skill level to a ranged weapon’s damage roll.\nLevel 2: Once per round, you can reload a ranged weapon as an On Turn action if it takes no more than one round to reload. Even on a miss with a Shoot attack, you do an unmodified 1d4 damage.";

            public const string FocusHackerName = "Hacker";
            public const string FoucsHackerDescription = "You have a considerable fluency with digital security measures and standard encryption methods. You know how to make computerized systems obey you until their automatic failsafes come down on your control.\nLevel 1: Gain Program as a bonus skill. When attempting to hack a database or computerized system, roll 3d6 on the skill check and drop the lowest die.\nLevel 2: Your hack duration increases to 1d4+Program skill x 10 minutes. You have an instinctive understanding of the tech; you never need to learn the data protocols for a strange system and are always treated as familiar with it.";

            public const string FocusHealerName = "Healer";
            public const string FoucsHealerDescription = "Healing comes naturally to you, and you’re particularly gifted at preventing the quick bleed-out of wounded allies and comrades.\nLevel 1: Gain Heal as a bonus skill. You may attempt to stabilize one mortally-wounded adjacent person per round as an On Turn action. When rolling Heal skill checks, roll 3d6 and drop the lowest die.\nLevel 2: Stims or other technological healing devices applied by you heal twice as many hit points as normal. Using only basic medical supplies, you can heal 1d6+Heal skill hit points of damage to every injured or wounded person in your group with ten minutes of first aid spread among them. Such healing can be applied to a given target only once per day.";

            public const string FocusHenchkeeperName = "Henchkeeper";
            public const string FoucsHenchkeeperDescription = "You have an distinct knack for picking up lost souls who willingly do your bidding. You might induce them with promises of money, power, excitement, sex, or some other prize that you may or may not eventually grant. A henchman obtained with this focus will serve in loyal fashion until clearly betrayed or placed in unacceptable danger. Henchmen are not “important” people in their society, and are usually marginal sorts, outcasts, the desperate, or other persons with few options. You can use more conventional pay or inducements to acquire additional henchmen, but these extra hirelings are no more loyal or competent than your pay and treatment can purchase.\nLevel 1: Gain Lead as a bonus skill. You can acquire henchmen within 24 hours of arriving in a community, assuming anyone is suitable hench material. These henchmen will not fight except to save their own lives, but will escort you on adventures and risk great danger to help you. Most henchmen will be treated as Peaceful Humans from the Xenobestiary section of the book. You can have one henchmen at a time for every three character levels you have, rounded up. You can release henchmen with no hard feelings at any plausible time and pick them back up later should you be without a current henchman.\nLevel 2: Your henchmen are remarkably loyal and determined, and will fight for you against anything but clearly overwhelming odds. Whether through natural competence or their devotion to you, they’re treated as Martial Humans from the Xenobestiary section. You can make faithful henchmen out of skilled and highly-capable NPCs, but this requires that you actually have done them some favor or help that would reasonably earn such fierce loyalty.";

            public const string FocusIronhideName = "Ironhide";
            public const string FoucsIronhideDescription = "Whether through uncanny reflexes, remarkable luck, gengineered skin fibers, or subtle telekinetic shielding, you have natural defenses equivalent to high-quality combat armor. The benefits of this focus don’t stack with armor, though Dexterity or shield modifiers apply.\nLevel 1: You have an innate Armor Class of 15 plus half your character level, rounded up.\nLevel 2: Your abilities are so effective that they render you immune to unarmed attacks or primitive weaponry as if you wore powered armor.";

            public const string FocusPsychicTrainingName = "Psychic Training";
            public const string FoucsPsychicTrainingDescription = "You’ve had special training in a particular psychic discipline. You must be a Psychic or have taken the Partial Psychic class option as an Adventurer to pick this focus. In the latter case, you can only take training in the discipline you initially chose as a Partial Psychic. As with most foci, this focus can be taken only once.\nLevel 1: Gain any psychic skill as a bonus. If this improves it to level-1 proficiency, choose a free level-1 technique from that discipline. Your maximum Effort increases by one.\nLevel 2: When you advance a level, the bonus psychic skill you chose for the first level of the focus automatically gets one skill point put toward increasing it or purchasing a technique from it. You may save these points for later, if more are required to raise the skill or buy a particular technique. These points are awarded retroactively if you take this focus level later in the game.";

            public const string FocusSavageFrayName = "Savage Fray";
            public const string FoucsSavageFrayDescription = "You are a whirlwind of bloody havoc in melee combat, and can survive being surrounded far better than most combatants.\nGain Stab as a bonus skill. All enemies adjacent to you at the end of your turn whom you have not attacked suffer the Shock damage of your weapon if their Armor Class is not too high to be affected.\nLevel 2: After suffering your first melee hit in a round, any further melee attacks from other assailants automatically miss you. If the attacker who hits you has multiple attacks, they may attempt all of them, but other foes around you simply miss.";

            public const string FocusShockingAssaultName = "Shocking Assault";
            public const string FoucsShockingAssaultDescription = "You’re extremely dangerous to enemies around you. The ferocity of your melee attacks stresses and distracts enemies even when your blows don’t draw blood.\nLevel 1: Gain Punch or Stab as a bonus skill. The Shock damage of your weapon treats all targets as if they were AC 10, assuming your weapon is capable of harming the target in the first place.\nLevel 2: In addition, you gain a +2 bonus to the Shock damage rating of all melee weapons and unarmed attacks. Regular hits never do less damage than this Shock would do on a miss.";

            public const string FocusSniperName = "Sniper";
            public const string FoucsSniperDescription = "You are an expert at placing a bullet or beam on an unsuspecting target. These special benefits only apply when making an Execution Attack with a firearm or bow, as described on page 52.\nLevel 1: Gain Shoot as a bonus skill. When making a skill check for an Execution Attack or target shooting, roll 3d6 and drop the lowest die.\nLevel 2: A target hit by your Execution Attack takes a -4 penalty on the Physical saving throw to avoid immediate mortal injury. Even if the save is successful, the target takes double the normal damage inflicted by the attack.";

            public const string FocusSpecialistAdministerName = "Specialist (Administer)";
            public const string FocusSpecialistConnectName = "Specialist (Connect)";
            public const string FocusSpecialistExertName = "Specialist (Exert)";
            public const string FocusSpecialistFixName = "Specialist (Fix)";
            public const string FocusSpecialistHealName = "Specialist (Heal)";
            public const string FocusSpecialistKnowName = "Specialist (Know)";
            public const string FocusSpecialistLeadName = "Specialist (Lead)";
            public const string FocusSpecialistNoticeName = "Specialist (Notice)";
            public const string FocusSpecialistPerformName = "Specialist (Perform)";
            public const string FocusSpecialistPilotName = "Specialist (Pilot)";
            public const string FocusSpecialistProgramName = "Specialist (Program)";
            public const string FocusSpecialistSneakName = "Specialist (Sneak)";
            public const string FocusSpecialistSurviveName = "Specialist (Survive)";
            public const string FocusSpecialistTalkName = "Specialist (Talk)";
            public const string FocusSpecialistTradeName = "Specialist (Trade)";
            public const string FocusSpecialistWorkName = "Specialist (Work)";
            public const string FoucsSpecialistDescription = "You are remarkably talented at a particular skill. Whether a marvelous cat burglar, a world-famous athlete, a brilliant engineer, or some other savant, your expertise is extremely reliable. You may take this focus more than once for different skills.\nLevel 1: Gain a non-combat, non-psychic skill as a bonus. Roll 3d6 and drop the lowest die for all skill checks in this skill.\nLevel 2: Roll 4d6 and drop the two lowest dice for all skill checks in this skill.";

            public const string FocusStarCaptainName = "Star Captain";
            public const string FoucsStarCaptainDescription = "You have a tremendous natural talent for ship combat, and can make any starship you captain a significantly more fearsome opponent. You must take the captain’s role during a fight as described on page 117 of the Ship Combat rules in order to benefit from this focus.\nLevel 1: Gain Lead as a bonus skill. Your ship gains 2 extra Command Points at the start of each turn.\nLevel 2: A ship you captain gains bonus hit points equal to 20% of its maximum at the start of each combat. Damage is taken from these bonus points first, and they vanish at the end of the fight and do not require repairs to replenish before the next. In addition, once per engagement, you may resolve a Crisis as an Instant action by explaining how your leadership resolves the problem.";

            public const string FocusStarfarerName = "Starfarer";
            public const string FoucsStarfarerDescription = "You are an expert in the plotting and execution of interstellar spike drills. While most experienced pilots can manage conventional drills along well-charted spike routes, you have the knack for forging new drill paths and cutting courses too dangerous for lesser navigators.\nLevel 1: Gain Pilot as a bonus skill. You automatically succeed at all spike drill-related skill checks of difficulty 10 or less.\nLevel 2: Double your Pilot skill for all spike drill-related skill checks. Spike drives of ships you navigate are treated as one level higher; thus, a drive-1 is treated as a drive-2, up to a maximum of drive-7. Spike drills you personally oversee take only half the time they would otherwise require.";

            public const string FocusTinkerName = "Tinker";
            public const string FoucsTinkerDescription = "You have a natural knack for modifying and improving equipment, as given in the rules on page 100.\nLevel 1: Gain Fix as a bonus skill. Your Maintenance score is doubled, allowing you to maintain twice as many mods. Both ship and gear mods cost only half their usual price in credits, though pretech salvage requirements remain the same.\nLevel 2: Your Fix skill is treated as one level higher for purposes of building and maintaining mods and calculating your Maintenance score. Advanced mods require one fewer pretech salvage part to make, down to a minimum of zero.";

            public const string FocusUnarmedCombatantName = "Unarmed Combatant";
            public const string FoucsUnarmedCombatantDescription = "Your empty hands are more dangerous than knives and guns in the grip of the less gifted. Your unarmed attacks are counted as melee weapons when it comes to binding up opponents wielding rifles and similar long arms, though you need at least one hand free to do so.\nLevel 1: Gain Punch as a bonus skill. Your unarmed attacks become more dangerous as your Punch skill increases. At level-0, they do 1d6 damage. At level-1, they do 1d8 damage. At level-2 they do 1d10, level-3 does 1d12, and level-4 does 1d12+1. At Punch-1 or better, they have the Shock quality equal to your Punch skill against AC 15 or less. While you normally add your Punch skill level to any unarmed damage, don’t add it twice to this Shock damage.\nLevel 2: You know locks and twists that use powered servos against their wearer. Your unarmed attacks count as TL4 weapons for the purpose of overcoming advanced armors. Even on a miss with a Punch attack, you do an unmodified 1d6 damage.";

            public const string FocusUniqueGiftName = "Unique Gift";
            public const string FoucsUniqueGiftDescription = "Whether due to exotic technological augmentation, a unique transhuman background, or a remarkable human talent, you have the ability to do something that’s simply impossible for a normal human. This is a special focus which serves as a catch-all for some novel power or background perk that doesn’t have a convenient fit in the existing rules.A transhuman who can function normally in lethal environments, a nanotech-laden experimental subject with a head full of exotic sensors, or a brilliant gravitic scientist who can fly thanks to their personal tech might all take this focus to cover their special abilities. It’s up to the GM to decide what’s reasonable and fair to be covered under this gift.If an ability is particularly powerful, it might require the user to take System Strain to use it, as described on page 32. As a general rule this ability should be better than a piece of gear the PC could buy for credits.The player is spending a very limited resource when they make this focus pick, so what they get should be good enough that they can’t just duplicate it with a fat bank account.";

            public const string FocusWandererName = "Wanderer";
            public const string FoucsWandererDescription = "Your hero gets around. As part of a life on the road, they’ve mastered a number of tricks for ensuring their mobility and surviving the inevitable difficulties of a vagabond existence.\nLevel 1: Gain Survive as a bonus skill. You can convey basic ideas in all the common languages of the sector. You can always find free transport to a desired destination for yourself and a small group of your friends provided any traffic goes to the place. Finding this transport takes no more than an hour, but it may not be a strictly legitimate means of travel and may require working passage.\nLevel 2: You can forge, scrounge, or snag travel papers and identification for the party with 1d6 hours of work. These papers and permits will stand up to ordinary scrutiny, but require an opposed Int/Administer versus Wis/Notice check if examined by an official while the PC is actually wanted by the state for some crime. When finding transport for the party, the transportation always makes the trip at least as fast as a dedicated charter would.";

            public const string FocusWildPsychicTalentName = "Wild Psychic Talent";
            public const string FoucsWildPsychicTalentDescription = "Some men and women are born with a very limited form of MES, the mental condition that allows for the use of psychic powers.While these people are not true psychics, these “wild talents” can create one limited psychic effect. Training is not always required to develop this ability, and their MES is so mild that they don’t suffer the risk of madness or brain damage that more developed psychics risk should they use their powers without proper training. Wild talents are not treated as psychics for general purposes and cannot “torch” their powers. When relevant, they are treated as having one point of Effort. Psychics and Partial Psychics cannot take this focus.\nLevel 1: Pick a psychic discipline. You gain an ability equivalent to the level-0 core power of that discipline.Optionally, you may instead pick a level-1 technique from that discipline, but that technique must stand alone; you can’t pick one that augments another technique or core ability.For example, you could pick the Telekinetic Armory technique from Telekinesis, because that ability does not require the use of any other Telekinesis power. You could not pick the Mastered Succor ability from Biopsionics, because that technique is meant to augment another power you don’t have.\nLevel 2: You now have a maximum Effort of two points. You may pick a second ability according to the guidelines above.This second does not need to be a stand-alone technique if it augments the power first pick was gaining the level-0 power of Psychic Succor, your second could be Mastered Succor. You still could not get the level-1 core power of Psychic Succor, however, as you’re still restricted to level-0.";
        }

        public class Background
        {
            public const int NameMaxLength = 25;

            public const string BarbarianDescription = "Standards of barbarism vary when many worlds are capable of interstellar spaceflight, but your hero comes from a savage world of low technology and high violence.Their planet may have survived an all-consuming war, or been deprived of critical materials or energy resources, or simply have been colonized by confirmed Luddites. Other barbarians might be drawn from the impoverished underclass of advanced worlds or the technologically-degenerate inheritors of some high-tech space station or planetary hab.";
            public const string ClergyDescription = "Faith is nigh-universal among human civilizations, and your hero is dedicated to one such belief.Some clergy are conventional priests or priestesses, while others might be cloistered monastics or nuns, or more martial warrior-monks.Modern-day faiths such as Christianity, Islam, Judaism, Hinduism, Buddhism, and other creeds all exist in various sectors, often in altered form, while some worlds have developed entirely new deities or faiths.If you’d like to create your own religion, you can work with the GM to define its characteristic beliefs.";
            public const string CourtesanDescription = "Your hero’s career was one of proffered pleasure. Simple prostitution is one form of this background, perhaps as an ordinary streetwalker, a part-time amateur with bills to pay, or an expensive companion to the wealthy, but other forms of satisfaction exist among the many worlds. Refined artists of conversation and grace command high fees in some societies, while others pay well for the simple company of certain men and women with the right bloodlines, special appearance, or auspicious personal qualities esteemed by their culture.";
            public const string CriminalDescription = "Whether thief, murderer, forger, smuggler, spy, or some other variety of malefactor, your hero was a criminal. Some such rogues are guilty only of crossing some oppressive government or offending a planetary lord, while others have done things that no civilized society could tolerate. Still, their ability to deal with the most desperate and dangerous of contacts and navigate the perils of a less-than-legal adventure can make them attractive associates for a party of freebooters bent on profit and glory more than strict legality.";
            public const string DilettanteDescription = "Your hero never had a profession, strictly speaking, but spent their formative years in travel, socializing, and a series of engaging hobbies. They might have been the scion of a wealthy industrialist, a planetary noble’s younger offspring, or a hanger-on to someone with the money and influence they lacked. By the time your hero’s adventures start, they’ve run through the money that once fueled their lifestyle. Extreme measures may be necessary to acquire further funding.";
            public const string EntertainerDescription = "Singers, dancers, actors, poets, writers... the interstellar reaches teem with artists of unnumbered styles and mediums, some of which are only physically possible with advanced technological support. Your hero was a dedicated entertainer, one likely focused in a particular form of art. Patrons and talent scouts can be temperamental, however, and sometimes a budding artist needs to take steps to find their audience. Or at least, to find their audience’s money.";
            public const string MerchantDescription = "Your hero was or is a trader. Some merchants are mere peddlers and shopkeepers on primitive, low-tech worlds, while others are daring far traders who venture to distant worlds to bring home their alien treasures. The nature of trade varies widely among worlds. On some of them, it’s a business of soberly-dressed men and women ticking off trades on virtual terminals, while on others it is a more... active pursuit, requiring the judicious application of monoblades and deniable gunfire against competitors. Sometimes a deal goes bad or capital needs to be raised, and a merchant’s natural talents are turned toward the perils of adventure.";
            public const string NobleDescription = "Many planets are ruled by a class of nobles, and your hero was a member of one such exalted group. Such planets are often worlds of exquisite courtesy alloyed with utterly remorseless violence, and a misplaced word at the morning levee can result in an executioner’s monoblade at noon. Your hero has done something or been the victim of something to dislodge them from their comfortable place at court. Without their familiar allies, wealth, or influence, they must take a new place in the world, however distasteful that claiming might be.";
            public const string OfficialDescription = "Most advanced worlds run on their bureaucracies, the legions of faceless men and women who fill unnumbered roles in keeping the government running as it should. Your hero was one such official. Some were law enforcement officers, others government office clerks or tax officials or trade inspectors. However necessary the work may be, it is often of unendurably tedious nature, and any man or woman with an adventurous spark to their blood will soon find themselves desperate for more exciting use of their talents.";
            public const string PeasantDescription = "A technologically-advanced world can usually produce all its necessary foodstuffs and basic resources with a handful of workers, the bulk of the labor being performed by agricultural bots. On more primitive worlds, or those with a natural environment that requires close personal attention to crops, a class of peasants will emerge. These men and women often become chattel, part and parcel of the land they occupy and traded among their betters like the farm equipment of richer worlds. Your hero was not satisfied with that life, and has done something to break free from their muddy and toilsome past.";
            public const string PhysicianDescription = "Bodies wear and break, even on worlds that possess the full resources of advanced postech medicine. Your hero was a physician, one trained to cure the maladies of the body or the afflictions of the mind. Some physicians are conventional health workers, while others are ship’s surgeons, military medics, missionary healers of an expanding faith, or dubious slum doctors who’ll graft over laser burns with no awkward questions asked. Wherever men and women go into danger, however, the skills of a physician are eagerly sought.";
            public const string PilotDescription = "A pilot’s role is a broad one in the far future. The most glamorous and talented navigate starships through the metadimensional storms of interstellar space, while less admired figures fly the innumerable intra-system shuttles and atmosphere craft that serve in most advanced systems. On other worlds, this career might reflect a long-haul trucker, or a horse-riding messenger, or an intrepid sailor on an alien sea. As the Pilot skill covers all these modes of transport, any character whose role revolves around vehicles or riding beasts might justify their selection of this career.";
            public const string PoliticianDescription = "The nature of a political career varies from world to world. On some, it’s much like one we’d recognize, with glad-handing voters, loud rallies, and quiet back room deals with supposed rivals in government. On others, it might involve a great deal more ceremonial combat, appeals to councils of elders, and success at ritual trials. Whatever the details, your hero was a politician in their home culture. Something went wrong, though, and the only way to fix it is to get clear of your constituents for a while and seek some alternative means of advancement.";
            public const string ScholarDescription = "Scientists, sages, and professors all qualify under this career. Your hero was one such, a man or woman with a life dedicated to knowledge and understanding. It might have involved the technical expertise of a metadimensional structures engineer or the sacred memorization of the chronicles of some lostworlder sage-order, but your hero’s life was in learning. Sometimes that learning cannot be found in familiar surroundings, however, and for one reason or another, willing or not, your hero must venture out into the wider world.";
            public const string SoliderDescription = "Whatever the technology or structure of their parent world, a soldier’s work is universal. Your hero was a professional fighter, whether that took the form of a barbarian noble’s thegn, a faceless conscript in a planetary army, or an elite soldier in the service of a megacorp’s private military. Whether it was because they were on the losing side, choosing to leave the service, or being forced to flee a cause they couldn’t fight for, they now find themselves navigating a world where their most salable skill is one that can cause them a great deal of trouble.";
            public const string SpacerDescription = "Almost every advanced world is highly dependent upon the resources that space flight brings them. Some of this work can be automated, but every really important task needs a flexible human operator to oversee the work. Your hero is one such spacer, either a worker who toils in the sky or a native void-born man or woman who has spent their entire life outside of natural gravity. It’s not uncommon for such workers to find better prospects in places where they can breathe without a vacc suit.";
            public const string TechnicianDescription = "Old things break and new things need to be made. Whether a humble lostworlder blacksmith or an erudite astronautic engineer, your hero made a career out of building and mending the fruits of technology. While almost every society has a need for such services, not all of them treat their providers as generously as a technician might wish. Sometimes, these same talents can be turned toward less licit ends, and a skilled technician’s expertise is always useful to an adventuring group that plans to rely on anything more sophisticated than a sharpened stick.";
            public const string ThugDescription = "Your hero was a bruiser. They might have had a notional allegiance to some so-called “army”, or have been part of some crime boss’ strong-arm crew, or simply been a private contractor of misfortune for those who failed to pay up. They might have even been a fist in a righteous cause, defending their neighborhood from hostile outsiders or serving as informal muscle for a local leader in need of protection. Whatever the details, they’ve had to move on from their old life, and their new one is likely to involve a similar application of directed force.";
            public const string VagabondDescription = "A dilettante has money and friends; your hero simply has the road. Whether they were knocked loose from polite society at a young age or have recently found themselves cast out of a familiar life, they now roam the ways of the world and the spaces between. Some heroes find this life satisfying, with its constant novelty and the regular excitement of bare survival. Others long for a more stable arrangement, and are willing to lend their pragmatic talents to a group that offers some prospect of profit.";
            public const string WorkerDescription = "Countless in number, every industrialized world has swarms of workers to operate the machines and perform the labor that keeps society functioning. Cooks, factory laborers, mine workers, personal servants, lawyers, clerks, and innumerable other roles are covered under this career. If your hero rolls or picks Work as a skill but has a career that would better fit another existing skill, they may substitute it accordingly. Thus, a wage-slave programmer might take Program instead of Work, while a lawyer would use Administer instead as a reflection of their litigious talent.";
        }

        public class ClassData
        {
            public const int NameMaxLength = 40;

            public const string ExpertClassName = "Expert";
            public const string ExpertAbility = "•You gain a free level in a non-combat focus related to your background. Most concepts will take Specialist in their main skill, though Diplomat, Starfarer, Healer, or some other focus might suit better. You may not take a combat-oriented focus with this perk. In case of uncertainty, the GM decides whether or not a focus is permitted.\n•Once per scene, you can reroll a failed skill check, taking the new roll if it’s better.\n•When you advance an experience level, you gain a bonus skill point that can be spent on any non-combat, non-psychic skill. You can save this point to spend later if you wish.";
            public const string ExpertDescription = "Your hero is exceptionally good at a useful skill. Doctors, cat burglars, starship pilots, grifters, technicians, or any other concept that focuses on expertise in a non-combat skill should pick the Expert class. Experts are the best at such skills and gain more of them than other classes do. Just as a Warrior can be relied upon to make a shot when the chips are down, an Expert has a knack for succeeding at the moments of greatest importance. Once per scene, an Expert can reroll a failed skill check, taking the new result if it’s better.This benefit can be applied to any skill check, even those that the Expert isn’t specially focused in. Their natural talent bleeds over into everything they do. In their chosen field, however, the Expert is exceptionally gifted. Aside from the free focus level that all PCs get at the start of the game, an Expert can choose an additional level in a non-combat focus related to their background. They can spend both of these levels on the same focus if they wish, thus starting the game with level 2 in that particular knack.";

            public const string PsychicClassName = "Psychic";
            public const string PsychicAbility = "•Unlike Warriors or Experts, you are capable of learning psychic disciplines and their associated techniques.\n•When you pick this class, choose any two psychic skills as bonus skills. You can pick the same one twice to obtain level-1 proficiency in it and a free level-1 technique from that discipline.\n•You have an Effort score, which can be used to fuel psychic abilities. Your maximum Effort is equal to 1 plus your highest psychic skill plus the better of your Wisdom or Constitution modifiers. Even with a penalty, your maximum Effort cannot be lower than 1.";
            public const string PsychicDescription = "Your hero has received training in controlling their natural Metadimensional Extroversion Syndrome, and can wield the psychic powers that come from that strange affliction. Controlling and developing psychic abilities is an extremely demanding process but allows for feats wholly impossible to ordinary men and women. Psychics are extremely rare in the general population. Averages vary with worlds, but most range from one in ten thousand to one in a hundred thousand who have the MES condition that make them amenable to psychic training. Some of these go their entire lives without realizing their capabilities. Others end up exploiting their native abilities without training, almost inevitably ending up seriously brain-damaged or crazed by the effects of unmediated metadimensional energy. Your hero has been fortunate enough to find a psychic academy or other training institution capable of molding and directing these abilities.They may have come to this later in life, or been recruited young by a society that carefully watches for MES symptoms. Some societies deal with their psychics more generously than others. On some worlds, psychic powers are accepted and their possessors can look forward to lucrative and respected employment.On others, fear of these uncanny powers and memories of the horrors of the Scream lead to less welcoming treatment.";

            public const string WarriorClassName = "Warrior";
            public const string WarriorAbility = "•You gain a free level in a combat-related focus associated with your background. The GM decides if a focus qualifies if it’s an ambiguous case.\n•Warriors are lucky in combat. Once per scene, as an Instant ability, you can either choose to negate a successful attack roll against you or turn a missed attack roll you made into a successful hit. You can use this ability after the dice are rolled, but it cannot be used against environmental damage, effects without an attack roll, or hits on a vehicle you’re occupying.\n•You gain two extra maximum hit points at each character level.";
            public const string WarriorDescription = "Whether a hiveworld thug, barbarian lostworlder, gengineered combat hominid, or a natural-born killer wasting their potential in a desk job, your hero has a real talent for inflicting mayhem. Combat in Stars Without Number is extremely dangerous, but your hero has the talents to survive situations that would kill a less martial adventurer. As a gifted purveyor of violence, you get to pick an extra combat-related focus associated with your special brand of havoc.While a character of any class can take these special combat talents, you get this additional pick and a better natural hit bonus than heroes of other classes. Most importantly, however, Warriors have an uncanny gift for making a shot when a hit is desperately needed, or dodging a bullet when their life is on the line.Once per scene, a Warrior can either automatically negate a successful combat hit they just received, taking no damage from it, or else they can turn one of their own missed attack rolls into an automatic hit.This versatility makes Warriors exceptionally dangerous enemies in a one-on-one fight, and significantly more likely to survive the gory chaos of a general melee.";

            public const string ExpertPsychicClassName = "Expert Psychic";
            public const string AdventurerAbilityExpertPsychic = "•You gain a free level in a non-combat focus related to your background. Most concepts will take Specialist, though Diplomat, Starfarer, Healer, or some other focus might suit better. Gain an extra skill point every time you gain a character level which can be spent on any non-psychic, non-combat skill.\n•You are a restricted psychic. Pick one psychic discipline as a bonus skill at level-0. You can improve this skill with foci or skill points gained from advancing a level, but you cannot learn or improve any other psychic skill. Your maximum Effort equals 1 plus this psychic skill’s level plus the best of your Wisdom or Constitution modifiers, down to a minimum of 1.";

            public const string ExpertWarriorClassName = "Expert Warrior";
            public const string AdventurerAbilityExpertWarrior = "•You gain a free level in a non-combat focus related to your background. Most concepts will take Specialist, though Diplomat, Starfarer, Healer, or some other focus might suit better. Gain an extra skill point every time you gain a character level which can be spent on any non-psychic, non-combat skill.\n•You gain a free level in a combat focus related to your background. Gain +1 to your attack bonus at first and fifth levels. Gain 2 extra maximum hit points each level. Thus, at first level, you’d roll 1d6+2 for your maximum hit points. At second, you’d roll 2d6+4, and so forth.";

            public const string PsychicWarriorClassName = "Psychic Warrior";
            public const string AdventurerAbilityPsychicWarrior = "•You are a restricted psychic. Pick one psychic discipline as a bonus skill at level-0. You can improve this skill with foci or skill points gained from advancing a level, but you cannot learn or improve any other psychic skill. Your maximum Effort equals 1 plus this psychic skill’s level plus the best of your Wisdom or Constitution modifiers, down to a minimum of 1.\n•You gain a free level in a combat focus related to your background. Gain +1 to your attack bonus at first and fifth levels. Gain 2 extra maximum hit points each level. Thus, at first level, you’d roll 1d6+2 for your maximum hit points. At second, you’d roll 2d6+4, and so forth.";

            public const string AdventurerDescription = "The Adventurer class is the catch-all for heroes who don’t fit so neatly into the other three categories. Perhaps your mercenary spent her girlhood at a psychic academy, or maybe your combat medic knows more about using a laser rifle than most physicians do. You can use the Adventurer class to customize your hero’s abilities, trading focus for wider versatility. Adventurers split their focus between different spheres, gaining weaker versions of each class’ benefits.For example, an Adventurer who is a psionic warrior-adept might have considerable powers of telekinetic force and a brutal expertise at bare-handed combat, but they won’t have access to the wider psionic potential of an unrestricted Psychic or the death-defying combat luck of a hardened Warrior. To define your Adventurer’s abilities, pick two of the following three partial classes.";
        }

        public class SkillData
        {
            public const int NameMaxLength = 25;

            public const string SkillAdministerName = "Administer";
            public const string SkillAdministerDescription = "Manage an organization, handle paperwork, analyze records, and keep an institution functioning on a daily basis. Roll it for bureaucratic expertise, organizational management, legal knowledge, dealing with government agencies, and understanding how institutions really work.";

            public const string SkillConnectName = "Connect";
            public const string SkillConnectDescription = "Find people who can be helpful to your purposes and get them to cooperate with you. Roll it to make useful connections with others, find people you know, know where to get illicit goods and services, and be familiar with foreign cultures and languages. You can use it in place of Talk for persuading people you find via this skill.";

            public const string SkillExertName = "Exert";
            public const string SkillExertDescription = "Apply trained speed, strength, or stamina in some feat of physical exertion. Roll it to run, jump, lift, swim, climb, throw, and so forth. You can use it as a combat skill when throwing things, though it doesn't qualify as a combat skill for other ends.";

            public const string SkillFixName = "Fix";
            public const string SkillFixDescription = "Create and repair devices both simple and complex. How complex will depend on your character's background; a lostworlder blacksmith is going to need some study time before he's ready to fix that broken fusion reactor, though he can do it eventually. Roll it to fix things, build things, and identify what something is supposed to do.";

            public const string SkillHealName = "Heal";
            public const string SkillHealDescription = "Employ medical and psychological treatment for the injured or disturbed. Roll it to cure diseases, stabilize the critically injured, treat psychological disorders, or diagnose illnesses.";

            public const string SkillKnowName = "Know";
            public const string SkillKnowDescription = "Know facts about academic or scientific fields. Roll it to understand planetary ecologies, remember relevant history, solve science mysteries, and know the basic facts about rare or esoteric topics.";

            public const string SkillLeadName = "Lead";
            public const string SkillLeadDescription = "Convince others to also do whatever it is you're trying to do. Talk might persuade them that following you is smart, but Lead can make them do it even when they think it's a bad idea. Roll it to lead troops in combat, convince others to follow you, or maintain morale and discipline.";

            public const string SkillNoticeName = "Notice";
            public const string SkillNoticeDescription = "Spot anomalies or interesting facts about your environment. Roll it for searching places, detecting ambushes, spotting things, and reading the emotional state of other people.";

            public const string SkillPerformName = "Perform";
            public const string SkillPerformDescription = "Exhibit some performative skill. Roll it to dance, sing, orate, act, or otherwise put on a convincing or emotionally moving performance.";

            public const string SkillPilotName = "Pilot";
            public const string SkillPilotDescription = "Use this skill to pilot vehicles or ride beasts. Roll it to fly spaceships, drive vehicles, ride animals, or tend to basic vehicle repair. This skill doesn’t help you with things entirely outside the scope of your background or experience, though with some practice a PC can expand their expertise.";

            public const string SkillProgramName = "Program";
            public const string SkillProgramDescription = "Operating or hacking computing and communications hardware. Roll it to program or hack computers, control computer-operated hardware, operate communications tech, or decrypt things.";

            public const string SkillPunchName = "Punch";
            public const string SkillPunchDescription = "Use it as a combat skill when fighting unarmed. If your PC means to make a habit of this rather than as a recourse of desperation, you should take the Unarmed Fighter focus described later.";

            public const string SkillShootName = "Shoot";
            public const string SkillShootDescription = "Use it as a combat skill when using ranged weaponry, whether hurled rocks, bows, laser pistols, combat rifles, or ship’s gunnery.";

            public const string SkillSneakName = "Sneak";
            public const string SkillSneakDescription = "Move without drawing notice. Roll it for stealth, disguise, infiltration, manual legerdemain, pickpocketing, and the defeat of security measures.";

            public const string SkillStabName = "Stab";
            public const string SkillStabDescription = "Use it as a combat skill when wielding melee weapons, whether primitive or complex.";

            public const string SkillSurviveName = "Survive";
            public const string SkillSurviveDescription = "Obtain the basics of food, water, and shelter in hostile environments, along with avoiding their natural perils. Roll it to handle animals, navigate difficult terrain, scrounge urban resources, make basic tools, and avoid wild beasts or gangs.";

            public const string SkillTalkName = "Talk";
            public const string SkillTalkDescription = "Convince other people of the facts you want them to believe. What they do with that conviction may not be completely predictable. Roll it to persuade, charm, or deceive others in conversation.";

            public const string SkillTradeName = "Trade";
            public const string SkillTradeDescription = "Find what you need on the market and sell what you have. Roll it to sell or buy things, figure out where to purchase hard-to-get or illicit goods, deal with customs agents, or run a business.";

            public const string SkillWorkName = "Work";
            public const string SkillWorkDescription = "This is a catch-all skill for professions not represented by other skills. Roll it to work at a particular profession, art, or trade.";

            /// <summary>
            /// Psychic Skills
            /// </summary>

            public const string SkillBiopsionicsName = "Biopsionics";
            public const string SkillBiopsionicsDescription = "Master powers of physical repair, body augmentation, and shapeshifting.";

            public const string SkillMetapsionicsName = "Metapsionics";
            public const string SkillMetapsionicsDescription = "Master powers that nullify, boost, and shape the use of other psychic abilities.";

            public const string SkillPrecognitionName = "Precognition";
            public const string SkillPrecognitionDescription = "Master the ability to sense future events and control probability.";

            public const string SkillTelekinesisName = "Telekinesis";
            public const string SkillTelekinesisDescription = "Master the remote control of kinetic energy to move objects and fabricate force constructs.";

            public const string SkillTelepathyName = "Telepathy";
            public const string SkillTelepathyDescription = "Master the reading and influencing of other sapient minds.";

            public const string SkillTeleportationName = "Teleportation";
            public const string SkillTeleportationDescription = "Spot anomalies or interesting facts about your environment. Roll it for searching places, detecting ambushes, spotting things, and reading the emotional state of other people.";
        }

        public class EquipmentData
        {
            //Constants for Equipment Entity
            public const int NameMaxLength = 40;
            public const int TypeMaxLength = 30;

            public const string Ammo20RoundsName = "Ammo, 20 Rounds";
            public const string Ammo20RoundsType = "Ammo and Power";
            public const string Ammo20RoundsDescription = "";
            public const int Ammo20RoundsCost = 10;
            public const int Ammo20RoundsTL = 2;
            public const int Ammo20RoundsEncumbrance = 0;

            public const string AmmoMissileName = "Ammo, Missile";
            public const string AmmoMissileType = "Ammo and Power";
            public const string AmmoMissileDescription = "";
            public const int AmmoMissileCost = 50;
            public const int AmmoMissileTL = 3;
            public const int AmmoMissileEncumbrance = 1;

            public const string PowerCellTypeAName = "Power Cell, Type A";
            public const string PowerCellTypeAType = "Ammo and Power";
            public const string PowerCellTypeADescription = "";
            public const int PowerCellTypeACost = 10;
            public const int PowerCellTypeATL = 4;
            public const int PowerCellTypeAEncumbrance = 0;

            public const string PowerCellTypeBName = "Power Cell, Type B";
            public const string PowerCellTypeBType = "Ammo and Power";
            public const string PowerCellTypeBDescription = "";
            public const int PowerCellTypeBCost = 100;
            public const int PowerCellTypeBTL = 4;
            public const int PowerCellTypeBEncumbrance = 1;

            public const string SolarRechargerName = "Solar Recharger";
            public const string SolarRechargerType = "Ammo and Power";
            public const string SolarRechargerDescription = "";
            public const int SolarRechargerCost = 500;
            public const int SolarRechargerTL = 4;
            public const int SolarRechargerEncumbrance = 3;

            public const string TelekineticGeneratorName = "Telekinetic Generator";
            public const string TelekineticGeneratorType = "Ammo and Power";
            public const string TelekineticGeneratorDescription = "";
            public const int TelekineticGeneratorCost = 250;
            public const int TelekineticGeneratorTL = 4;
            public const int TelekineticGeneratorEncumbrance = 2;

            public const string CommServerName = "Comm Server";
            public const string CommServerType = "Communications";
            public const string CommServerDescription = "";
            public const int CommServerCost = 1000;
            public const int CommServerTL = 4;
            public const int CommServerEncumbrance = 3;

            public const string CompadName = "Compad";
            public const string CompadType = "Communications";
            public const string CompadDescription = "";
            public const int CompadCost = 100;
            public const int CompadTL = 4;
            public const int CompadEncumbrance = 0;

            public const string FieldRadioName = "Field Radio";
            public const string FieldRadioType = "Communications";
            public const string FieldRadioDescription = "";
            public const int FieldRadioCost = 200;
            public const int FieldRadioTL = 4;
            public const int FieldRadioEncumbrance = 1;

            public const string TranslatorTorcName = "Translator Torc";
            public const string TranslatorTorcType = "Communications";
            public const string TranslatorTorcDescription = "";
            public const int TranslatorTorcCost = 200;
            public const int TranslatorTorcTL = 4;
            public const int TranslatorTorcEncumbrance = 0;

            public const string BlackSlabName = "Black Slab";
            public const string BlackSlabType = "Computing Gear";
            public const string BlackSlabDescription = "";
            public const int BlackSlabCost = 10000;
            public const int BlackSlabTL = 4;
            public const int BlackSlabEncumbrance = 1;

            public const string DataPhaseTapName = "Data Phase Tap";
            public const string DataPhaseTapType = "Computing Gear";
            public const string DataPhaseTapDescription = "";
            public const int DataPhaseTapCost = 5000;
            public const int DataPhaseTapTL = 4;
            public const int DataPhaseTapEncumbrance = 1;

            public const string DataProtocolName = "Data Protocol";
            public const string DataProtocolType = "Computing Gear";
            public const string DataProtocolDescription = "";
            public const int DataProtocolCost = 1000;
            public const int DataProtocolTL = 4;
            public const int DataProtocolEncumbrance = 0;

            public const string DataslabName = "Dataslab";
            public const string DataslabType = "Computing Gear";
            public const string DataslabDescription = "";
            public const int DataslabCost = 300;
            public const int DataslabTL = 4;
            public const int DataslabEncumbrance = 1;

            public const string LineShuntName = "Line Shunt";
            public const string LineShuntType = "Computing Gear";
            public const string LineShuntDescription = "";
            public const int LineShuntCost = 100;
            public const int LineShuntTL = 4;
            public const int LineShuntEncumbrance = 0;

            public const string RemoteLinkUnitName = "Remote Link Unit";
            public const string RemoteLinkUnitType = "Computing Gear";
            public const string RemoteLinkUnitDescription = "";
            public const int RemoteLinkUnitCost = 250;
            public const int RemoteLinkUnitTL = 4;
            public const int RemoteLinkUnitEncumbrance = 1;

            public const string StilettoChargeName = "Stiletto Charge";
            public const string StilettoChargeType = "Computing Gear";
            public const string StilettoChargeDescription = "";
            public const int StilettoChargeCost = 0;
            public const int StilettoChargeTL = 5;
            public const int StilettoChargeEncumbrance = 1;

            public const string StorageUnitName = "Storage Unit";
            public const string StorageUnitType = "Computing Gear";
            public const string StorageUnitDescription = "";
            public const int StorageUnitCost = 500;
            public const int StorageUnitTL = 4;
            public const int StorageUnitEncumbrance = 3;

            public const string TightbeamLinkUnitName = "Tightbeam Link Unit";
            public const string TightbeamLinkUnitType = "Computing Gear";
            public const string TightbeamLinkUnitDescription = "";
            public const int TightbeamLinkUnitCost = 1000;
            public const int TightbeamLinkUnitTL = 4;
            public const int TightbeamLinkUnitEncumbrance = 1;

            public const string AtmofilterName = "Atmofilter";
            public const string AtmofilterType = "Field Equipment";
            public const string AtmofilterDescription = "";
            public const int AtmofilterCost = 100;
            public const int AtmofilterTL = 4;
            public const int AtmofilterEncumbrance = 1;

            public const string BackpackTL0Name = "Backpack, TL 0";
            public const string BackpackTL0Type = "Field Equipment";
            public const string BackpackTL0Description = "";
            public const int BackpackTL0Cost = 5;
            public const int BackpackTL0TL = 0;
            public const int BackpackTL0Encumbrance = 1;

            public const string BackpackTL4Name = "Backpack, TL 4";
            public const string BackpackTL4Type = "Field Equipment";
            public const string BackpackTL4Description = "";
            public const int BackpackTL4Cost = 50;
            public const int BackpackTL4TL = 4;
            public const int BackpackTL4Encumbrance = 0;

            public const string BinocularsTL3Name = "Binoculars, TL 3";
            public const string BinocularsTL3Type = "Field Equipment";
            public const string BinocularsTL3Description = "";
            public const int BinocularsTL3Cost = 20;
            public const int BinocularsTL3TL = 3;
            public const int BinocularsTL3Encumbrance = 1;

            public const string BinocularsTL4Name = "Binoculars, TL 4";
            public const string BinocularsTL4Type = "Field Equipment";
            public const string BinocularsTL4Description = "";
            public const int BinocularsTL4Cost = 200;
            public const int BinocularsTL4TL = 4;
            public const int BinocularsTL4Encumbrance = 1;

            public const string ClimbingHarnessName = "Climbing Harness";
            public const string ClimbingHarnessType = "Field Equipment";
            public const string ClimbingHarnessDescription = "";
            public const int ClimbingHarnessCost = 50;
            public const int ClimbingHarnessTL = 3;
            public const int ClimbingHarnessEncumbrance = 1;

            public const string GlowbugName = "Glowbug";
            public const string GlowbugType = "Field Equipment";
            public const string GlowbugDescription = "";
            public const int GlowbugCost = 5;
            public const int GlowbugTL = 3;
            public const int GlowbugEncumbrance = 0;

            public const string GrapnelLauncherName = "Grapnel Launcher";
            public const string GrapnelLauncherType = "Field Equipment";
            public const string GrapnelLauncherDescription = "";
            public const int GrapnelLauncherCost = 200;
            public const int GrapnelLauncherTL = 3;
            public const int GrapnelLauncherEncumbrance = 1;

            public const string GravChuteTL4Name = "Grav Chute, TL 4";
            public const string GravChuteTL4Type = "Field Equipment";
            public const string GravChuteTL4Description = "";
            public const int GravChuteTL4Cost = 300;
            public const int GravChuteTL4TL = 4;
            public const int GravChuteTL4Encumbrance = 1;

            public const string GravChuteTL5Name = "Grav Chute, TL 5";
            public const string GravChuteTL5Type = "Field Equipment";
            public const string GravChuteTL5Description = "";
            public const int GravChuteTL5Cost = 1000;
            public const int GravChuteTL5TL = 5;
            public const int GravChuteTL5Encumbrance = 1;

            public const string GravHarnessName = "Grav Harness";
            public const string GravHarnessType = "Field Equipment";
            public const string GravHarnessDescription = "";
            public const int GravHarnessCost = 5000;
            public const int GravHarnessTL = 5;
            public const int GravHarnessEncumbrance = 3;

            public const string InstapanelName = "Instapanel";
            public const string InstapanelType = "Field Equipment";
            public const string InstapanelDescription = "";
            public const int InstapanelCost = 50;
            public const int InstapanelTL = 4;
            public const int InstapanelEncumbrance = 0;

            public const string LowlightgogglesName = "Lowlight goggles";
            public const string LowlightgogglesType = "Field Equipment";
            public const string LowlightgogglesDescription = "";
            public const int LowlightgogglesCost = 200;
            public const int LowlightgogglesTL = 3;
            public const int LowlightgogglesEncumbrance = 1;

            public const string NavcompName = "Navcomp";
            public const string NavcompType = "Field Equipment";
            public const string NavcompDescription = "";
            public const int NavcompCost = 500;
            public const int NavcompTL = 4;
            public const int NavcompEncumbrance = 1;

            public const string PortaboxName = "Portabox";
            public const string PortaboxType = "Field Equipment";
            public const string PortaboxDescription = "";
            public const int PortaboxCost = 50;
            public const int PortaboxTL = 4;
            public const int PortaboxEncumbrance = 1;

            public const string PressureTentName = "Pressure Tent";
            public const string PressureTentType = "Field Equipment";
            public const string PressureTentDescription = "";
            public const int PressureTentCost = 100;
            public const int PressureTentTL = 3;
            public const int PressureTentEncumbrance = 4;

            public const string Rations1dayName = "Rations, 1 day";
            public const string Rations1dayType = "Field Equipment";
            public const string Rations1dayDescription = "";
            public const int Rations1dayCost = 5;
            public const int Rations1dayTL = 1;
            public const int Rations1dayEncumbrance = 0;

            public const string RopeTL020metersName = "Rope, TL0, 20 meters";
            public const string RopeTL020metersType = "Field Equipment";
            public const string RopeTL020metersDescription = "";
            public const int RopeTL020metersCost = 4;
            public const int RopeTL020metersTL = 0;
            public const int RopeTL020metersEncumbrance = 2;

            public const string RopeTL420metersName = "Rope, TL4, 20 meters";
            public const string RopeTL420metersType = "Field Equipment";
            public const string RopeTL420metersDescription = "";
            public const int RopeTL420metersCost = 40;
            public const int RopeTL420metersTL = 4;
            public const int RopeTL420metersEncumbrance = 1;

            public const string ScoutReportName = "Scout Report";
            public const string ScoutReportType = "Field Equipment";
            public const string ScoutReportDescription = "";
            public const int ScoutReportCost = 200;
            public const int ScoutReportTL = 4;
            public const int ScoutReportEncumbrance = 0;

            public const string SurveyScannerName = "Survey Scanner";
            public const string SurveyScannerType = "Field Equipment";
            public const string SurveyScannerDescription = "";
            public const int SurveyScannerCost = 250;
            public const int SurveyScannerTL = 4;
            public const int SurveyScannerEncumbrance = 1;

            public const string SurvivalKitName = "Survival Kit";
            public const string SurvivalKitType = "Field Equipment";
            public const string SurvivalKitDescription = "";
            public const int SurvivalKitCost = 60;
            public const int SurvivalKitTL = 4;
            public const int SurvivalKitEncumbrance = 1;

            public const string TelescopingPoleName = "Telescoping Pole";
            public const string TelescopingPoleType = "Field Equipment";
            public const string TelescopingPoleDescription = "";
            public const int TelescopingPoleCost = 10;
            public const int TelescopingPoleTL = 4;
            public const int TelescopingPoleEncumbrance = 0;

            public const string ThermalFlareName = "Thermal Flare";
            public const string ThermalFlareType = "Field Equipment";
            public const string ThermalFlareDescription = "";
            public const int ThermalFlareCost = 5;
            public const int ThermalFlareTL = 3;
            public const int ThermalFlareEncumbrance = 0;

            public const string TradeGoodsName = "Trade Goods";
            public const string TradeGoodsType = "Field Equipment";
            public const string TradeGoodsDescription = "";
            public const int TradeGoodsCost = 50;
            public const int TradeGoodsTL = 4;
            public const int TradeGoodsEncumbrance = 0;

            public const string TradeMetalsName = "Trade Metals";
            public const string TradeMetalsType = "Field Equipment";
            public const string TradeMetalsDescription = "";
            public const int TradeMetalsCost = 10;
            public const int TradeMetalsTL = 4;
            public const int TradeMetalsEncumbrance = 0;

            public const string VaccFresherName = "Vacc Fresher";
            public const string VaccFresherType = "Field Equipment";
            public const string VaccFresherDescription = "";
            public const int VaccFresherCost = 400;
            public const int VaccFresherTL = 4;
            public const int VaccFresherEncumbrance = 1;

            public const string VaccSkinName = "Vacc Skin";
            public const string VaccSkinType = "Field Equipment";
            public const string VaccSkinDescription = "";
            public const int VaccSkinCost = 1000;
            public const int VaccSkinTL = 5;
            public const int VaccSkinEncumbrance = 1;

            public const string VaccSuitName = "Vacc Suit";
            public const string VaccSuitType = "Field Equipment";
            public const string VaccSuitDescription = "";
            public const int VaccSuitCost = 100;
            public const int VaccSuitTL = 4;
            public const int VaccSuitEncumbrance = 2;

            public const string OxygenTankName = "Oxygen Tank";
            public const string OxygenTankType = "Field Equipment";
            public const string OxygenTankDescription = "";
            public const int OxygenTankCost = 0;
            public const int OxygenTankTL = 4;
            public const int OxygenTankEncumbrance = 1;

            public const string BezoarName = "Bezoar";
            public const string BezoarType = "Pharmaceuticals";
            public const string BezoarDescription = "";
            public const int BezoarCost = 200;
            public const int BezoarTL = 4;
            public const int BezoarEncumbrance = 0;

            public const string BrainwaveName = "Brainwave";
            public const string BrainwaveType = "Pharmaceuticals";
            public const string BrainwaveDescription = "";
            public const int BrainwaveCost = 1000;
            public const int BrainwaveTL = 5;
            public const int BrainwaveEncumbrance = 0;

            public const string HushName = "Hush";
            public const string HushType = "Pharmaceuticals";
            public const string HushDescription = "";
            public const int HushCost = 200;
            public const int HushTL = 4;
            public const int HushEncumbrance = 0;

            public const string LiftName = "Lift";
            public const string LiftType = "Pharmaceuticals";
            public const string LiftDescription = "";
            public const int LiftCost = 50;
            public const int LiftTL = 4;
            public const int LiftEncumbrance = 0;

            public const string PsychName = "Psych";
            public const string PsychType = "Pharmaceuticals";
            public const string PsychDescription = "";
            public const int PsychCost = 25;
            public const int PsychTL = 4;
            public const int PsychEncumbrance = 0;

            public const string PretechCosmeticName = "Pretech Cosmetic";
            public const string PretechCosmeticType = "Pharmaceuticals";
            public const string PretechCosmeticDescription = "";
            public const int PretechCosmeticCost = 1000;
            public const int PretechCosmeticTL = 5;
            public const int PretechCosmeticEncumbrance = 0;

            public const string ReverieName = "Reverie";
            public const string ReverieType = "Pharmaceuticals";
            public const string ReverieDescription = "";
            public const int ReverieCost = 100;
            public const int ReverieTL = 4;
            public const int ReverieEncumbrance = 0;

            public const string SquealName = "Squeal";
            public const string SquealType = "Pharmaceuticals";
            public const string SquealDescription = "";
            public const int SquealCost = 300;
            public const int SquealTL = 4;
            public const int SquealEncumbrance = 0;

            public const string TsunamiName = "Tsunami";
            public const string TsunamiType = "Pharmaceuticals";
            public const string TsunamiDescription = "";
            public const int TsunamiCost = 50;
            public const int TsunamiTL = 4;
            public const int TsunamiEncumbrance = 0;

            public const string BiosacannerName = "Biosacanner";
            public const string BiosacannerType = "Tools and Medical";
            public const string BiosacannerDescription = "";
            public const int BiosacannerCost = 300;
            public const int BiosacannerTL = 4;
            public const int BiosacannerEncumbrance = 1;

            public const string LazarusPatchName = "Lazarus Patch";
            public const string LazarusPatchType = "Tools and Medical";
            public const string LazarusPatchDescription = "";
            public const int LazarusPatchCost = 30;
            public const int LazarusPatchTL = 4;
            public const int LazarusPatchEncumbrance = 0;

            public const string MedkitName = "Medkit";
            public const string MedkitType = "Tools and Medical";
            public const string MedkitDescription = "";
            public const int MedkitCost = 100;
            public const int MedkitTL = 4;
            public const int MedkitEncumbrance = 2;

            public const string MetatoolName = "Metatool";
            public const string MetatoolType = "Tools and Medical";
            public const string MetatoolDescription = "";
            public const int MetatoolCost = 200;
            public const int MetatoolTL = 4;
            public const int MetatoolEncumbrance = 1;

            public const string SparePartsName = "Spare Parts";
            public const string SparePartsType = "Tools and Medical";
            public const string SparePartsDescription = "";
            public const int SparePartsCost = 50;
            public const int SparePartsTL = 4;
            public const int SparePartsEncumbrance = 0;

            public const string TailoredAntiallergensName = "Tailored Antiallergens";
            public const string TailoredAntiallergensType = "Tools and Medical";
            public const string TailoredAntiallergensDescription = "";
            public const int TailoredAntiallergensCost = 5;
            public const int TailoredAntiallergensTL = 4;
            public const int TailoredAntiallergensEncumbrance = 0;

            public const string ToolkitPostechName = "Toolkit/Postech";
            public const string ToolkitPostechType = "Tools and Medical";
            public const string ToolkitPostechDescription = "";
            public const int ToolkitPostechCost = 300;
            public const int ToolkitPostechTL = 4;
            public const int ToolkitPostechEncumbrance = 3;

            public const string ToolkitPretechName = "Toolkit/Pretech";
            public const string ToolkitPretechType = "Tools and Medical";
            public const string ToolkitPretechDescription = "";
            public const int ToolkitPretechCost = 1000;
            public const int ToolkitPretechTL = 5;
            public const int ToolkitPretechEncumbrance = 1;

            public const string RutterName = "Rutter";
            public const string RutterType = "Custom";
            public const string RutterDescription = "";
            public const int RutterCost = 1500;
            public const int RutterTL = 4;
            public const int RutterEncumbrance = 0;
        }

        public class ItemData
        {
            //Constants for Item Entities (Melee & Ranged Weapons)
            public const int NameMaxLength = 40;
            public const int TypeMaxLength = 30;
            public const int AttributeMaxLength = 10;
            public const int MagazineMaxLength = 5;
            public const int DamageMaxLength = 5;
        }
        public class ArmorData
        {
            //Constants for Armor Entity
            public const int NameMaxLength = 40;
            public const int TypeMaxLength = 30;
            public const int AttributeMaxLength = 10;

            public const string ShieldName = "Shield";
            public const string ShieldType = "Primitive";
            public const string ShieldDescription = "";
            public const int ShieldAC = 12;
            public const int ShieldCost = 10;
            public const int ShieldTL = 0;
            public const int ShieldEncumbrance = 2;

            public const string LeatherJackName = "Leather Jack";
            public const string LeatherJackType = "Primitive";
            public const string LeatherJackDescription = "";
            public const int LeatherJackAC = 13;
            public const int LeatherJackCost = 10;
            public const int LeatherJackTL = 0;
            public const int LeatherJackEncumbrance = 1;

            public const string ThickHideName = "Thick Hide";
            public const string ThickHideType = "Primitive";
            public const string ThickHideDescription = "";
            public const int ThickHideAC = 13;
            public const int ThickHideCost = 10;
            public const int ThickHideTL = 0;
            public const int ThickHideEncumbrance = 1;

            public const string QuiltedArmorName = "Quilted Armor";
            public const string QuiltedArmorType = "Primitive";
            public const string QuiltedArmorDescription = "";
            public const int QuiltedArmorAC = 13;
            public const int QuiltedArmorCost = 10;
            public const int QuiltedArmorTL = 0;
            public const int QuiltedArmorEncumbrance = 1;

            public const string CuriassName = "Curiass";
            public const string CuriassType = "Primitive";
            public const string CuriassDescription = "";
            public const int CuriassAC = 15;
            public const int CuriassCost = 50;
            public const int CuriassTL = 1;
            public const int CuriassEncumbrance = 1;

            public const string BrigandineName = "Brigandine";
            public const string BrigandineType = "Primitive";
            public const string BrigandineDescription = "";
            public const int BrigandineAC = 15;
            public const int BrigandineCost = 50;
            public const int BrigandineTL = 1;
            public const int BrigandineEncumbrance = 1;

            public const string LinothoraxName = "Linothorax";
            public const string LinothoraxType = "Primitive";
            public const string LinothoraxDescription = "";
            public const int LinothoraxAC = 15;
            public const int LinothoraxCost = 50;
            public const int LinothoraxTL = 1;
            public const int LinothoraxEncumbrance = 1;

            public const string HalfPlateName = "Half-Plate";
            public const string HalfPlateType = "Primitive";
            public const string HalfPlateDescription = "";
            public const int HalfPlateAC = 15;
            public const int HalfPlateCost = 50;
            public const int HalfPlateTL = 1;
            public const int HalfPlateEncumbrance = 1;

            public const string FullPlateName = "Fulll Plate";
            public const string FullPlateType = "Primitive";
            public const string FullPlateDescription = "";
            public const int FullPlateAC = 17;
            public const int FullPlateCost = 100;
            public const int FullPlateTL = 1;
            public const int FullPlateEncumbrance = 2;

            public const string LayeredMailName = "Layered Mail";
            public const string LayeredMailType = "Primitive";
            public const string LayeredMailDescription = "";
            public const int LayeredMailAC = 17;
            public const int LayeredMailCost = 100;
            public const int LayeredMailTL = 1;
            public const int LayeredMailEncumbrance = 2;

            public const string WarpaintName = "Warpaint";
            public const string WarpaintType = "Street";
            public const string WarpaintDescription = "";
            public const int WarpaintAC = 12;
            public const int WarpaintCost = 300;
            public const int WarpaintTL = 4;
            public const int WarpaintEncumbrance = 0;

            public const string ArmoredUndersuitName = "Armored Undersuit";
            public const string ArmoredUndersuitType = "Street";
            public const string ArmoredUndersuitDescription = "";
            public const int ArmoredUndersuitAC = 13;
            public const int ArmoredUndersuitCost = 600;
            public const int ArmoredUndersuitTL = 4;
            public const int ArmoredUndersuitEncumbrance = 0;

            public const string SecureClothingName = "Secure Clothing";
            public const string SecureClothingType = "Street";
            public const string SecureClothingDescription = "";
            public const int SecureClothingAC = 13;
            public const int SecureClothingCost = 300;
            public const int SecureClothingTL = 4;
            public const int SecureClothingEncumbrance = 1;

            public const string ArmoredVaccSuitName = "Armored Vacc Suit";
            public const string ArmoredVaccSuitType = "Street";
            public const string ArmoredVaccSuitDescription = "";
            public const int ArmoredVaccSuitAC = 13;
            public const int ArmoredVaccSuitCost = 400;
            public const int ArmoredVaccSuitTL = 4;
            public const int ArmoredVaccSuitEncumbrance = 2;

            public const string DeflectorArrayName = "Deflector Array";
            public const string DeflectorArrayType = "Street";
            public const string DeflectorArrayDescription = "";
            public const int DeflectorArrayAC = 18;
            public const int DeflectorArrayCost = 30000;
            public const int DeflectorArrayTL = 5;
            public const int DeflectorArrayEncumbrance = 0;

            public const string ForcePavisName = "Force Pavis";
            public const string ForcePavisType = "Combat";
            public const string ForcePavisDescription = "";
            public const int ForcePavisAC = 14;
            public const int ForcePavisCost = 10000;
            public const int ForcePavisTL = 5;
            public const int ForcePavisEncumbrance = 1;

            public const string SecurityArmorName = "Security Armor";
            public const string SecurityArmorType = "Combat";
            public const string SecurityArmorDescription = "";
            public const int SecurityArmorAC = 14;
            public const int SecurityArmorCost = 700;
            public const int SecurityArmorTL = 4;
            public const int SecurityArmorEncumbrance = 1;

            public const string WovenBodyArmorName = "Woven Body Armor";
            public const string WovenBodyArmorType = "Combat";
            public const string WovenBodyArmorDescription = "";
            public const int WovenBodyArmorAC = 15;
            public const int WovenBodyArmorCost = 400;
            public const int WovenBodyArmorTL = 3;
            public const int WovenBodyArmorEncumbrance = 2;

            public const string CombatFieldUniformName = "Combat Field Uniform";
            public const string CombatFieldUniformType = "Combat";
            public const string CombatFieldUniformDescription = "";
            public const int CombatFieldUniformAC = 16;
            public const int CombatFieldUniformCost = 1000;
            public const int CombatFieldUniformTL = 4;
            public const int CombatFieldUniformEncumbrance = 1;

            public const string IcarusHarnessName = "Icarus Harness";
            public const string IcarusHarnessType = "Combat";
            public const string IcarusHarnessDescription = "";
            public const int IcarusHarnessAC = 16;
            public const int IcarusHarnessCost = 8000;
            public const int IcarusHarnessTL = 4;
            public const int IcarusHarnessEncumbrance = 1;

            public const string VestimentumName = "Vestimentum";
            public const string VestimentumType = "Powered";
            public const string VestimentumDescription = "";
            public const int VestimentumAC = 18;
            public const int VestimentumCost = 15000;
            public const int VestimentumTL = 5;
            public const int VestimentumEncumbrance = 0;

            public const string AssaultSuitName = "Assault Suit";
            public const string AssaultSuitType = "Powered";
            public const string AssaultSuitDescription = "";
            public const int AssaultSuitAC = 18;
            public const int AssaultSuitCost = 10000;
            public const int AssaultSuitTL = 4;
            public const int AssaultSuitEncumbrance = 2;

            public const string StormArmorName = "Storm Armor";
            public const string StormArmorType = "Powered";
            public const string StormArmorDescription = "";
            public const int StormArmorAC = 19;
            public const int StormArmorCost = 20000;
            public const int StormArmorTL = 5;
            public const int StormArmorEncumbrance = 2;

            public const string FieldEmitterPanoplyName = "Field Emitter Panoply";
            public const string FieldEmitterPanoplyType = "Powered";
            public const string FieldEmitterPanoplyDescription = "";
            public const int FieldEmitterPanoplyAC = 20;
            public const int FieldEmitterPanoplyCost = 40000;
            public const int FieldEmitterPanoplyTL = 5;
            public const int FieldEmitterPanoplyEncumbrance = 1;

            public const string ArmorVaccSuitName = "Vacc Suit";
            public const string ArmorVaccSuitType = "Equipment";
            public const string ArmorVaccSuitDescription = "";
            public const int ArmorVaccSuitAC = 13;
            public const int ArmorVaccSuitCost = 100;
            public const int ArmorVaccSuitTL = 4;
            public const int ArmorVaccSuitEncumbrance = 2;
        }

        public class ContactData
        {
            public const int NameMaxLength = 50;
        }

        public class CharacterData
        {
            public const int NameMaxLength = 30;
            public const int SpeciesMaxLength = 20;
            public const int HomeworldMaxLength = 20;
            public const int EncumbranceMaxLength = 25;
        }
    }
}
