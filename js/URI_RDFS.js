/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_RDFS 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_RDFS} from "./URI_RDFS.js"
        console.log(URI_RDFS.LITERAL) | console.log(URI_RDFS["LITERAL"])
        # both return "http://www.w3.org/2000/01/rdf-schema#Literal"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from legacy script and converted to ES6 module
===============================================================================
*/
const NS = "http://www.w3.org/2000/01/rdf-schema#" 
export const URI_RDFS = Object.freeze({
    // entities
    CLASS: `${NS}Class`,
    CONTAINER: `${NS}Container`,
    CONTAINERMEMBERSHIPPROPERTY: `${NS}ContainerMembershipProperty`,
    DATATYPE: `${NS}Datatype`,
    LITERAL: `${NS}Literal`,
    RESOURCE: `${NS}Resource`,
    // properties
    COMMENT: `${NS}comment`,
    DOMAIN: `${NS}domain`,
    ISDEFINEDBY: `${NS}isDefinedBy`,
    LABEL: `${NS}label`,
    MEMBER: `${NS}member`,
    RANGE: `${NS}range`,
    SEEALSO: `${NS}seeAlso`,
    SUBCLASSOF: `${NS}subClassOf`,
    SUBPROPERTYOF: `${NS}subPropertyOf`
})