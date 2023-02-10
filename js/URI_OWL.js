/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_OWL 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_OWL} from "./URI_OWL.js"
        console.log(URI_OWL.CLASS) | console.log(URI_OWL["CLASS"])
        # both return "http://www.w3.org/2002/07/owl#Class"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
==============================================================================
*/
const NS = "http://www.w3.org/2002/07/owl#"
export const URI_OWL = Object.freeze({
    // entities
    ALLDIFFERENT: `${NS}AllDifferent`,
    ANNOTATIONPROPERTY: `${NS}AnnotationProperty`,
    CLASS: `${NS}Class`,
    DATARANGE: `${NS}DataRange`,
    DATATYPEPROPERTY: `${NS}DatatypeProperty`,
    DEPRECATEDCLASS: `${NS}DeprecatedClass`,
    DEPRECATEDPROPERTY: `${NS}DeprecatedProperty`,
    FUNCTIONALPROPERTY: `${NS}FunctionalProperty`,
    INVERSEFUNCTIONALPROPERTY: `${NS}InverseFunctionalProperty`,
    NOTHING: `${NS}Nothing`,
    OBJECTPROPERTY: `${NS}ObjectProperty`,
    ONTOLOGY: `${NS}Ontology`,
    ONTOLOGYPROPERTY: `${NS}OntologyProperty`,
    RESTRICTION: `${NS}Restriction`,
    SYMMETRICPROPERTY: `${NS}SymmetricProperty`,
    THING: `${NS}Thing`,
    TRANSITIVEPROPERTY: `${NS}TransitiveProperty`,
    // properties
    ALLVALUESFROM: `${NS}allValuesFrom`,
    BACKWARDCOMPATIBLEWITH: `${NS}backwardCompatibleWith`,
    CARDINALITY: `${NS}cardinality`,
    COMPLEMENTOF: `${NS}complementOf`,
    DIFFERENTFROM: `${NS}differentFrom`,
    DISJOINTWITH: `${NS}disjointWith`,
    DISTINCTMEMBERS: `${NS}distinctMembers`,
    EQUIVALENTCLASS: `${NS}equivalentClass`,
    EQUIVALENTPROPERTY: `${NS}equivalentProperty`,
    HASVALUE: `${NS}hasValue`,
    IMPORTS: `${NS}imports`,
    INCOMPATIBLEWITH: `${NS}incompatibleWith`,
    INTERSECTIONOF: `${NS}intersectionOf`,
    INVERSEOF: `${NS}inverseOf`,
    MAXCARDINALITY: `${NS}maxCardinality`,
    MINCARDINALITY: `${NS}minCardinality`,
    ONEOF: `${NS}oneOf`,
    ONPROPERTY: `${NS}onProperty`,
    PRIORVERSION: `${NS}priorVersion`,
    SAMEAS: `${NS}sameAs`,
    SOMEVALUESFROM: `${NS}someValuesFrom`,
    UNIONOF: `${NS}unionOf`,
    VERSIONINFO: `${NS}versionInfo`
})