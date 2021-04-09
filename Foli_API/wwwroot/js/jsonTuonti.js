// Noutaa JSON muotoista infoa Fölistä

$("#noutoNappi").click(
    async function () {

        const apiURL = "http://data.foli.fi/citybike/pretty";

        fetch(apiURL)
            .then(response => response.json())
            .then(data => console.log(data));
    }
)