import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
import HomeScreen from "../screens/HomeScreen/HomeScreen";
import ProductScreen from "../screens/ProductScreen/ProductScreen";
import Ionicons from "@expo/vector-icons/Ionicons";
import { View, Text } from "react-native";

export const AppBottomTabNavigator = () => {
  const BottomTab = createBottomTabNavigator();

  return (
    <BottomTab.Navigator screenOptions={{ headerShown: false }}>
      <BottomTab.Screen
        name="Inicio"
        component={HomeScreen}
        options={{
          tabBarIcon: () => (
            <Text>
              <Ionicons name="home" size={22} color="blue" />
            </Text>
          ),
        }}
      />
      <BottomTab.Screen
        name="CupCakes"
        component={ProductScreen}
        options={{
          tabBarIcon: () => (
            <View>
              <Text>
                <Ionicons name="apps" size={22} color="blue" />
              </Text>
            </View>
          ),
        }}
      />
    </BottomTab.Navigator>
  );
};
