/*
 * Copyright (c) 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace AppStatistics.Views
{
    /// <summary>
    /// Provides methods which allow to navigate between pages.
    /// </summary>
    public interface IPageNavigation
    {
        #region methods

        /// <summary>
        /// Creates menu page and sets it as active.
        /// </summary>
        void CreateMenuPage();

        /// <summary>
        /// Creates range selection page and sets it as active.
        /// </summary>
        void CreateRangeSelectionPage();

        /// <summary>
        /// Creates battery page and sets it as active.
        /// </summary>
        /// <param name="context">The page binding context.</param>
        void CreateBatteryPage(object context);

        /// <summary>
        /// Creates launch count page and sets it as active.
        /// </summary>
        /// <param name="context">The page binding context.</param>
        void CreateLaunchCountPage(object context);

        /// <summary>
        /// Creates launch count details page and sets it as active.
        /// </summary>
        /// <param name="context">The page binding context.</param>
        void CreateLaunchCountDetailsPage(object context);

        /// <summary>
        /// Creates welcome page and sets it as active.
        /// </summary>
        void CreateWelcomePage();

        /// <summary>
        /// Creates privilege denied page and sets it as active.
        /// </summary>
        void CreatePrivilegeDeniedPage();

        /// <summary>
        /// Closes the application.
        /// </summary>
        void Close();

        /// <summary>
        /// Navigates to previous page.
        /// </summary>
        void GoBack();

        #endregion
    }
}