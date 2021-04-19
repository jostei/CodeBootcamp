function Taulukko(props){

    const rivit = [];

    for (let i = 0; i < props.määrä+1; i++) {
        rivit.push(<p>Luku: {i+1}</p>);
    }

    return <div>
        {rivit}
        </div>;
} 



export default Taulukko;