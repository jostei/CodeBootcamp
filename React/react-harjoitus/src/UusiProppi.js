function Morotus(props) {
    return <h1>Tervetuloa, {props.name}</h1>;
  }

  function UusiProppi(){
      return(
        <div>
            <Morotus name="Jose" />
        </div>
      );
  }

  export default UusiProppi;