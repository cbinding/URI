/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_SCHEMA 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_SCHEMA} from "./URI_SCHEMA.js"
        console.log(URI_SCHEMA.PERSON) | console.log(URI_SCHEMA["PERSON"])
        # both return "http://schema.org/Person"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://schema.org/"
export const URI_SCHEMA = Object.freeze({
    // entities (top level only)
    ACTION: `${NS}Action`,
    BROADCASTSERVICE: `${NS}BroadcastService`,
    CREATIVEWORK: `${NS}CreativeWork`,
    EVENT: `${NS}Event`,
    INTANGIBLE: `${NS}Intangible`,
    MEDICALENTITY: `${NS}MedicalEntity`,
    ORGANIZATION: `${NS}Organization`,
    PERSON: `${NS}Person`,
    PLACE: `${NS}Place`,
    PRODUCT: `${NS}Product`,
    THING: `${NS}Thing`,
    // properties (of top level entities only)
    ABOUT: `${NS}about`,
    ACCESSIBILITYAPI: `${NS}accessibilityAPI`,
    ACCESSIBILITYCONTROL: `${NS}accessibilityControl`,
    ACCESSIBILITYFEATURE: `${NS}accessibilityFeature`,
    ACCESSIBILITYHAZARD: `${NS}accessibilityHazard`,
    ACCOUNTABLEPERSON: `${NS}accountablePerson`,
    ACTIONSTATUS: `${NS}actionStatus`,
    ADDITIONALNAME: `${NS}additionalName`,
    ADDITIONALTYPE: `${NS}additionalType`,
    ADDRESS: `${NS}address`,
    AFFILIATION: `${NS}affiliation`,
    AGENT: `${NS}agent`,
    AGGREGATERATING: `${NS}aggregateRating`,
    ALTERNATIVEHEADLINE: `${NS}alternativeHeadline`,
    ALTERNATENAME: `${NS}alternateName`,
    ALUMNIOF: `${NS}alumniOf`,
    AREA: `${NS}area`,
    ASSOCIATEDMEDIA: `${NS}associatedMedia`,
    ATTENDEE: `${NS}attendee`,
    AUDIENCE: `${NS}audience`,
    AUDIO: `${NS}audio`,
    AUTHOR: `${NS}author`,
    AWARD: `${NS}award`,
    BIRTHDATE: `${NS}birthDate`,
    BIRTHPLACE: `${NS}birthPlace`,
    BRAND: `${NS}brand`,
    BROADCASTER: `${NS}broadcaster`,
    CATEGORY: `${NS}category`,
    CHARACTER: `${NS}character`,
    CHARACTERATTRIBUTE: `${NS}characterAttribute`,
    CHILDREN: `${NS}children`,
    CITATION: `${NS}citation`,
    CODE: `${NS}code`,
    COLLEAGUE: `${NS}colleague`,
    COLLECTION: `${NS}collection`,
    COLOR: `${NS}color`,
    COMMENT: `${NS}comment`,
    COMMENTCOUNT: `${NS}commentCount`,
    CONTACTPOINT: `${NS}contactPoint`,
    CONTAINEDIN: `${NS}containedIn`,
    CONTENTLOCATION: `${NS}contentLocation`,
    CONTENTRATING: `${NS}contentRating`,
    CONTRIBUTOR: `${NS}contributor`,
    COPYRIGHTHOLDER: `${NS}copyrightHolder`,
    COPYRIGHTYEAR: `${NS}copyrightYear`,
    CREATOR: `${NS}creator`,
    DATECREATED: `${NS}dateCreated`,
    DATEMODIFIED: `${NS}dateModified`,
    DATEPUBLISHED: `${NS}datePublished`,
    DEATHDATE: `${NS}deathDate`,
    DEATHPLACE: `${NS}deathPlace`,
    DEFAULTVALUE: `${NS}defaultValue`,
    DEPARTMENT: `${NS}department`,
    DEPTH: `${NS}depth`,
    DESCRIPTION: `${NS}description`,
    DISCUSSIONURL: `${NS}discussionUrl`,
    DISSOLUTIONDATE: `${NS}dissolutionDate`,
    DOORTIME: `${NS}doorTime`,
    DUNS: `${NS}duns`,
    DURATION: `${NS}duration`,
    EDITOR: `${NS}editor`,
    EDUCATIONALALIGNMENT: `${NS}educationalAlignment`,
    EDUCATIONALUSE: `${NS}educationalUse`,
    ENCODING: `${NS}encoding`,
    ENDDATE: `${NS}endDate`,
    ENDTIME: `${NS}endTime`,
    EMAIL: `${NS}email`,
    EMPLOYEE: `${NS}employee`,
    ERROR: `${NS}error`,
    EVENTSTATUS: `${NS}eventStatus`,
    EXAMPLEOFWORK: `${NS}exampleOfWork`,
    FAMILYNAME: `${NS}familyName`,
    FAXNUMBER: `${NS}faxNumber`,
    FIRSTPERFORMANCE: `${NS}firstPerformance`,
    FOLLOWS: `${NS}follows`,
    FOUNDER: `${NS}founder`,
    FOUNDINGDATE: `${NS}foundingDate`,
    FOUNDINGLOCATION: `${NS}foundingLocation`,
    GAMEITEM: `${NS}gameItem`,
    GAMEPLATFORM: `${NS}gamePlatform`,
    GENRE: `${NS}genre`,
    GENDER: `${NS}gender`,
    GEO: `${NS}geo`,
    GIVENNAME: `${NS}givenName`,   
    GLOBALLOCATIONNUMBER: `${NS}globalLocationNumber`,
    GTIN13: `${NS}gtin13`,
    GTIN14: `${NS}gtin14`,
    GTIN8: `${NS}gtin8`,
    GUIDELINE: `${NS}guideline`,
    HASMAP: `${NS}hasMap`,
    HASPART: `${NS}hasPart`,
    HASPOS: `${NS}hasPOS`,
    HEADLINE: `${NS}headline`,
    HEIGHT: `${NS}height`,
    HOMELOCATION: `${NS}homeLocation`,
    HONORIFICPREFIX: `${NS}honorificPrefix`,
    HONORIFICSUFFIX: `${NS}honorificSuffix`,
    IMAGE: `${NS}image`,
    INLANGUAGE: `${NS}inLanguage`,
    INSTRUMENT: `${NS}instrument`,
    INTERACTIONCOUNT: `${NS}interactionCount`,
    INTERACTIVITYTYPE: `${NS}interactivityType`,
    ISACCESSORYORSPAREPARTFOR: `${NS}isAccessoryOrSparePartFor`,
    ISBASEDONURL: `${NS}isBasedOnUrl`,
    ISCONSUMABLEFOR: `${NS}isConsumableFor`,
    ISFAMILYFRIENDLY: `${NS}isFamilyFriendly`,    
    ISICV4: `${NS}isicV4`,
    ISPARTOF: `${NS}isPartOf`,
    ISRELATEDTO: `${NS}isRelatedTo`,
    ISSIMILARTO: `${NS}isSimilarTo`,
    ITEM: `${NS}item`,
    ITEMCONDITION: `${NS}itemCondition`,
    ITEMLISTELEMENT: `${NS}itemListElement`,
    ITEMREVIEWED: `${NS}itemReviewed`,
    JOBTITLE: `${NS}jobTitle`,
    KEYWORDS: `${NS}keywords`,
    KNOWS: `${NS}knows`,
    LEARNINGRESOURCETYPE: `${NS}learningResourceType`,
    LEGALNAME: `${NS}legalName`,
    LICENSE: `${NS}license`,
    LOCATION: `${NS}location`,
    LOGO: `${NS}logo`,
    MAKESOFFER: `${NS}makesOffer`,
    MANUFACTURER: `${NS}manufacturer`,
    MEDICINESYSTEM: `${NS}medicineSystem`,
    MEMBER: `${NS}member`,
    MEMBEROF: `${NS}memberOf`,
    MENTIONS: `${NS}mentions`,
    MODEL: `${NS}model`,
    MPN: `${NS}mpn`,
    NAICS: `${NS}naics`,
    NAME: `${NS}name`,
    NATIONALITY: `${NS}nationality`,
    NETWORTH: `${NS}netWorth`,
    OBJECT: `${NS}object`,
    OFFERS: `${NS}offers`,
    OPENINGHOURSSPECIFICATION: `${NS}openingHoursSpecification`,
    OPTION: `${NS}option`,
    ORGANIZER: `${NS}organizer`,
    OWNS: `${NS}owns`,
    PARENT: `${NS}parent`,
    PARENTSERVICE: `${NS}parentService`,
    PARTICIPANT: `${NS}participant`,
    PERFORMER: `${NS}performer`,
    PERFORMERIN: `${NS}performerIn`,
    PHOTO: `${NS}photo`,
    POSITION: `${NS}position`,
    POTENTIALACTION: `${NS}potentialAction`,
    PREVIOUSSTARTDATE: `${NS}previousStartDate`,
    PRODUCER: `${NS}producer`,
    PRODUCES: `${NS}produces`,
    PRODUCTID: `${NS}productID`,
    PROGRAMMINGLANGUAGE: `${NS}programmingLanguage`,
    PROVIDER: `${NS}provider`,
    PUBLISHEDON: `${NS}publishedOn`,
    PUBLISHER: `${NS}publisher`,
    PUBLISHINGPRINCIPLES: `${NS}publishingPrinciples`,
    PURPOSE: `${NS}purpose`,
    QUEST: `${NS}quest`,
    RECOGNIZINGAUTHORITY: `${NS}recognizingAuthority`,
    RECORDEDAT: `${NS}recordedAt`,
    RECORDEDIN: `${NS}recordedIn`,
    RELATEDTO: `${NS}relatedTo`,
    RELEASEDATE: `${NS}releaseDate`,
    RELEASEDEVENT: `${NS}releasedEvent`,
    RELEVANTSPECIALTY: `${NS}relevantSpecialty`,
    REPLACEE: `${NS}replacee`,
    REPLACER: `${NS}replacer`,
    REVIEW: `${NS}review`,
    RESERVATIONFOR: `${NS}reservationFor`,
    RESULT: `${NS}result`,
    SAMEAS: `${NS}sameAs`,
    SEEKS: `${NS}seeks`,
    SIBLING: `${NS}sibling`,
    SKU: `${NS}sku`,
    SOURCEORGANIZATION: `${NS}sourceOrganization`,
    SPOUSE: `${NS}spouse`,
    STARTDATE: `${NS}startDate`,
    STARTTIME: `${NS}startTime`,
    STUDY: `${NS}study`,
    SUBEVENT: `${NS}subEvent`,
    SUBORGANIZATION: `${NS}subOrganization`,
    SUPEREVENT: `${NS}superEvent`,
    TARGET: `${NS}target`,
    TAXID: `${NS}taxID`,
    TELEPHONE: `${NS}telephone`,
    TEXT: `${NS}text`,
    THUMBNAILURL: `${NS}thumbnailUrl`,
    TIMEREQUIRED: `${NS}timeRequired`,
    TRANSLATOR: `${NS}translator`,
    TYPICALAGERANGE: `${NS}typicalAgeRange`,
    URL: `${NS}url`,
    VATID: `${NS}vatID`,
    VERSION: `${NS}version`,
    VIDEO: `${NS}video`,
    WEIGHT: `${NS}weight`,
    WIDTH: `${NS}width`,
    WORKEXAMPLE: `${NS}workExample`,
    WORKLOCATION: `${NS}workLocation`,
    WORKPERFORMED: `${NS}workPerformed`,
    WORKSFOR: `${NS}worksFor`
})