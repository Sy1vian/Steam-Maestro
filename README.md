# Steam-Maestro
A powerful and user-friendly Steam account management tool designed to help users efficiently manage their Steam game library, optimize game settings, and enhance their overall gaming experience.

[中文版（停止更新）]([[https://gitgud.io/ahsk/clewd](https://github.com/Sy1vian/Steam-Maestro/blob/main/Chinese%20Program%20Description)])
## Steam 插件功能介绍（中文分支已停止维护，老用户出现问题请更新最新版本）
## Steam Plugin Feature Overview

### Game Library Management
* **Intelligent Categorization:** Employs machine learning algorithms to categorize games based on multiple dimensions such as genre, tags, playtime, and achievements, enabling users to quickly find desired games.
* **Custom Tags:** Allows users to create custom tags for more granular game categorization.
* **Favorites Management:** Create multiple favorites to organize games by theme or series.
* **Playtime Statistics:** Records detailed playtime for each game and generates visual charts.
* **Achievement Tracking:** Supports tracking of all Steam achievements and provides detailed progress displays.
* **Cloud Sync:** Synchronizes game library data to your OneDrive or other cloud storage for additional backup and customized cross-device access.

### Game Optimization
* **Automatic Configuration:** Automatically optimizes game settings and startup items based on hardware configuration and game characteristics to enhance gaming performance.
* **Custom Configuration Profiles:** Users can create multiple configuration profiles to suit different games and scenarios.
* **One-Click Configuration Switching:** Quickly switch between different configuration profiles without manual adjustment.
* **Driver Update Reminders:** Automatically detects and reminds users to update graphics drivers and other hardware drivers.

### Community Interaction
* **Message Notifications:** Real-time push notifications for friend messages, group notifications, and event invitations.
* **Quick Replies:** Supports quick replies to friend messages and group discussions, improving communication efficiency.
* **Emoji Management:** Build your own emoji library for richer chat interactions.
* **Community Event Participation:** Provides an overview of community events for easy user participation.

### Personal Profile Management
* **Customizable Profile:** Freely edit personal profile display to showcase personal gaming achievements.
* **Privacy Settings:** Fine-grained control over the visibility of personal information.
* **Friend Management:** Supports batch adding, deleting friends, and creating friend groups.

### Friend List Ranking
* **Multi-dimensional Ranking:** Ranks friends based on multiple dimensions such as playtime, achievement count, and transaction amount.
* **Custom Ranking Rules:** Users can customize ranking rules to view personalized rankings.
* **Historical Ranking Inquiry:** Backups rankings each time an update occurs, allowing users to view historical ranking data and understand ranking changes.
* **Activity:** Ranks friends based on their last online time, whether they have left messages on your profile, and whether they have interacted with you through messages or trades (note that private friend profiles may affect some accuracy).

### Message Management
* **Intelligent Filtering:** Uses machine learning algorithms to automatically filter out spam and harassing messages.
* **Custom Filtering Rules:** Supports custom keyword and regular expression filtering.
* **Message Reply Templates:** Provides common reply templates to improve reply efficiency. Cloud hosting enables 24-hour timed messaging.
* **Message Detection:** Supports regular expression-based automatic detection of messages and friend feeds for suspected keywords, automatically activating relevant actions. You can set it to automatically leave messages in relevant sections to avoid being a伸手党 (someone who asks for things without giving anything in return) after successful detection.

### Friend Management
* **Intelligent Recommendation:** Recommends potential friends based on user game preferences.
* **Customizable Friend Request Filtering Rules:** Supports filtering friend requests based on games, regions, online time, level, etc. (This part of the code refers to Steam Inventory Helper)
* **Intelligent Deletion:** Customizes automatic deletion of friends who meet certain conditions, such as automatically deleting friends who have not been online for N days. (Private or hidden friend profiles may be mistakenly deleted, so a whitelist and additional detection of messages and other interactions are provided)

### Trade Management
* **Trade History Inquiry:** Provides detailed, visualizable, and chart-based trade history records.
* **Price Monitoring:** Set price monitoring and receive notifications when item prices reach a set value.
* **Batch Listing/Purchasing:** Supports batch listing and purchasing of items. Provides detailed customized conditions for automated trading.
* **Market Analysis:** Provides price trends for Steam market game items, helping users make more informed trading decisions.
* **Batch Management:** Supports batch listing and delisting of items.
* **Trade Reminders:** Set trade reminders to avoid missing out on trading opportunities.

### Event-Related
* **Event Calendar:** Displays current and upcoming Steam events.
* **Discount Reminders:** Set price monitoring and receive reminders when desired games are on sale.
* **Free Game Alerts:**  Remind users of free game giveaways. Automatically add eligible games to the library, a boon for bundle enthusiasts.

### Additional Features

* **Screenshot Management: Automatically save highlight and achievement screenshots for supported games (currently limited to CS2) with categorization and search capabilities.

* **Game News Feed: Real-time updates on high-quality game news, reviews, and more.

* **Plugin Extensions: Support custom plugins for extended functionality.

### Technical Implementation

* **Frontend: React/Vue + TypeScript
* **Backend: Node.js + Express
* **Database: MongoDB
* **Cloud Services: AWS/Azure

### Future Plans

 * **Game Data Analysis: Provide deeper insights into game data to help users understand their gaming patterns.
 * **Community Forum: Establish a dedicated community forum for plugin users to connect and share.
 * **AI Assistant: Integrate AI technology for intelligent game recommendations and strategy guides.

