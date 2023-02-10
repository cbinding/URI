/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_FOAF 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_FOAF} from "./URI_FOAF.js"
        console.log(URI_FOAF.PERSON) | console.log(URI_FOAF["PERSON"])
        # both return "http://xmlns.com/foaf/0.1/Person"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://xmlns.com/foaf/0.1/" 
export const URI_FOAF = Object.freeze({
    // entities / classes
    AGENT: `${NS}Agent`,
    DOCUMENT: `${NS}Document`,
    GROUP: `${NS}Group`,
    IMAGE: `${NS}Image`,
    ONLINEACCOUNT: `${NS}OnlineAccount`,
    ORGANIZATION: `${NS}Organization`,
    PERSON: `${NS}Person`,
    PERSONALPROFILEDOCUMENT: `${NS}PersonalProfileDocument`,
    PROJECT: `${NS}Project`,    
    // properties
    ACCOUNT: `${NS}account`,
    ACCOUNTNAME: `${NS}accountName`,
    ACCOUNTSERVICEHOMEPAGE: `${NS}accountServiceHomepage`,
    AGE: `${NS}age`,
    BASEDNEAR: `${NS}basedNear`,
    CURRENTPROJECT: `${NS}currentProject`,
    DEPICTION: `${NS}depiction`,
    DEPICTS: `${NS}depicts`,
    FAMILYNAME: `${NS}familyName`,
    GIVENNAME: `${NS}givenName`,
    HOMEPAGE: `${NS}homePage`,
    IMG: `${NS}img`,
    INTEREST: `${NS}interest`,
    ISPRIMARYTOPICOF: `${NS}isPrimaryTopicOf`,
    JABBERID: `${NS}jabberID`,
    KNOWS: `${NS}knows`,
    LOGO: `${NS}logo`,
    MADE: `${NS}made`,
    MAKER: `${NS}maker`,
    MBOX: `${NS}mbox`,
    MBOXSHA1SUM: `${NS}mbox_sha1sum`,
    MEMBER: `${NS}member`,
    NAME: `${NS}name`,
    NICK: `${NS}nick`,
    OPENID: `${NS}openid`,
    PAGE: `${NS}page`,
    PASTPROJECT: `${NS}pastProject`,
    PRIMARYTOPIC: `${NS}primaryTopic`,
    PUBLICATIONS: `${NS}publications`,
    SCHOOLHOMEPAGE: `${NS}schoolHomepage`,
    SHA1: `${NS}sha1`,
    THUMBNAIL: `${NS}thumbnail`,
    TIPJAR: `${NS}tipjar`,
    TITLE: `${NS}title`,
    TOPIC: `${NS}topic`,
    TOPICINTEREST: `${NS}topic_interest`,
    WEBLOG: `${NS}weblog`,
    WORKINFOHOMEPAGE: `${NS}workInfoHomepage`,
    WORKPLACEHOMEPAGE: `${NS}workplaceHomepage`
})