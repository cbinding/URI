/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_SKOS 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_SKOS} from "./URI_SKOS.js"
        console.log(URI_SKOS.ALTLABEL) | console.log(URI_SKOS["ALTLABEL"])
        # both return "http://www.w3.org/2004/02/skos/core#altLabel"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/   
const NS = "http://www.w3.org/2004/02/skos/core#"
export const URI_SKOS = Object.freeze({
    // entities
    COLLECTABLEPROPERTY: `${NS}CollectableProperty`,
    COLLECTION: `${NS}Collection`,
    CONCEPT: `${NS}Concept`,
    CONCEPTSCHEME: `${NS}ConceptScheme`,
    ORDEREDCOLLECTION: `${NS}OrderedCollection`,
    // properties
    ALTLABEL: `${NS}altLabel`,
    ALTSYMBOL: `${NS}altSymbol`,
    BROADER: `${NS}broader`,
    CHANGENOTE: `${NS}changeNote`,
    DEFINITION: `${NS}definition`,
    EDITORIALNOTE: `${NS}editorialNote`,
    EXAMPLE: `${NS}example`,
    HASTOPCONCEPT: `${NS}hasTopConcept`,
    HIDDENLABEL: `${NS}hiddenLabel`,
    HISTORYNOTE: `${NS}historyNote`,
    INSCHEME: `${NS}inScheme`,
    ISPRIMARYSUBJECTOF: `${NS}isPrimarySubjectOf`,
    ISSUBJECTOF: `${NS}isSubjectOf`,
    MEMBER: `${NS}member`,
    MEMBERLIST: `${NS}memberList`,
    NARROWER: `${NS}narrower`,
    NOTE: `${NS}note`,
    PREFLABEL: `${NS}prefLabel`,
    PREFSYMBOL: `${NS}prefSymbol`,
    PRIMARYSUBJECT: `${NS}primarySubject`,
    RELATED: `${NS}related`,
    SCOPENOTE: `${NS}scopeNote`,
    SEMANTICRELATION: `${NS}semanticRelation`,
    SUBJECT: `${NS}subject`,
    SUBJECTINDICATOR: `${NS}subjectIndicator`,
    SYMBOL: `${NS}symbol`,
    // mapping properties
    BROADMATCH: `${NS}broadMatch`,
    CLOSEMATCH: `${NS}closeMatch`,
    EXACTMATCH: `${NS}exactMatch`,
    NARROWMATCH: `${NS}narrowMatch`,
    RELATEDMATCH: `${NS}relatedMatch`
})