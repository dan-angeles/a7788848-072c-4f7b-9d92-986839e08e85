import React, { Component } from 'react'
import axios from 'axios'

export class GetData extends Component {
    constructor(props) {
        super(props);
        //to be able to use this method in our html code
        this.onChangeSequenceOfNumbers = this.onChangeSequenceOfNumbers.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
        this.showPopup = this.showPopup.bind(this);
        this.hidePopup = this.hidePopup.bind(this);

        this.state = {
            SequenceOfNumbers: '',
            LongestSequence:'',
            show: false
        }
    }

    onChangeSequenceOfNumbers(e){
        this.setState({
            SequenceOfNumbers: e.target.value
        });
    }

    showPopup() {
        this.setState({
            show: true
        });
    }

    hidePopup() {
        this.setState({
            show: false
        });
    }

    onSubmit(e) {
        e.preventDefault();

        let inputSequence = {
            SequenceOfNumbers: this.state.SequenceOfNumbers
        }
        axios.post("increasingsubsequence/GetLongestSequence", inputSequence).then(result => {
            const response = result.data;
            this.setState({
                LongestSequence: response
            });
        })
    }
    static Popup(LongestSequence) {
        return (
            <div className='popup' >
                <div className='popup_inner'>
                    <h1>Result</h1>
                    <p>See generated data below:</p>
                    <textarea type="text" className="form-control"
                        value={LongestSequence}/>
                </div>
            </div>
        );
    }

    render() {
        return (
            <div className="GetLongestData-form" >
                <h3>Get Longest Sequence</h3>
                <p>To use this app, type-in the sequence of numbers separated by a whitespace inside the text box.</p>
                <p>Ex. 6 2 5</p>
                <p>Then, hit the Generate button and the result will appear on your screen.</p>
                <form onSubmit={this.onSubmit} >
                    <div className="form-group">
                        <label>Sequence of Numbers: </label>
                        <textarea type="text" className="form-control"
                            value={this.state.SequenceOfNumbers}
                            onChange={this.onChangeSequenceOfNumbers} />
                    </div>

                    <div className="form-group">
                        <input type="submit" value="Generate" className="btn btn-primary" onClick={this.showPopup} />
                        {this.state.show ?
                            GetData.Popup(this.state.LongestSequence)
                            : null
                        }
                    </div>
                </form>
            </div>
        )
    }
}