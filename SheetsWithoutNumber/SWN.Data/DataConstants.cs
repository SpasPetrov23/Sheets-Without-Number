﻿namespace SWN.Data
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

        public class ItemData
        {
            //Constants for Item Entities (Equipment, Armor, Melee & Ranged Weapons, Item Locations)
            public const int NameMaxLength = 40;
            public const int TypeMaxLength = 30;
            public const int AttributeMaxLength = 10;
            public const int MagazineMaxLength = 5;
            public const int DamageMaxLength = 5;
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
