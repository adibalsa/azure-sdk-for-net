// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;

	/// <summary>
	/// Role based access control provides you a way to apply granular level
	/// policy administration down to individual resources or resource groups.
	/// These operations enable you to manage role definitions and role
	/// assignments. A role definition describes the set of actions that can be
	/// performed on resources. A role assignment grants access to Azure Active
	/// Directory users.
	/// </summary>
	public partial class AuthorizationManagementClient : ServiceClient<AuthorizationManagementClient>, IAuthorizationManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IClassicAdministratorsOperations.
        /// </summary>
        public virtual IClassicAdministratorsOperations ClassicAdministrators { get; private set; }

        /// <summary>
        /// Gets the IPermissionsOperations.
        /// </summary>
        public virtual IPermissionsOperations Permissions { get; private set; }

        /// <summary>
        /// Gets the IProviderOperationsMetadataOperations.
        /// </summary>
        public virtual IProviderOperationsMetadataOperations ProviderOperationsMetadata { get; private set; }

        /// <summary>
        /// Gets the IRoleAssignmentsOperations.
        /// </summary>
        public virtual IRoleAssignmentsOperations RoleAssignments { get; private set; }

        /// <summary>
        /// Gets the IRoleDefinitionsOperations.
        /// </summary>
        public virtual IRoleDefinitionsOperations RoleDefinitions { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AuthorizationManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AuthorizationManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
			this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AuthorizationManagementClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
			this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AuthorizationManagementClient(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
			this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
			this.Credentials = credentials;
            if (this.Credentials != null)
            {
				this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
			this.Credentials = credentials;
            if (this.Credentials != null)
            {
				this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationManagementClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
			this.BaseUri = baseUri;
			this.Credentials = credentials;
            if (this.Credentials != null)
            {
				this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationManagementClient(Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
			this.BaseUri = baseUri;
			this.Credentials = credentials;
            if (this.Credentials != null)
            {
				this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
			this.ClassicAdministrators = new ClassicAdministratorsOperations(this);
			this.Permissions = new PermissionsOperations(this);
			this.ProviderOperationsMetadata = new ProviderOperationsMetadataOperations(this);
			this.RoleAssignments = new RoleAssignmentsOperations(this);
			this.RoleDefinitions = new RoleDefinitionsOperations(this);
			this.BaseUri = new Uri("https://management.azure.com");
			this.ApiVersion = "2015-07-01";
			this.AcceptLanguage = "en-US";
			this.LongRunningOperationRetryTimeout = 30;
			this.GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
			SerializationSettings.Converters.Add(new ResourceJsonConverter());
			DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize()
			DeserializationSettings.Converters.Add(new ResourceJsonConverter());
			DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
