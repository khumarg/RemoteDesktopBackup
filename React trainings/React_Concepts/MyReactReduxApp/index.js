const redux = require("redux");
const createStore = redux.createStore;
const combineReducers = redux.combineReducers;

const BUY_CAKE = "BUY_CAKE";
const BUY_ICECREAM = "BUY_ICECREAM";

function buy_cake() {
    return {
        type : BUY_CAKE,
        info: 'First Redux Action'      //additional information (optional)
    }
}

function buy_icecream() {
    return {
        type: BUY_ICECREAM
    }
}

const initialCakeState = {
    numberOfCakes : 20
}

const initialIceCreamState = {
    numberOfIcecreams : 50
}

const cakeReducer = (state=initialCakeState, action) => {
    switch(action.type) {
        case BUY_CAKE : return {
            ...state,       // spread operator: first make copy of state object and then make change 
            numberOfCakes: state.numberOfCakes - 1
        }
        default: {
            return state;
        }
    }
}

const icecreamReducer = (state=initialIceCreamState, action) => {
    switch(action.type) {
        case BUY_ICECREAM : return {
            ...state,
            numberOfIcecreams: state.numberOfIcecreams - 1
        }
        default: {
            return state;
        }
    }
}

const rootReducer = combineReducers({
    cake: cakeReducer,
    icecream: icecreamReducer
})

const store = createStore(rootReducer);
console.log("Initial State", store.getState());

const unsubscribe = store.subscribe(() => {
    console.log("Updated State", store.getState())
});

store.dispatch(buy_cake());
store.dispatch(buy_cake());
store.dispatch(buy_cake());
store.dispatch(buy_icecream());
store.dispatch(buy_icecream());

unsubscribe();

store.dispatch(buy_cake());
store.dispatch(buy_cake());
store.dispatch(buy_icecream());
store.dispatch(buy_icecream());

console.log("Last State", store.getState())