import { View, Text, StyleSheet, Image, ImageBackground  } from "react-native";
import { CartLink } from "../cart/CartLink";

export const CUPCAKEWALLPAPER = require('../../assets/cupcake_wallpaper.jpg'); 

interface Props {
  onNavigateToCart: () => void;
}

const HomeView = ({ onNavigateToCart }: Props) => {
  return (
    <View>
      <ImageBackground source={CUPCAKEWALLPAPER} resizeMode="cover" style={styles.logo}>
      <View style={styles.cartLink}>
        <CartLink onNavigateToCart={onNavigateToCart} />
      </View>
      <View style={styles.title}>
        <Text style={styles.H1}>PIT CupCakes</Text>
      </View>
      </ImageBackground>
      
    </View>
  );
};

export default HomeView;

const styles = StyleSheet.create({
  title: {
    alignItems: "center",
    width: "100%",
  },
  cartLink: {
    width: "100%",
    alignItems: "flex-end",
    paddingHorizontal: 20,
    paddingVertical: 20,
  },
  logo: {
    width: "100%",
    height: "100%",
  },
  H1: {
    fontSize: 30,
    fontWeight: "400",
    color: "#FF5733",
  }
});
